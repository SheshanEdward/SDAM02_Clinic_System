namespace SDAM02_Clinic_System.views
{
    partial class PatientDashboard
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
            btnAppointments = new Button();
            btnPrescriptions = new Button();
            btnDoctors = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 29);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(66, 127);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(94, 29);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.Location = new Point(228, 127);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(114, 29);
            btnAppointments.TabIndex = 2;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnPrescriptions
            // 
            btnPrescriptions.Location = new Point(405, 127);
            btnPrescriptions.Name = "btnPrescriptions";
            btnPrescriptions.Size = new Size(111, 29);
            btnPrescriptions.TabIndex = 4;
            btnPrescriptions.Text = "Prescriptions";
            btnPrescriptions.UseVisualStyleBackColor = true;
            btnPrescriptions.Click += btnPrescriptions_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.Location = new Point(579, 127);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(94, 29);
            btnDoctors.TabIndex = 5;
            btnDoctors.Text = "Doctors";
            btnDoctors.UseVisualStyleBackColor = true;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // PatientDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDoctors);
            Controls.Add(btnPrescriptions);
            Controls.Add(btnAppointments);
            Controls.Add(btnProfile);
            Controls.Add(label1);
            Name = "PatientDashboard";
            Text = "PatientDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProfile;
        private Button btnAppointments;
        private Button btnPrescriptions;
        private Button btnDoctors;
    }
}