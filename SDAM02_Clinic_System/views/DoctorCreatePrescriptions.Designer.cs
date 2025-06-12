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
            label2 = new Label();
            label3 = new Label();
            txtDrug = new TextBox();
            txtDosage = new TextBox();
            lstDrugs = new ListBox();
            btnAdddrug = new Button();
            btnSubmit = new Button();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 138);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Dosage ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 75);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Drug";
            // 
            // txtDrug
            // 
            txtDrug.Location = new Point(182, 79);
            txtDrug.Name = "txtDrug";
            txtDrug.Size = new Size(295, 27);
            txtDrug.TabIndex = 3;
            // 
            // txtDosage
            // 
            txtDosage.Location = new Point(183, 131);
            txtDosage.Name = "txtDosage";
            txtDosage.Size = new Size(294, 27);
            txtDosage.TabIndex = 4;
            // 
            // lstDrugs
            // 
            lstDrugs.FormattingEnabled = true;
            lstDrugs.Location = new Point(110, 202);
            lstDrugs.Name = "lstDrugs";
            lstDrugs.Size = new Size(579, 104);
            lstDrugs.TabIndex = 5;
            // 
            // btnAdddrug
            // 
            btnAdddrug.Location = new Point(542, 83);
            btnAdddrug.Name = "btnAdddrug";
            btnAdddrug.Size = new Size(123, 75);
            btnAdddrug.TabIndex = 6;
            btnAdddrug.Text = "Add Drug";
            btnAdddrug.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(110, 339);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 37);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit ";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // DoctorCreatePrescriptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(btnAdddrug);
            Controls.Add(lstDrugs);
            Controls.Add(txtDosage);
            Controls.Add(txtDrug);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DoctorCreatePrescriptions";
            Text = "DoctorCreatePrescriptions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDrug;
        private TextBox txtDosage;
        private ListBox lstDrugs;
        private Button btnAdddrug;
        private Button btnSubmit;
    }
}