namespace SDAM02_Clinic_System.views
{
    partial class q
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
            btnBack = new Button();
            dgvViewalldoctors = new DataGridView();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvViewalldoctors).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(647, 373);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 38);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // dgvViewalldoctors
            // 
            dgvViewalldoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewalldoctors.Location = new Point(35, 28);
            dgvViewalldoctors.Name = "dgvViewalldoctors";
            dgvViewalldoctors.RowHeadersWidth = 51;
            dgvViewalldoctors.Size = new Size(722, 322);
            dgvViewalldoctors.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(40, 373);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 38);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "load ";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // q
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(dgvViewalldoctors);
            Controls.Add(btnBack);
            Name = "q";
            Text = "PatientDoctor";
            Load += PatientDoctor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewalldoctors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private DataGridView dgvViewalldoctors;
        private Button btnLoad;
    }
}