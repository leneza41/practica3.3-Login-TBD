using p1dbw.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1dbw.Forms
{
    public partial class MainForm : Form
    {
        private readonly ApiClient _apiClient = new ApiClient();
        private readonly Form _loginForm;

        public MainForm(Form loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            this.FormClosed += (s, e) => _loginForm.Show();
        }

        private async void LoadUsers()
        {
            try
            {
                var users = await _apiClient.GetUsersAsync();
                dataGridView1.DataSource = users;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}");
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
