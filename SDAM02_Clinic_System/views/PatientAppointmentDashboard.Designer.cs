namespace SDAM02_Clinic_System.views
{
    partial class PatientAppointmentDashboard
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
            button1 = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(84, 153);
            button1.Name = "button1";
            button1.Size = new Size(125, 57);
            button1.TabIndex = 0;
            button1.Text = "Schedule Appointment ";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(332, 161);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 49);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Appointemnt ";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(562, 153);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 56);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete  Appointment ";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // PatientAppointmentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(button1);
            Name = "PatientAppointmentDashboard";
            Text = "PatientAppointmentDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnEdit;
        private Button btnDelete;
    }
}