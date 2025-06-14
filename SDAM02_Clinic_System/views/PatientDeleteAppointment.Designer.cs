namespace SDAM02_Clinic_System.views
{
    partial class PatientDeleteAppointment
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
            btnConfirm = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(702, 268);
            dataGridView1.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(643, 334);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(99, 34);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm ";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(40, 395);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PatientDeleteAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnConfirm);
            Controls.Add(dataGridView1);
            Name = "PatientDeleteAppointment";
            Text = "PatientDeleteAppointment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnConfirm;
        private Button btnBack;
    }
}