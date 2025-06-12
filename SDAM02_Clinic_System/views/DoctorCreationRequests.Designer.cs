namespace SDAM02_Clinic_System.views
{
    partial class DoctorCreationRequests
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
            dgvCreationrequests = new DataGridView();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCreationrequests).BeginInit();
            SuspendLayout();
            // 
            // dgvCreationrequests
            // 
            dgvCreationrequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreationrequests.Location = new Point(12, 12);
            dgvCreationrequests.Name = "dgvCreationrequests";
            dgvCreationrequests.RowHeadersWidth = 51;
            dgvCreationrequests.Size = new Size(776, 349);
            dgvCreationrequests.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(347, 389);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // DoctorCreationRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(dgvCreationrequests);
            Name = "DoctorCreationRequests";
            Text = "DoctorCreationRequests";
            Load += DoctorCreationRequests_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCreationrequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCreationrequests;
        private Button btnRefresh;
    }
}