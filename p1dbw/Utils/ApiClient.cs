using API.Models;
using p1dbw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1dbw.Utils
{
    internal class ApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string baseURL = "http://localhost:5093/Users/";

        public ApiClient()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(baseURL) };
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<string> RegisterAsync(UserRequest user)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            var response = await _httpClient.PostAsync("register", content);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            var errorContent = await response.Content.ReadAsStringAsync();
            return $"Error: {response.StatusCode}, Details: {errorContent}";
        }

        public async Task<string> Login(LoginRequestCustom loginRequest)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(loginRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("login", content);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            var errorContent = await response.Content.ReadAsStringAsync();
            return $"Error: {response.StatusCode}, Details: {errorContent}";
        }

        public async Task<List<UserResponse>> GetUsersAsync()
        {
            var response = await _httpClient.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return System.Text.Json.JsonSerializer.Deserialize<List<UserResponse>>(json,
                    new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            throw new Exception($"Error: {response.StatusCode}, Details: {await response.Content.ReadAsStringAsync()}");
        }
    }
}
