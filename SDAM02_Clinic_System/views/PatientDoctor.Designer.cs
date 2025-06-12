namespace SDAM02_Clinic_System.views
{
    partial class PatientDoctor
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
            btnViewalldoctors = new Button();
            dgvViewalldoctors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvViewalldoctors).BeginInit();
            SuspendLayout();
            // 
            // btnViewalldoctors
            // 
            btnViewalldoctors.Location = new Point(292, 12);
            btnViewalldoctors.Name = "btnViewalldoctors";
            btnViewalldoctors.Size = new Size(190, 38);
            btnViewalldoctors.TabIndex = 0;
            btnViewalldoctors.Text = "View All Doctors ";
            btnViewalldoctors.UseVisualStyleBackColor = true;
            // 
            // dgvViewalldoctors
            // 
            dgvViewalldoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewalldoctors.Location = new Point(34, 69);
            dgvViewalldoctors.Name = "dgvViewalldoctors";
            dgvViewalldoctors.RowHeadersWidth = 51;
            dgvViewalldoctors.Size = new Size(722, 322);
            dgvViewalldoctors.TabIndex = 1;
            // 
            // PatientDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvViewalldoctors);
            Controls.Add(btnViewalldoctors);
            Name = "PatientDoctor";
            Text = "PatientDoctor";
            ((System.ComponentModel.ISupportInitialize)dgvViewalldoctors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewalldoctors;
        private DataGridView dgvViewalldoctors;
    }
}