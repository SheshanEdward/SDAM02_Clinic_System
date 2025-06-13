namespace SDAM02_Clinic_System.views
{
    partial class PatientPrescription
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
            label2 = new Label();
            btnBack = new Button();
            dgvViewPrescription = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvViewPrescription).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(346, 22);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 0;
            label1.Text = "Prescription";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 147);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(346, 355);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 45);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // dgvViewPrescription
            // 
            dgvViewPrescription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewPrescription.Location = new Point(43, 72);
            dgvViewPrescription.Name = "dgvViewPrescription";
            dgvViewPrescription.RowHeadersWidth = 51;
            dgvViewPrescription.Size = new Size(727, 248);
            dgvViewPrescription.TabIndex = 6;
            // 
            // PatientPrescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvViewPrescription);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PatientPrescription";
            Text = "PatientPrescription";
            ((System.ComponentModel.ISupportInitialize)dgvViewPrescription).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBack;
        private DataGridView dgvViewPrescription;
    }
}