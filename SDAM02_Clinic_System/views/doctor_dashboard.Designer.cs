namespace SDAM02_Clinic_System.views
{
    partial class doctor_dashboard
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
            doctorAccountbtn = new Button();
            doctorAppointmentsbtn = new Button();
            doctorPrescriptionbtn = new Button();
            doctorPatientsbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(280, 34);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 0;
            label1.Text = "Choose option ";
            // 
            // doctorAccountbtn
            // 
            doctorAccountbtn.BackColor = SystemColors.GradientActiveCaption;
            doctorAccountbtn.Location = new Point(196, 127);
            doctorAccountbtn.Name = "doctorAccountbtn";
            doctorAccountbtn.Size = new Size(143, 70);
            doctorAccountbtn.TabIndex = 1;
            doctorAccountbtn.Text = "Account";
            doctorAccountbtn.UseVisualStyleBackColor = false;
            // 
            // doctorAppointmentsbtn
            // 
            doctorAppointmentsbtn.BackColor = SystemColors.GradientActiveCaption;
            doctorAppointmentsbtn.Location = new Point(401, 128);
            doctorAppointmentsbtn.Name = "doctorAppointmentsbtn";
            doctorAppointmentsbtn.Size = new Size(144, 69);
            doctorAppointmentsbtn.TabIndex = 2;
            doctorAppointmentsbtn.Text = "Appointments ";
            doctorAppointmentsbtn.UseVisualStyleBackColor = false;
            // 
            // doctorPrescriptionbtn
            // 
            doctorPrescriptionbtn.BackColor = SystemColors.GradientActiveCaption;
            doctorPrescriptionbtn.Location = new Point(196, 247);
            doctorPrescriptionbtn.Name = "doctorPrescriptionbtn";
            doctorPrescriptionbtn.Size = new Size(143, 71);
            doctorPrescriptionbtn.TabIndex = 3;
            doctorPrescriptionbtn.Text = "Prescription ";
            doctorPrescriptionbtn.UseVisualStyleBackColor = false;
            // 
            // doctorPatientsbtn
            // 
            doctorPatientsbtn.BackColor = SystemColors.GradientActiveCaption;
            doctorPatientsbtn.Location = new Point(402, 247);
            doctorPatientsbtn.Name = "doctorPatientsbtn";
            doctorPatientsbtn.Size = new Size(143, 71);
            doctorPatientsbtn.TabIndex = 4;
            doctorPatientsbtn.Text = "Patients";
            doctorPatientsbtn.UseVisualStyleBackColor = false;
            // 
            // doctor_dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(doctorPatientsbtn);
            Controls.Add(doctorPrescriptionbtn);
            Controls.Add(doctorAppointmentsbtn);
            Controls.Add(doctorAccountbtn);
            Controls.Add(label1);
            Name = "doctor_dashboard";
            Text = "doctor_dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button doctorAccountbtn;
        private Button doctorAppointmentsbtn;
        private Button doctorPrescriptionbtn;
        private Button doctorPatientsbtn;
    }
}