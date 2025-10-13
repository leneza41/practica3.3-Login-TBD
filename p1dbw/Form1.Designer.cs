namespace p1dbw
{
    partial class Form1
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
            x = new Button();
            login = new TextBox();
            label1 = new Label();
            password = new TextBox();
            SuspendLayout();
            // 
            // x
            // 
            x.Font = new Font("Segoe UI", 15F);
            x.Location = new Point(209, 283);
            x.Name = "x";
            x.Size = new Size(205, 45);
            x.TabIndex = 0;
            x.Text = "Ingresar";
            x.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            login.Font = new Font("Segoe UI", 16F);
            login.Location = new Point(64, 116);
            login.Name = "login";
            login.Size = new Size(350, 43);
            login.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(183, 40);
            label1.Name = "label1";
            label1.Size = new Size(110, 46);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 16F);
            password.Location = new Point(64, 184);
            password.Name = "password";
            password.Size = new Size(350, 43);
            password.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 370);
            Controls.Add(password);
            Controls.Add(label1);
            Controls.Add(login);
            Controls.Add(x);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button x;
        private TextBox login;
        private Label label1;
        private TextBox password;
    }
}
