
namespace SDAM02_Clinic_System.views
{
    partial class PatientProfileDashboard
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
            label11 = new Label();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            dtpDoB = new DateTimePicker();
            cmbGender = new ComboBox();
            cmbBloodtype = new ComboBox();
            txtHeight = new TextBox();
            txtMobile = new TextBox();
            txtNic = new TextBox();
            txtWeight = new TextBox();
            txtEmail = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtAddress = new TextBox();
            txtPassword = new TextBox();
            btnSaveEditedAccount = new Button();
            btnDeleteAccount = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 18);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Patient Profile ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 107);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "DoB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 70);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Last Name ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 116);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 4;
            label5.Text = "NIC Number ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 157);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "Gender ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 209);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 6;
            label7.Text = "Height ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 256);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 7;
            label8.Text = "Mobile";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(369, 157);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 8;
            label9.Text = "Blood Type";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(369, 204);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 9;
            label10.Text = "Weight ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(369, 247);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 10;
            label11.Text = "Email ";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(107, 60);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(227, 27);
            txtFirstname.TabIndex = 11;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(467, 69);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(248, 27);
            txtLastname.TabIndex = 12;
            // 
            // dtpDoB
            // 
            dtpDoB.Location = new Point(101, 100);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(233, 27);
            dtpDoB.TabIndex = 13;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(98, 149);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(236, 28);
            cmbGender.TabIndex = 14;
            // 
            // cmbBloodtype
            // 
            cmbBloodtype.FormattingEnabled = true;
            cmbBloodtype.Location = new Point(472, 158);
            cmbBloodtype.Name = "cmbBloodtype";
            cmbBloodtype.Size = new Size(243, 28);
            cmbBloodtype.TabIndex = 15;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(97, 206);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(237, 27);
            txtHeight.TabIndex = 16;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(99, 253);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(235, 27);
            txtMobile.TabIndex = 17;
            // 
            // txtNic
            // 
            txtNic.Location = new Point(475, 114);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(240, 27);
            txtNic.TabIndex = 18;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(468, 204);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(247, 27);
            txtWeight.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(473, 249);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 27);
            txtEmail.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 309);
            label12.Name = "label12";
            label12.Size = new Size(66, 20);
            label12.TabIndex = 21;
            label12.Text = "Address ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 352);
            label13.Name = "label13";
            label13.Size = new Size(74, 20);
            label13.TabIndex = 22;
            label13.Text = "Password ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(101, 306);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(433, 27);
            txtAddress.TabIndex = 23;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(99, 354);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(435, 27);
            txtPassword.TabIndex = 24;
            // 
            // btnSaveEditedAccount
            // 
            btnSaveEditedAccount.Location = new Point(64, 403);
            btnSaveEditedAccount.Name = "btnSaveEditedAccount";
            btnSaveEditedAccount.Size = new Size(185, 29);
            btnSaveEditedAccount.TabIndex = 25;
            btnSaveEditedAccount.Text = "Save Edited  Account ";
            btnSaveEditedAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(342, 402);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(130, 29);
            btnDeleteAccount.TabIndex = 26;
            btnDeleteAccount.Text = "Delete Account ";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(621, 402);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 27;
            btnBack.Text = "Back ";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // PatientProfileDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnSaveEditedAccount);
            Controls.Add(txtPassword);
            Controls.Add(txtAddress);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtEmail);
            Controls.Add(txtWeight);
            Controls.Add(txtNic);
            Controls.Add(txtMobile);
            Controls.Add(txtHeight);
            Controls.Add(cmbBloodtype);
            Controls.Add(cmbGender);
            Controls.Add(dtpDoB);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(label11);
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
            Name = "PatientProfileDashboard";
            Text = "PatientProfileDashboard";
            Load += PatientProfileDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void PatientProfileDashboard_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private Label label11;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private DateTimePicker dtpDoB;
        private ComboBox cmbGender;
        private ComboBox cmbBloodtype;
        private TextBox txtHeight;
        private TextBox txtMobile;
        private TextBox txtNic;
        private TextBox txtWeight;
        private TextBox txtEmail;
        private Label label12;
        private Label label13;
        private TextBox txtAddress;
        private TextBox txtPassword;
        private Button btnSaveEditedAccount;
        private Button btnDeleteAccount;
        private Button btnBack;
    }
}