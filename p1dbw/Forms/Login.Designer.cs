namespace p1dbw
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            txtUsername = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            linkRegister = new LinkLabel();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 15F);
            btnLogin.Location = new Point(257, 416);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(472, 57);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 24F);
            txtUsername.Location = new Point(64, 183);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Usuario";
            txtUsername.Size = new Size(665, 61);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 41F, FontStyle.Bold);
            label1.Location = new Point(268, 45);
            label1.Name = "label1";
            label1.Size = new Size(221, 92);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 24F);
            txtPassword.Location = new Point(64, 285);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(665, 61);
            txtPassword.TabIndex = 3;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Segoe UI", 15F);
            linkRegister.Location = new Point(352, 366);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(377, 35);
            linkRegister.TabIndex = 4;
            linkRegister.TabStop = true;
            linkRegister.Text = "¿No tienes una cuenta? Crea una";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 507);
            Controls.Add(linkRegister);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Form1";
            FormClosed += Login_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsername;
        private Label label1;
        private TextBox txtPassword;
        private LinkLabel linkRegister;
    }
}
