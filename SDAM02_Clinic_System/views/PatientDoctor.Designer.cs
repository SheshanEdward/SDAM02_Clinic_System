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
            label1 = new Label();
            dgvViewdoctors = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvViewdoctors).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 16);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // dgvViewdoctors
            // 
            dgvViewdoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewdoctors.Location = new Point(7, 50);
            dgvViewdoctors.Name = "dgvViewdoctors";
            dgvViewdoctors.RowHeadersWidth = 51;
            dgvViewdoctors.Size = new Size(781, 321);
            dgvViewdoctors.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(347, 396);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PatientDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 450);
            Controls.Add(btnBack);
            Controls.Add(dgvViewdoctors);
            Controls.Add(label1);
            Name = "PatientDoctor";
            Text = "PatientDoctor";
            Load += PatientDoctor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewdoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvViewdoctors;
        private Button btnBack;
    }
}