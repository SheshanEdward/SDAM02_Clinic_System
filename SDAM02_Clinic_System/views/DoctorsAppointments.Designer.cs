namespace SDAM02_Clinic_System.views
{
    partial class DoctorsAppointments
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
            dgvMyappointments = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMyappointments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 25);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 0;
            label1.Text = "Appointment Schedule";
            // 
            // dgvMyappointments
            // 
            dgvMyappointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyappointments.Location = new Point(21, 75);
            dgvMyappointments.Name = "dgvMyappointments";
            dgvMyappointments.RowHeadersWidth = 51;
            dgvMyappointments.Size = new Size(751, 270);
            dgvMyappointments.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(27, 396);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // DoctorsAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(dgvMyappointments);
            Controls.Add(label1);
            Name = "DoctorsAppointments";
            Text = "DoctorsAppointments";
            Load += DoctorsAppointments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMyappointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvMyappointments;
        private Button btnBack;
    }
}