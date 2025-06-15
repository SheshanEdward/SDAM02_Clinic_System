namespace SDAM02_Clinic_System.views
{
    partial class PatientScheduleAppointment
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
            dgvAlldoctors = new DataGridView();
            btnBack = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlldoctors).BeginInit();
            SuspendLayout();
            // 
            // dgvAlldoctors
            // 
            dgvAlldoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlldoctors.Location = new Point(8, 37);
            dgvAlldoctors.Name = "dgvAlldoctors";
            dgvAlldoctors.RowHeadersWidth = 51;
            dgvAlldoctors.Size = new Size(1356, 369);
            dgvAlldoctors.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 412);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(539, 9);
            label1.Name = "label1";
            label1.Size = new Size(350, 20);
            label1.TabIndex = 2;
            label1.Text = "Double click on doctor to schedule an appointment";
            // 
            // PatientScheduleAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 450);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(dgvAlldoctors);
            Name = "PatientScheduleAppointment";
            Text = "PatientScheduleAppointment";
            Load += PatientScheduleAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlldoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlldoctors;
        private Button btnBack;
        private Label label1;
    }
}