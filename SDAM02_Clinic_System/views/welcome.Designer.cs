namespace SDAM02_Clinic_System
{
    partial class welcome
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            txtPassword = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(305, 41);
            label1.Name = "label1";
            label1.Size = new Size(208, 57);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(177, 141);
            label2.Name = "label2";
            label2.Size = new Size(127, 35);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(177, 193);
            label3.Name = "label3";
            label3.Size = new Size(120, 35);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 355);
            label4.Name = "label4";
            label4.Size = new Size(303, 20);
            label4.TabIndex = 3;
            label4.Text = "Don't have an account? Click here to regsiter";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(310, 149);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(298, 27);
            txtUsername.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 15F);
            btnLogin.Location = new Point(334, 257);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(113, 42);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(486, 351);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(310, 201);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(298, 27);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "welcome";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private Button btnLogin;
        private Button btnRegister;
        private MaskedTextBox txtPassword;
    }
}
