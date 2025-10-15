using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using API.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.Data;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly string _connection;

        public UsersController(IConfiguration configuration)
        {
            _connection = configuration.GetConnectionString("DefaultConnection")!;
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody] UsersRequest user)
        {
            if (string.IsNullOrWhiteSpace(user.Name) ||
                string.IsNullOrWhiteSpace(user.Lastname) ||
                string.IsNullOrWhiteSpace(user.Username) ||
                string.IsNullOrWhiteSpace(user.Email) ||
                string.IsNullOrWhiteSpace(user.Password))
            {
                return BadRequest("Hay campos faltantes");
            }

            using var connection = new MySqlConnection(_connection);
            connection.Open();

            var existingEmailOrUsername = new MySqlCommand(
                "SELECT COUNT(*) FROM users" +
                " WHERE email=@email OR username=@username", connection);
            existingEmailOrUsername.Parameters.AddWithValue("@username", user.Username);
            existingEmailOrUsername.Parameters.AddWithValue("@email", user.Email);

            var count = Convert.ToInt32(existingEmailOrUsername.ExecuteScalar());
            if (count > 0)
            {
                return Conflict("El correo o nombre de usuario ya están en uso");
            }

            var command = new MySqlCommand(
                "INSERT INTO users (name, lastname, username, email, password) " +
                "VALUES (@name, @lastname, @username, @email, SHA2(@password, 256))", connection);
            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@lastname", user.Lastname);
            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@password", user.Password);

            var result = command.ExecuteNonQuery();

            return result > 0 ? Ok("Usuario registrado exitosamente") : StatusCode(500, "Error al registrar el usuario");
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            using var connection = new MySqlConnection(_connection);
            connection.Open();


            var cmd = new MySqlCommand(
                "SELECT id, name, lastname, username, email, createdAt " +
                "FROM users", connection);

            var users = new List<object>();

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Lastname = reader.GetString("lastname"),
                    Username = reader.GetString("username"),
                    Email = reader.GetString("email"),
                    CreatedAt = reader.GetDateTime("createdAt")
                });
            }

            return Ok(users);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestCustom login)
        {
            await using var connection = new MySqlConnection(_connection);
            await connection.OpenAsync();

            var command = new MySqlCommand(
                "SELECT COUNT(*) FROM users WHERE " +
                "username=@username AND password=SHA2(@password, 256)", connection);
            command.Parameters.AddWithValue("@username", login.Username);
            command.Parameters.AddWithValue("@password", login.Password);

            var result = Convert.ToInt32(await command.ExecuteScalarAsync());

            if (result > 0)
            {
                return Ok("Inicio de sesión exitoso");
            }
            else
            {
                return Unauthorized("Usuario o contraseña incorrectos");
            }

        }
    }
}
