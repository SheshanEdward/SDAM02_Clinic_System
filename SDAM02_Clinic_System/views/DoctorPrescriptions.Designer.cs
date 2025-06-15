namespace SDAM02_Clinic_System.views
{
    partial class DoctorPrescriptions
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
            dgvViewprescriptions = new DataGridView();
            btnCreateprescription = new Button();
            btnBack = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvViewprescriptions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(340, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Prescriptions ";
            // 
            // dgvViewprescriptions
            // 
            dgvViewprescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewprescriptions.Location = new Point(63, 91);
            dgvViewprescriptions.Name = "dgvViewprescriptions";
            dgvViewprescriptions.RowHeadersWidth = 51;
            dgvViewprescriptions.Size = new Size(671, 203);
            dgvViewprescriptions.TabIndex = 1;
            // 
            // btnCreateprescription
            // 
            btnCreateprescription.Location = new Point(63, 339);
            btnCreateprescription.Name = "btnCreateprescription";
            btnCreateprescription.Size = new Size(199, 41);
            btnCreateprescription.TabIndex = 2;
            btnCreateprescription.Text = "Create new prescription";
            btnCreateprescription.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(19, 414);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // DoctorPrescriptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnCreateprescription);
            Controls.Add(dgvViewprescriptions);
            Controls.Add(label1);
            Name = "DoctorPrescriptions";
            Text = "DoctorPrescriptions";
            Load += DoctorPrescriptions_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewprescriptions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvViewprescriptions;
        private Button btnCreateprescription;
        private Button btnBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}