namespace SDAM02_Clinic_System.views
{
    partial class AdminViewDoctors
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
            dgvViewdoctors = new DataGridView();
            btnBack = new Button();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvViewdoctors).BeginInit();
            SuspendLayout();
            // 
            // dgvViewdoctors
            // 
            dgvViewdoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewdoctors.Location = new Point(1, 0);
            dgvViewdoctors.Name = "dgvViewdoctors";
            dgvViewdoctors.RowHeadersWidth = 51;
            dgvViewdoctors.Size = new Size(1158, 434);
            dgvViewdoctors.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 451);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(501, 451);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(155, 29);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register a Doctor";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // AdminViewDoctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 492);
            Controls.Add(btnRegister);
            Controls.Add(btnBack);
            Controls.Add(dgvViewdoctors);
            Name = "AdminViewDoctors";
            Text = "AdminViewDoctors";
            Load += AdminViewDoctors_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewdoctors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvViewdoctors;
        private Button btnBack;
        private Button btnRegister;
    }
}