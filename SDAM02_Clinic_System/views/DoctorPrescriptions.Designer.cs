namespace SDAM02_Clinic_System.views
{
    partial class DoctorPrescriptions
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btnEditprescription = new Button();
            btnDeletePrescription = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(340, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Prescriptions ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(671, 203);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(63, 339);
            button1.Name = "button1";
            button1.Size = new Size(199, 41);
            button1.TabIndex = 2;
            button1.Text = "Create new prescription";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEditprescription
            // 
            btnEditprescription.Location = new Point(560, 340);
            btnEditprescription.Name = "btnEditprescription";
            btnEditprescription.Size = new Size(174, 40);
            btnEditprescription.TabIndex = 3;
            btnEditprescription.Text = "Edit prescription ";
            btnEditprescription.UseVisualStyleBackColor = true;
            // 
            // btnDeletePrescription
            // 
            btnDeletePrescription.Location = new Point(327, 344);
            btnDeletePrescription.Name = "btnDeletePrescription";
            btnDeletePrescription.Size = new Size(168, 34);
            btnDeletePrescription.TabIndex = 4;
            btnDeletePrescription.Text = "Delete Prescription ";
            btnDeletePrescription.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(19, 414);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // DoctorPrescriptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnDeletePrescription);
            Controls.Add(btnEditprescription);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "DoctorPrescriptions";
            Text = "DoctorPrescriptions";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnEditprescription;
        private Button btnDeletePrescription;
        private Button btnBack;
    }
}