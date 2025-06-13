namespace SDAM02_Clinic_System.views
{
    partial class PatientAllAppointments
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
            dgvPatientappointments = new DataGridView();
            btnSchedule = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatientappointments).BeginInit();
            SuspendLayout();
            // 
            // dgvPatientappointments
            // 
            dgvPatientappointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatientappointments.Location = new Point(22, 12);
            dgvPatientappointments.Name = "dgvPatientappointments";
            dgvPatientappointments.RowHeadersWidth = 51;
            dgvPatientappointments.Size = new Size(1035, 364);
            dgvPatientappointments.TabIndex = 0;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(480, 388);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(121, 50);
            btnSchedule.TabIndex = 1;
            btnSchedule.Text = "Schedule New Appointment";
            btnSchedule.UseVisualStyleBackColor = true;
            // 
            // PatientAllAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 450);
            Controls.Add(btnSchedule);
            Controls.Add(dgvPatientappointments);
            Name = "PatientAllAppointments";
            Text = "PatientAllAppointments";
            ((System.ComponentModel.ISupportInitialize)dgvPatientappointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPatientappointments;
        private Button btnSchedule;
    }
}