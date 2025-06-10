namespace SDAM02_Clinic_System.views
{
    partial class admin_register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnRegister = new Button();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtNICnumber = new TextBox();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            dtpDoB = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 69);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 69);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 119);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "NIC number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 172);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "Mobile";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 119);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 4;
            label5.Text = "DoB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 172);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(237, 9);
            label7.Name = "label7";
            label7.Size = new Size(306, 35);
            label7.TabIndex = 6;
            label7.Text = "Administrator Registration";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 230);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 7;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 304);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 8;
            label9.Text = "Username";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(422, 304);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 9;
            label10.Text = "Password";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F);
            btnRegister.Location = new Point(345, 380);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(97, 38);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(119, 66);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(251, 27);
            txtFirstname.TabIndex = 11;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(498, 66);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(290, 27);
            txtLastname.TabIndex = 12;
            // 
            // txtNICnumber
            // 
            txtNICnumber.Location = new Point(498, 116);
            txtNICnumber.Name = "txtNICnumber";
            txtNICnumber.Size = new Size(286, 27);
            txtNICnumber.TabIndex = 13;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(119, 169);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(251, 27);
            txtMobile.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(498, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(286, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(119, 227);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(665, 27);
            txtAddress.TabIndex = 16;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(119, 301);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(251, 27);
            txtUsername.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(498, 301);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(286, 27);
            txtPassword.TabIndex = 18;
            // 
            // dtpDoB
            // 
            dtpDoB.Location = new Point(119, 114);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(251, 27);
            dtpDoB.TabIndex = 19;
            // 
            // admin_register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDoB);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(txtNICnumber);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(btnRegister);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "admin_register";
            Text = "admin_register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnRegister;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtNICnumber;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private DateTimePicker dtpDoB;
    }
}