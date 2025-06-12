namespace SDAM02_Clinic_System.views
{
    partial class PatientPrescription
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
            label2 = new Label();
            label3 = new Label();
            lstDrugsanddosage = new ListView();
            txtDoctor = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(328, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 0;
            label1.Text = "Prescription";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 147);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Drugs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 93);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Doctor";
            // 
            // lstDrugsanddosage
            // 
            lstDrugsanddosage.Location = new Point(225, 147);
            lstDrugsanddosage.Name = "lstDrugsanddosage";
            lstDrugsanddosage.Size = new Size(425, 107);
            lstDrugsanddosage.TabIndex = 3;
            lstDrugsanddosage.UseCompatibleStateImageBehavior = false;
            // 
            // txtDoctor
            // 
            txtDoctor.Location = new Point(225, 86);
            txtDoctor.Name = "txtDoctor";
            txtDoctor.Size = new Size(307, 27);
            txtDoctor.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(328, 307);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 45);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // PatientPrescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(txtDoctor);
            Controls.Add(lstDrugsanddosage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PatientPrescription";
            Text = "PatientPrescription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListView lstDrugsanddosage;
        private TextBox txtDoctor;
        private Button btnBack;
    }
}