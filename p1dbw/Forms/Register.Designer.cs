namespace p1dbw
{
    partial class Register
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
            btnRegister = new Button();
            txtName = new TextBox();
            label1 = new Label();
            txtLastname = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtRepeat = new TextBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 15F);
            btnRegister.Location = new Point(392, 620);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(337, 57);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtName
            // 
            txtName.AcceptsTab = true;
            txtName.Font = new Font("Segoe UI", 18F);
            txtName.Location = new Point(64, 94);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nombre";
            txtName.Size = new Size(665, 47);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 67);
            label1.TabIndex = 2;
            label1.Text = "Registrar";
            // 
            // txtLastname
            // 
            txtLastname.AcceptsTab = true;
            txtLastname.Font = new Font("Segoe UI", 18F);
            txtLastname.Location = new Point(64, 184);
            txtLastname.Name = "txtLastname";
            txtLastname.PlaceholderText = "Apellidos";
            txtLastname.Size = new Size(665, 47);
            txtLastname.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.AcceptsTab = true;
            txtUsername.Font = new Font("Segoe UI", 18F);
            txtUsername.Location = new Point(64, 271);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Nombre de Usuario";
            txtUsername.Size = new Size(665, 47);
            txtUsername.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.AcceptsTab = true;
            txtEmail.Font = new Font("Segoe UI", 18F);
            txtEmail.Location = new Point(64, 359);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Correo Electrónico";
            txtEmail.Size = new Size(665, 47);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.AcceptsTab = true;
            txtPassword.Font = new Font("Segoe UI", 18F);
            txtPassword.Location = new Point(64, 442);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(665, 47);
            txtPassword.TabIndex = 6;
            // 
            // txtRepeat
            // 
            txtRepeat.AcceptsTab = true;
            txtRepeat.Font = new Font("Segoe UI", 18F);
            txtRepeat.Location = new Point(64, 528);
            txtRepeat.Name = "txtRepeat";
            txtRepeat.PasswordChar = '*';
            txtRepeat.PlaceholderText = "Repetir Contraseña";
            txtRepeat.Size = new Size(665, 47);
            txtRepeat.TabIndex = 7;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 710);
            Controls.Add(txtRepeat);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtLastname);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnRegister);
            Name = "Register";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtName;
        private Label label1;
        private TextBox txtLastname;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtRepeat;
    }
}
