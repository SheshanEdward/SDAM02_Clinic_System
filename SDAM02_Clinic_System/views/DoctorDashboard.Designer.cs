namespace SDAM02_Clinic_System.views
{
    partial class DoctorDashboard
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
            btnProfile = new Button();
            btnSchedule = new Button();
            btnPrescription = new Button();
            btnPatients = new Button();
            btnAppointments = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 39);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(105, 142);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(94, 29);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(305, 142);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(94, 29);
            btnSchedule.TabIndex = 2;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = true;
            // 
            // btnPrescription
            // 
            btnPrescription.Location = new Point(203, 260);
            btnPrescription.Name = "btnPrescription";
            btnPrescription.Size = new Size(120, 37);
            btnPrescription.TabIndex = 3;
            btnPrescription.Text = "Prescription";
            btnPrescription.UseVisualStyleBackColor = true;
            // 
            // btnPatients
            // 
            btnPatients.Location = new Point(442, 258);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(106, 41);
            btnPatients.TabIndex = 4;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = true;
            // 
            // btnAppointments
            // 
            btnAppointments.Location = new Point(552, 142);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(117, 38);
            btnAppointments.TabIndex = 5;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            // 
            // DoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAppointments);
            Controls.Add(btnPatients);
            Controls.Add(btnPrescription);
            Controls.Add(btnSchedule);
            Controls.Add(btnProfile);
            Controls.Add(label1);
            Name = "DoctorDashboard";
            Text = "DoctorDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProfile;
        private Button btnSchedule;
        private Button btnPrescription;
        private Button btnPatients;
        private Button btnAppointments;
    }
}