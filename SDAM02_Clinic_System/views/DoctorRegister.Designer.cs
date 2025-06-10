namespace SDAM02_Clinic_System.views
{
    partial class DoctorRegister
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
            cmbSpecialization = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnApproval = new Button();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtNICnumber = new TextBox();
            txtSLMCnumber = new TextBox();
            txtEmail = new TextBox();
            txtMobile = new TextBox();
            txtAddress = new TextBox();
            dtpDoB = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(282, -4);
            label1.Name = "label1";
            label1.Size = new Size(231, 35);
            label1.TabIndex = 0;
            label1.Text = "Doctor Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 69);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Firstname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 67);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Lastname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 117);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "NIC number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 113);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 4;
            label5.Text = "SLMC Register no";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 231);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(460, 227);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 6;
            label7.Text = "Mobile";
            // 
            // cmbSpecialization
            // 
            cmbSpecialization.FormattingEnabled = true;
            cmbSpecialization.Location = new Point(127, 166);
            cmbSpecialization.Name = "cmbSpecialization";
            cmbSpecialization.Size = new Size(223, 28);
            cmbSpecialization.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(478, 169);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 8;
            label8.Text = "DoB";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 282);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 9;
            label9.Text = "Address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 171);
            label10.Name = "label10";
            label10.Size = new Size(102, 20);
            label10.TabIndex = 10;
            label10.Text = "Specialization";
            // 
            // btnApproval
            // 
            btnApproval.Font = new Font("Segoe UI", 12F);
            btnApproval.Location = new Point(301, 352);
            btnApproval.Name = "btnApproval";
            btnApproval.Size = new Size(212, 39);
            btnApproval.TabIndex = 11;
            btnApproval.Text = "Submit for Approval";
            btnApproval.UseVisualStyleBackColor = true;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(127, 64);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(223, 27);
            txtFirstname.TabIndex = 12;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(522, 62);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(251, 27);
            txtLastname.TabIndex = 13;
            // 
            // txtNICnumber
            // 
            txtNICnumber.Location = new Point(127, 113);
            txtNICnumber.Name = "txtNICnumber";
            txtNICnumber.Size = new Size(221, 27);
            txtNICnumber.TabIndex = 14;
            // 
            // txtSLMCnumber
            // 
            txtSLMCnumber.Location = new Point(522, 110);
            txtSLMCnumber.Name = "txtSLMCnumber";
            txtSLMCnumber.Size = new Size(251, 27);
            txtSLMCnumber.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 224);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 27);
            txtEmail.TabIndex = 16;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(522, 221);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(251, 27);
            txtMobile.TabIndex = 17;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(127, 279);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(646, 27);
            txtAddress.TabIndex = 18;
            // 
            // dtpDoB
            // 
            dtpDoB.Location = new Point(522, 164);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(251, 27);
            dtpDoB.TabIndex = 19;
            // 
            // DoctorRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDoB);
            Controls.Add(txtAddress);
            Controls.Add(txtMobile);
            Controls.Add(txtEmail);
            Controls.Add(txtSLMCnumber);
            Controls.Add(txtNICnumber);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(btnApproval);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cmbSpecialization);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DoctorRegister";
            Text = "DoctorRegister";
            Load += DoctorRegister_Load;
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
        private ComboBox cmbSpecialization;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnApproval;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtNICnumber;
        private TextBox txtSLMCnumber;
        private TextBox txtEmail;
        private TextBox txtMobile;
        private TextBox txtAddress;
        private DateTimePicker dtpDoB;
    }
}