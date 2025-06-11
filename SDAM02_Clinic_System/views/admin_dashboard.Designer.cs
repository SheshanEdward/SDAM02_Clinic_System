namespace SDAM02_Clinic_System.views
{
    partial class admin_dashboard
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
            adminProfilebtn = new Button();
            label1 = new Label();
            adminAppointmentsbtn = new Button();
            doctorsbtn = new Button();
            adminPatientsbtn = new Button();
            SuspendLayout();
            // 
            // adminProfilebtn
            // 
            adminProfilebtn.BackColor = SystemColors.GradientActiveCaption;
            adminProfilebtn.Location = new Point(202, 115);
            adminProfilebtn.Name = "adminProfilebtn";
            adminProfilebtn.Size = new Size(138, 76);
            adminProfilebtn.TabIndex = 0;
            adminProfilebtn.Text = "Profile ";
            adminProfilebtn.UseVisualStyleBackColor = false;
            adminProfilebtn.Click += adminProfilebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(277, 23);
            label1.Name = "label1";
            label1.Size = new Size(189, 35);
            label1.TabIndex = 1;
            label1.Text = "Choose Option ";
            // 
            // adminAppointmentsbtn
            // 
            adminAppointmentsbtn.BackColor = SystemColors.GradientActiveCaption;
            adminAppointmentsbtn.Location = new Point(395, 115);
            adminAppointmentsbtn.Name = "adminAppointmentsbtn";
            adminAppointmentsbtn.Size = new Size(150, 76);
            adminAppointmentsbtn.TabIndex = 2;
            adminAppointmentsbtn.Text = "Appointments ";
            adminAppointmentsbtn.UseVisualStyleBackColor = false;
            // 
            // doctorsbtn
            // 
            doctorsbtn.BackColor = SystemColors.GradientActiveCaption;
            doctorsbtn.Location = new Point(202, 228);
            doctorsbtn.Name = "doctorsbtn";
            doctorsbtn.Size = new Size(138, 78);
            doctorsbtn.TabIndex = 3;
            doctorsbtn.Text = "Doctors ";
            doctorsbtn.UseVisualStyleBackColor = false;
            doctorsbtn.Click += doctorsbtn_Click;
            // 
            // adminPatientsbtn
            // 
            adminPatientsbtn.BackColor = SystemColors.GradientActiveCaption;
            adminPatientsbtn.Location = new Point(395, 228);
            adminPatientsbtn.Name = "adminPatientsbtn";
            adminPatientsbtn.Size = new Size(150, 78);
            adminPatientsbtn.TabIndex = 4;
            adminPatientsbtn.Text = "Patients";
            adminPatientsbtn.UseVisualStyleBackColor = false;
            // 
            // admin_dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(adminPatientsbtn);
            Controls.Add(doctorsbtn);
            Controls.Add(adminAppointmentsbtn);
            Controls.Add(label1);
            Controls.Add(adminProfilebtn);
            Name = "admin_dashboard";
            Text = "admin_dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adminProfilebtn;
        private Label label1;
        private Button adminAppointmentsbtn;
        private Button doctorsbtn;
        private Button adminPatientsbtn;
    }
}