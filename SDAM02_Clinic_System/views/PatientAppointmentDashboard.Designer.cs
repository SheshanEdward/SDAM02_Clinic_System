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
            this.btnSchedul = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnSchedul
            // 
            this.btnSchedul.Location = new Point(89, 168);
            this.btnSchedul.Name = "btnSchedul";
            this.btnSchedul.Size = new Size(115, 63);
            this.btnSchedul.TabIndex = 1;
            this.btnSchedul.Text = "Schedule appointment";
            this.btnSchedul.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(325, 172);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(122, 55);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Appointment ";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(542, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 54);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Appointment";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // PatientAppointmentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(this.btnSchedul);
            Name = "PatientAppointmentDashboard";
            Text = "PatientAppointmentDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnScheduleappointment;
        private Button btnEdit;
        private Button btnDelete;
    }
}