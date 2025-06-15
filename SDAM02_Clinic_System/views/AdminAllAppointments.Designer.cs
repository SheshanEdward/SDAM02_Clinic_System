namespace SDAM02_Clinic_System.views
{
    partial class AdminAllAppointments
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
            dgvAllappointments = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAllappointments).BeginInit();
            SuspendLayout();
            // 
            // dgvAllappointments
            // 
            dgvAllappointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllappointments.Location = new Point(17, 17);
            dgvAllappointments.Name = "dgvAllappointments";
            dgvAllappointments.RowHeadersWidth = 51;
            dgvAllappointments.Size = new Size(1153, 380);
            dgvAllappointments.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(17, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AdminAllAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 450);
            Controls.Add(btnBack);
            Controls.Add(dgvAllappointments);
            Name = "AdminAllAppointments";
            Text = "AdminAllAppointments";
            ((System.ComponentModel.ISupportInitialize)dgvAllappointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAllappointments;
        private Button btnBack;
    }
}