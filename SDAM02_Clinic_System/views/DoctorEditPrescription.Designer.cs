namespace SDAM02_Clinic_System.views
{
    partial class DoctorEditPrescription
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
            Drug = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDrug = new TextBox();
            txtDosage = new TextBox();
            cmbPatients = new ComboBox();
            btnAdddrug = new Button();
            lstDrugs = new ListView();
            btnSave = new Button();
            btnHome = new Button();
            SuspendLayout();
            // 
            // Drug
            // 
            Drug.AutoSize = true;
            Drug.Location = new Point(19, 30);
            Drug.Name = "Drug";
            Drug.Size = new Size(42, 20);
            Drug.TabIndex = 0;
            Drug.Text = "Drug";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 84);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Dosage";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 138);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Patient Name ";
            // 
            // txtDrug
            // 
            txtDrug.Location = new Point(140, 27);
            txtDrug.Name = "txtDrug";
            txtDrug.Size = new Size(325, 27);
            txtDrug.TabIndex = 3;
            // 
            // txtDosage
            // 
            txtDosage.Location = new Point(137, 80);
            txtDosage.Name = "txtDosage";
            txtDosage.Size = new Size(326, 27);
            txtDosage.TabIndex = 4;
            // 
            // cmbPatients
            // 
            cmbPatients.FormattingEnabled = true;
            cmbPatients.Location = new Point(137, 134);
            cmbPatients.Name = "cmbPatients";
            cmbPatients.Size = new Size(324, 28);
            cmbPatients.TabIndex = 5;
            // 
            // btnAdddrug
            // 
            btnAdddrug.Location = new Point(600, 39);
            btnAdddrug.Name = "btnAdddrug";
            btnAdddrug.Size = new Size(121, 111);
            btnAdddrug.TabIndex = 6;
            btnAdddrug.Text = "Add Drug";
            btnAdddrug.UseVisualStyleBackColor = true;
            // 
            // lstDrugs
            // 
            lstDrugs.Location = new Point(69, 205);
            lstDrugs.Name = "lstDrugs";
            lstDrugs.Size = new Size(652, 121);
            lstDrugs.TabIndex = 7;
            lstDrugs.UseCompatibleStateImageBehavior = false;
            lstDrugs.SelectedIndexChanged += lstDrugs_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(69, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(627, 359);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 29);
            btnHome.TabIndex = 9;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // DoctorEditPrescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHome);
            Controls.Add(btnSave);
            Controls.Add(lstDrugs);
            Controls.Add(btnAdddrug);
            Controls.Add(cmbPatients);
            Controls.Add(txtDosage);
            Controls.Add(txtDrug);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Drug);
            Name = "DoctorEditPrescription";
            Text = "DoctorEditPrescription";
            Load += DoctorEditPrescription_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Drug;
        private Label label2;
        private Label label3;
        private TextBox txtDrug;
        private TextBox txtDosage;
        private ComboBox cmbPatients;
        private Button btnAdddrug;
        private ListView lstDrugs;
        private Button btnSave;
        private Button btnHome;
    }
}