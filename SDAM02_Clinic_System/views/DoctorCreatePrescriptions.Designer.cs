namespace SDAM02_Clinic_System.views
{
    partial class DoctorCreatePrescriptions
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
            btnSubmit = new Button();
            btnBack = new Button();
            label2 = new Label();
            lblPatientid = new Label();
            rtbMedication = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(333, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Prescription";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(110, 367);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 37);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit ";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(595, 375);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back ";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 58);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 11;
            label2.Text = "Patient ID";
            // 
            // lblPatientid
            // 
            lblPatientid.AutoSize = true;
            lblPatientid.Location = new Point(396, 58);
            lblPatientid.Name = "lblPatientid";
            lblPatientid.Size = new Size(50, 20);
            lblPatientid.TabIndex = 12;
            lblPatientid.Text = "label3";
            // 
            // rtbMedication
            // 
            rtbMedication.Location = new Point(199, 103);
            rtbMedication.Name = "rtbMedication";
            rtbMedication.Size = new Size(367, 189);
            rtbMedication.TabIndex = 13;
            rtbMedication.Text = "";
            // 
            // DoctorCreatePrescriptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbMedication);
            Controls.Add(lblPatientid);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Name = "DoctorCreatePrescriptions";
            Text = "DoctorCreatePrescriptions";
            Load += DoctorCreatePrescriptions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSubmit;
        private Button btnBack;
        private Label label2;
        private Label lblPatientid;
        private RichTextBox rtbMedication;
    }
}