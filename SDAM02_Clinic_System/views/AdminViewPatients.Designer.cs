namespace SDAM02_Clinic_System.views
{
    partial class AdminViewPatients
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
            dgvAllpatients = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAllpatients).BeginInit();
            SuspendLayout();
            // 
            // dgvAllpatients
            // 
            dgvAllpatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllpatients.Location = new Point(12, 12);
            dgvAllpatients.Name = "dgvAllpatients";
            dgvAllpatients.RowHeadersWidth = 51;
            dgvAllpatients.Size = new Size(1198, 366);
            dgvAllpatients.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(34, 403);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AdminViewPatients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 450);
            Controls.Add(btnBack);
            Controls.Add(dgvAllpatients);
            Name = "AdminViewPatients";
            Text = "AdminViewPatients";
            Load += AdminViewPatients_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllpatients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAllpatients;
        private Button btnBack;
    }
}