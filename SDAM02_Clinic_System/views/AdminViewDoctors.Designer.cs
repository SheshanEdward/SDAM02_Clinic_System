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
            button1 = new Button();
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
            // button1
            // 
            button1.Location = new Point(527, 451);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // AdminViewDoctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 492);
            Controls.Add(button1);
            Controls.Add(dgvViewdoctors);
            Name = "AdminViewDoctors";
            Text = "AdminViewDoctors";
            Load += AdminViewDoctors_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewdoctors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvViewdoctors;
        private Button button1;
    }
}