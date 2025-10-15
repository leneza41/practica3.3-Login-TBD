using API.Models;
using p1dbw.Utils;
using p1dbw.Forms;

namespace p1dbw
{
    public partial class Login : Form
    {
        private Register register;
        private readonly ApiClient _apiClient = new ApiClient();

        public Login()
        {
            InitializeComponent();
            this.FormClosed += Login_FormClosed;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var loginRequest = new LoginRequestCustom
            {
                Username = username,
                Password = password
            };

            var response = await _apiClient.Login(loginRequest);

            if (response.StartsWith("Error:"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var mainForm = new MainForm(this);
                mainForm.Show();
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (register == null || register.IsDisposed)
            {
                register = new Register();
                register.FormClosed += (s, args) => register = null;
                register.Show();
            }
            else
            {
                register.BringToFront();
                register.Focus();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
