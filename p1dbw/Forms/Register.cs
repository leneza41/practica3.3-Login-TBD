using p1dbw.Utils;

namespace p1dbw
{
    public partial class Register : Form
    {
        private readonly ApiClient _apiClient;
       
        public Register()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            
            string name = txtName.Text.Trim();
            string lastname = txtLastname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string repeatPassword = txtRepeat.Text;
            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repeatPassword))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRegister.Enabled = true;
                return;
            }

            if (password != repeatPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRegister.Enabled = true;
                return;
            }

            try
            {
                if (!Validators.isValidEmail(email))
                {
                    MessageBox.Show("El correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnRegister.Enabled = true;
                    return;
                }
                var user = new Models.UserRequest
                {
                    Name = name,
                    Lastname = lastname,
                    Username = username,
                    Email = email,
                    Password = password
                };
                var response = await _apiClient.RegisterAsync(user);
                if (response.StartsWith("Error:"))
                {
                    MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Registro exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRegister.Enabled = true;
            }
        }
    }
}
