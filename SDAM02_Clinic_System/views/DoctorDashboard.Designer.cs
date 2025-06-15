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
            btnProfile.Location = new Point(97, 138);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(102, 33);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(578, 138);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(108, 33);
            btnSchedule.TabIndex = 2;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnPrescription
            // 
            btnPrescription.Location = new Point(334, 138);
            btnPrescription.Name = "btnPrescription";
            btnPrescription.Size = new Size(125, 33);
            btnPrescription.TabIndex = 3;
            btnPrescription.Text = "Prescription";
            btnPrescription.UseVisualStyleBackColor = true;
            btnPrescription.Click += btnPrescription_Click;
            // 
            // DoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}