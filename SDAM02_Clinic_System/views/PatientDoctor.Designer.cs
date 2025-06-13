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
            dgvViewalldoctors = new DataGridView();
            btnLoad = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvViewalldoctors).BeginInit();
            SuspendLayout();
            // 
            // dgvViewalldoctors
            // 
            dgvViewalldoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewalldoctors.Location = new Point(72, 30);
            dgvViewalldoctors.Name = "dgvViewalldoctors";
            dgvViewalldoctors.RowHeadersWidth = 51;
            dgvViewalldoctors.Size = new Size(641, 297);
            dgvViewalldoctors.TabIndex = 0;
            dgvViewalldoctors.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(63, 345);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(619, 345);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // PatientDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnLoad);
            Controls.Add(dgvViewalldoctors);
            Name = "PatientDoctor";
            Text = "PatientDoctor";
            Load += PatientDoctor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewalldoctors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvViewalldoctors;
        private Button btnLoad;
        private Button btnBack;
    }
}