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
            btnSchedule = new Button();
            btnEdit = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(218, 149);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(113, 54);
            btnSchedule.TabIndex = 0;
            btnSchedule.Text = "Schedule Appointment";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(447, 148);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(109, 55);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Appointment";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(356, 381);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PatientAppointmentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnEdit);
            Controls.Add(btnSchedule);
            Name = "PatientAppointmentDashboard";
            Text = "PatientAppointmentDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSchedule;
        private Button btnEdit;
        private Button btnBack;
    }
}