namespace SDAM02_Clinic_System.views
{
    partial class PatientAccountDashboard
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
            dataGridView1 = new DataGridView();
            btnDeleteAccount = new Button();
            label1 = new Label();
            txtPassword = new TextBox();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(86, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(603, 194);
            dataGridView1.TabIndex = 0;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(312, 248);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(139, 36);
            btnDeleteAccount.TabIndex = 1;
            btnDeleteAccount.Text = "delete Account ";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(112, 348);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 2;
            label1.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(227, 347);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(285, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(547, 346);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm ";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // PatientAccountDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(btnDeleteAccount);
            Controls.Add(dataGridView1);
            Name = "PatientAccountDashboard";
            Text = "PatientAccountDashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDeleteAccount;
        private Label label1;
        private TextBox txtPassword;
        private Button btnConfirm;
    }
}