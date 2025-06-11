namespace SDAM02_Clinic_System.views
{
    partial class patient_register
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
            firstNameTxt = new TextBox();
            heightTxt = new TextBox();
            contactTxt = new TextBox();
            emailTxt = new TextBox();
            FirstNamelbl = new Label();
            doblbl = new Label();
            Heightlbl = new Label();
            Contactlbl = new Label();
            Emaillbl = new Label();
            registerPatientlbl = new Label();
            LastNamelbl = new Label();
            lastNameTxt = new TextBox();
            nicTxt = new TextBox();
            weightTxt = new TextBox();
            NIClbl = new Label();
            Weightlbl = new Label();
            BloodGrouplbl = new Label();
            mhlbl = new Label();
            bloodGroupTxt = new TextBox();
            medicalHistoryTxt = new TextBox();
            Registerbtn = new Button();
            dobTxt = new ComboBox();
            SuspendLayout();
            // 
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(114, 71);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(239, 27);
            firstNameTxt.TabIndex = 0;
            firstNameTxt.TextChanged += textBox1_TextChanged;
            // 
            // heightTxt
            // 
            heightTxt.Location = new Point(120, 191);
            heightTxt.Name = "heightTxt";
            heightTxt.Size = new Size(232, 27);
            heightTxt.TabIndex = 2;
            // 
            // contactTxt
            // 
            contactTxt.Location = new Point(121, 255);
            contactTxt.Name = "contactTxt";
            contactTxt.Size = new Size(232, 27);
            contactTxt.TabIndex = 3;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(495, 251);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(239, 27);
            emailTxt.TabIndex = 4;
            // 
            // FirstNamelbl
            // 
            FirstNamelbl.AutoSize = true;
            FirstNamelbl.Location = new Point(16, 74);
            FirstNamelbl.Name = "FirstNamelbl";
            FirstNamelbl.Size = new Size(84, 20);
            FirstNamelbl.TabIndex = 5;
            FirstNamelbl.Text = "First Name ";
            FirstNamelbl.Click += label1_Click;
            // 
            // doblbl
            // 
            doblbl.AutoSize = true;
            doblbl.Location = new Point(17, 132);
            doblbl.Name = "doblbl";
            doblbl.Size = new Size(40, 20);
            doblbl.TabIndex = 6;
            doblbl.Text = "DOB";
            doblbl.Click += doblbl_Click;
            // 
            // Heightlbl
            // 
            Heightlbl.AutoSize = true;
            Heightlbl.Location = new Point(17, 196);
            Heightlbl.Name = "Heightlbl";
            Heightlbl.Size = new Size(58, 20);
            Heightlbl.TabIndex = 7;
            Heightlbl.Text = "Height ";
            // 
            // Contactlbl
            // 
            Contactlbl.AutoSize = true;
            Contactlbl.Location = new Point(15, 256);
            Contactlbl.Name = "Contactlbl";
            Contactlbl.Size = new Size(64, 20);
            Contactlbl.TabIndex = 8;
            Contactlbl.Text = "Contact ";
            // 
            // Emaillbl
            // 
            Emaillbl.AutoSize = true;
            Emaillbl.Location = new Point(375, 258);
            Emaillbl.Name = "Emaillbl";
            Emaillbl.Size = new Size(50, 20);
            Emaillbl.TabIndex = 9;
            Emaillbl.Text = "Email ";
            // 
            // registerPatientlbl
            // 
            registerPatientlbl.AutoSize = true;
            registerPatientlbl.Font = new Font("Segoe UI", 14F);
            registerPatientlbl.Location = new Point(297, 9);
            registerPatientlbl.Name = "registerPatientlbl";
            registerPatientlbl.Size = new Size(227, 32);
            registerPatientlbl.TabIndex = 10;
            registerPatientlbl.Text = "Patient Registration ";
            registerPatientlbl.Click += registerPatientlbl_Click;
            // 
            // LastNamelbl
            // 
            LastNamelbl.AutoSize = true;
            LastNamelbl.Location = new Point(373, 72);
            LastNamelbl.Name = "LastNamelbl";
            LastNamelbl.Size = new Size(83, 20);
            LastNamelbl.TabIndex = 11;
            LastNamelbl.Text = "Last Name ";
            // 
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(484, 68);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(248, 27);
            lastNameTxt.TabIndex = 12;
            // 
            // nicTxt
            // 
            nicTxt.Location = new Point(489, 127);
            nicTxt.Name = "nicTxt";
            nicTxt.Size = new Size(243, 27);
            nicTxt.TabIndex = 13;
            // 
            // weightTxt
            // 
            weightTxt.Location = new Point(493, 191);
            weightTxt.Name = "weightTxt";
            weightTxt.Size = new Size(239, 27);
            weightTxt.TabIndex = 14;
            // 
            // NIClbl
            // 
            NIClbl.AutoSize = true;
            NIClbl.Location = new Point(383, 130);
            NIClbl.Name = "NIClbl";
            NIClbl.Size = new Size(33, 20);
            NIClbl.TabIndex = 15;
            NIClbl.Text = "NIC";
            // 
            // Weightlbl
            // 
            Weightlbl.AutoSize = true;
            Weightlbl.Location = new Point(374, 194);
            Weightlbl.Name = "Weightlbl";
            Weightlbl.Size = new Size(60, 20);
            Weightlbl.TabIndex = 16;
            Weightlbl.Text = "Weight ";
            // 
            // BloodGrouplbl
            // 
            BloodGrouplbl.AutoSize = true;
            BloodGrouplbl.Location = new Point(13, 309);
            BloodGrouplbl.Name = "BloodGrouplbl";
            BloodGrouplbl.Size = new Size(98, 20);
            BloodGrouplbl.TabIndex = 17;
            BloodGrouplbl.Text = "Blood Group ";
            // 
            // mhlbl
            // 
            mhlbl.AutoSize = true;
            mhlbl.Location = new Point(371, 312);
            mhlbl.Name = "mhlbl";
            mhlbl.Size = new Size(117, 20);
            mhlbl.TabIndex = 18;
            mhlbl.Text = "Medical History ";
            mhlbl.Click += mhlbl_Click;
            // 
            // bloodGroupTxt
            // 
            bloodGroupTxt.Location = new Point(121, 306);
            bloodGroupTxt.Name = "bloodGroupTxt";
            bloodGroupTxt.Size = new Size(231, 27);
            bloodGroupTxt.TabIndex = 19;
            // 
            // medicalHistoryTxt
            // 
            medicalHistoryTxt.Location = new Point(492, 306);
            medicalHistoryTxt.Name = "medicalHistoryTxt";
            medicalHistoryTxt.Size = new Size(240, 27);
            medicalHistoryTxt.TabIndex = 20;
            // 
            // Registerbtn
            // 
            Registerbtn.BackColor = Color.SkyBlue;
            Registerbtn.Font = new Font("Segoe UI", 12F);
            Registerbtn.Location = new Point(346, 379);
            Registerbtn.Name = "Registerbtn";
            Registerbtn.Size = new Size(110, 43);
            Registerbtn.TabIndex = 21;
            Registerbtn.Text = "Register ";
            Registerbtn.UseVisualStyleBackColor = false;
            Registerbtn.Click += Registerbtn_Click;
            // 
            // dobTxt
            // 
            dobTxt.FormattingEnabled = true;
            dobTxt.Location = new Point(120, 132);
            dobTxt.Name = "dobTxt";
            dobTxt.Size = new Size(233, 28);
            dobTxt.TabIndex = 22;
            // 
            // patient_register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dobTxt);
            Controls.Add(Registerbtn);
            Controls.Add(medicalHistoryTxt);
            Controls.Add(bloodGroupTxt);
            Controls.Add(mhlbl);
            Controls.Add(BloodGrouplbl);
            Controls.Add(Weightlbl);
            Controls.Add(NIClbl);
            Controls.Add(weightTxt);
            Controls.Add(nicTxt);
            Controls.Add(lastNameTxt);
            Controls.Add(LastNamelbl);
            Controls.Add(registerPatientlbl);
            Controls.Add(Emaillbl);
            Controls.Add(Contactlbl);
            Controls.Add(Heightlbl);
            Controls.Add(doblbl);
            Controls.Add(FirstNamelbl);
            Controls.Add(emailTxt);
            Controls.Add(contactTxt);
            Controls.Add(heightTxt);
            Controls.Add(firstNameTxt);
            Name = "patient_register";
            Text = "patient_register";
            Load += patient_register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTxt;
        private TextBox heightTxt;
        private TextBox contactTxt;
        private TextBox emailTxt;
        private Label FirstNamelbl;
        private Label doblbl;
        private Label Heightlbl;
        private Label Contactlbl;
        private Label Emaillbl;
        private Label registerPatientlbl;
        private Label LastNamelbl;
        private TextBox lastNameTxt;
        private TextBox nicTxt;
        private TextBox weightTxt;
        private Label NIClbl;
        private Label Weightlbl;
        private Label BloodGrouplbl;
        private Label mhlbl;
        private TextBox bloodGroupTxt;
        private TextBox medicalHistoryTxt;
        private Button Registerbtn;
        private ComboBox dobTxt;
    }
}