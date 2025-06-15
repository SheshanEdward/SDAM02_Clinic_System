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
            btnLoad = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatientappointments).BeginInit();
            SuspendLayout();
            // 
            // dgvPatientappointments
            // 
            dgvPatientappointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatientappointments.Location = new Point(44, 12);
            dgvPatientappointments.Name = "dgvPatientappointments";
            dgvPatientappointments.RowHeadersWidth = 51;
            dgvPatientappointments.Size = new Size(776, 364);
            dgvPatientappointments.TabIndex = 0;
            dgvPatientappointments.CellContentClick += dgvPatientappointments_CellContentClick;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(332, 402);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(212, 36);
            btnSchedule.TabIndex = 1;
            btnSchedule.Text = "Schedule New Appointment";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click_1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(775, 409);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(96, 29);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load ";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // PatientAllAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(btnBack);
            Controls.Add(btnLoad);
            Controls.Add(btnSchedule);
            Controls.Add(dgvPatientappointments);
            Name = "PatientAllAppointments";
            Text = "PatientAllAppointments";
            Load += PatientAllAppointments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatientappointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPatientappointments;
        private Button btnSchedule;
        private Button btnLoad;
        private Button btnBack;
    }
}