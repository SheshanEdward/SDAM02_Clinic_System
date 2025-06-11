namespace SDAM02_Clinic_System.views
{
    partial class patient_dashboard
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
            appointmentsbtn = new Button();
            profilebtn = new Button();
            prescriptionsbtn = new Button();
            patientAccountbtn = new Button();
            doctorsbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(290, 23);
            label1.Name = "label1";
            label1.Size = new Size(189, 35);
            label1.TabIndex = 0;
            label1.Text = "Choose Option ";
            // 
            // appointmentsbtn
            // 
            appointmentsbtn.BackColor = SystemColors.GradientActiveCaption;
            appointmentsbtn.Location = new Point(315, 132);
            appointmentsbtn.Name = "appointmentsbtn";
            appointmentsbtn.Size = new Size(164, 61);
            appointmentsbtn.TabIndex = 1;
            appointmentsbtn.Text = "Appointments ";
            appointmentsbtn.UseVisualStyleBackColor = false;
            // 
            // profilebtn
            // 
            profilebtn.BackColor = SystemColors.GradientActiveCaption;
            profilebtn.Location = new Point(72, 131);
            profilebtn.Name = "profilebtn";
            profilebtn.Size = new Size(167, 61);
            profilebtn.TabIndex = 2;
            profilebtn.Text = "Profile ";
            profilebtn.UseVisualStyleBackColor = false;
            // 
            // prescriptionsbtn
            // 
            prescriptionsbtn.BackColor = SystemColors.GradientActiveCaption;
            prescriptionsbtn.Location = new Point(556, 133);
            prescriptionsbtn.Name = "prescriptionsbtn";
            prescriptionsbtn.Size = new Size(156, 60);
            prescriptionsbtn.TabIndex = 3;
            prescriptionsbtn.Text = "Prescriptions ";
            prescriptionsbtn.UseVisualStyleBackColor = false;
            // 
            // patientAccountbtn
            // 
            patientAccountbtn.BackColor = SystemColors.GradientActiveCaption;
            patientAccountbtn.Location = new Point(164, 251);
            patientAccountbtn.Name = "patientAccountbtn";
            patientAccountbtn.Size = new Size(153, 63);
            patientAccountbtn.TabIndex = 4;
            patientAccountbtn.Text = "Account";
            patientAccountbtn.UseVisualStyleBackColor = false;
            // 
            // doctorsbtn
            // 
            doctorsbtn.BackColor = SystemColors.GradientActiveCaption;
            doctorsbtn.Location = new Point(442, 250);
            doctorsbtn.Name = "doctorsbtn";
            doctorsbtn.Size = new Size(149, 59);
            doctorsbtn.TabIndex = 5;
            doctorsbtn.Text = "Doctors ";
            doctorsbtn.UseVisualStyleBackColor = false;
            // 
            // patient_dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(doctorsbtn);
            Controls.Add(patientAccountbtn);
            Controls.Add(prescriptionsbtn);
            Controls.Add(profilebtn);
            Controls.Add(appointmentsbtn);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Name = "patient_dashboard";
            Text = "User_dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button appointmentsbtn;
        private Button profilebtn;
        private Button prescriptionsbtn;
        private Button patientAccountbtn;
        private Button doctorsbtn;
    }
}