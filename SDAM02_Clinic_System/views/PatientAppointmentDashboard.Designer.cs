namespace SDAM02_Clinic_System.views
{
    partial class PatientAppointmentDashboard
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
            btnScheduleappointment = new Button();
            btnEditappointment = new Button();
            btnDeleteappointment = new Button();
            SuspendLayout();
            // 
            // btnScheduleappointment
            // 
            btnScheduleappointment.Location = new Point(74, 140);
            btnScheduleappointment.Name = "btnScheduleappointment";
            btnScheduleappointment.Size = new Size(122, 53);
            btnScheduleappointment.TabIndex = 0;
            btnScheduleappointment.Text = "Schedule Appointment ";
            btnScheduleappointment.UseVisualStyleBackColor = true;
            btnScheduleappointment.Click += button1_Click;
            // 
            // btnEditappointment
            // 
            btnEditappointment.Location = new Point(324, 142);
            btnEditappointment.Name = "btnEditappointment";
            btnEditappointment.Size = new Size(119, 53);
            btnEditappointment.TabIndex = 1;
            btnEditappointment.Text = "Edit Appointment ";
            btnEditappointment.UseVisualStyleBackColor = true;
            // 
            // btnDeleteappointment
            // 
            btnDeleteappointment.Location = new Point(557, 143);
            btnDeleteappointment.Name = "btnDeleteappointment";
            btnDeleteappointment.Size = new Size(102, 51);
            btnDeleteappointment.TabIndex = 2;
            btnDeleteappointment.Text = "Delete Appointment ";
            btnDeleteappointment.UseVisualStyleBackColor = true;
            btnDeleteappointment.Click += button3_Click;
            // 
            // PatientAppointmentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteappointment);
            Controls.Add(btnEditappointment);
            Controls.Add(btnScheduleappointment);
            Name = "PatientAppointmentDashboard";
            Text = "PatientAppointmentDashboard";
            Load += PatientAppointmentDashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnScheduleappointment;
        private Button btnEditappointment;
        private Button btnDeleteappointment;
    }
}