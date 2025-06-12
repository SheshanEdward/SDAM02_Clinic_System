namespace SDAM02_Clinic_System.views
{
    partial class PatientProfileDaashboard
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
            dgvViewAccountDetails = new DataGridView();
            btnEditAccount = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvViewAccountDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvViewAccountDetails
            // 
            dgvViewAccountDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewAccountDetails.Location = new Point(98, 34);
            dgvViewAccountDetails.Name = "dgvViewAccountDetails";
            dgvViewAccountDetails.RowHeadersWidth = 51;
            dgvViewAccountDetails.Size = new Size(581, 283);
            dgvViewAccountDetails.TabIndex = 0;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(98, 331);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(134, 38);
            btnEditAccount.TabIndex = 1;
            btnEditAccount.Text = "Edit Account ";
            btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(578, 331);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 38);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save ";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // PatientProfileDaashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnEditAccount);
            Controls.Add(dgvViewAccountDetails);
            Name = "PatientProfileDaashboard";
            Text = "PatientProfileDaashboard";
            ((System.ComponentModel.ISupportInitialize)dgvViewAccountDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvViewAccountDetails;
        private Button btnEditAccount;
        private Button btnSave;
    }
}