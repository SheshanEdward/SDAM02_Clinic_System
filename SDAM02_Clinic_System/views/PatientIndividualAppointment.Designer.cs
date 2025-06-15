namespace SDAM02_Clinic_System.views
{
    partial class PatientIndividualAppointment
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
            label4 = new Label();
            lblAppid = new Label();
            txtDocid = new TextBox();
            txtDate = new TextBox();
            txtTime = new TextBox();
            label5 = new Label();
            btnBack = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 118);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Appointment ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 191);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Doctor ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 251);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 309);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Time";
            // 
            // lblAppid
            // 
            lblAppid.AutoSize = true;
            lblAppid.Location = new Point(371, 118);
            lblAppid.Name = "lblAppid";
            lblAppid.Size = new Size(50, 20);
            lblAppid.TabIndex = 4;
            lblAppid.Text = "label5";
            // 
            // txtDocid
            // 
            txtDocid.Location = new Point(371, 184);
            txtDocid.Name = "txtDocid";
            txtDocid.Size = new Size(125, 27);
            txtDocid.TabIndex = 5;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(371, 244);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(125, 27);
            txtDate.TabIndex = 6;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(371, 306);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(125, 27);
            txtTime.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 32);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 8;
            label5.Text = "Appointment Details";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(33, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(348, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(675, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // PatientIndividualAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            Controls.Add(label5);
            Controls.Add(txtTime);
            Controls.Add(txtDate);
            Controls.Add(txtDocid);
            Controls.Add(lblAppid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PatientIndividualAppointment";
            Text = "PatientIndividualAppointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblAppid;
        private TextBox txtDocid;
        private TextBox txtDate;
        private TextBox txtTime;
        private Label label5;
        private Button btnBack;
        private Button btnSave;
        private Button btnDelete;
    }
}