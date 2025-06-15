namespace SDAM02_Clinic_System.views
{
    partial class AdminDashboard
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
            btnPatients = new Button();
            btnAppointments = new Button();
            btnDoctors = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 22);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(43, 124);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(94, 29);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnPatients
            // 
            btnPatients.Location = new Point(344, 124);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(94, 29);
            btnPatients.TabIndex = 2;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.Location = new Point(344, 260);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(114, 29);
            btnAppointments.TabIndex = 3;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.Location = new Point(663, 124);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(94, 29);
            btnDoctors.TabIndex = 5;
            btnDoctors.Text = "Doctors";
            btnDoctors.UseVisualStyleBackColor = true;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(29, 395);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnDoctors);
            Controls.Add(btnAppointments);
            Controls.Add(btnPatients);
            Controls.Add(btnProfile);
            Controls.Add(label1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProfile;
        private Button btnPatients;
        private Button btnAppointments;
        private Button btnDoctors;
        private Button btnLogout;
    }
}