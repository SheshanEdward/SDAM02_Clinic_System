namespace SDAM02_Clinic_System.views
{
    partial class PatientScheduleAppointment
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
            dtpAppointmentdate = new DateTimePicker();
            cmbService = new ComboBox();
            cmbDoctor = new ComboBox();
            btnschedule = new Button();
            btnHome = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 105);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 33);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 1;
            label2.Text = "Schedule an Appointment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 168);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Service";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 227);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Date";
            // 
            // dtpAppointmentdate
            // 
            dtpAppointmentdate.Location = new Point(285, 222);
            dtpAppointmentdate.Name = "dtpAppointmentdate";
            dtpAppointmentdate.Size = new Size(250, 27);
            dtpAppointmentdate.TabIndex = 4;
            // 
            // cmbService
            // 
            cmbService.FormattingEnabled = true;
            cmbService.Location = new Point(285, 165);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(250, 28);
            cmbService.TabIndex = 5;
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(285, 105);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(250, 28);
            cmbDoctor.TabIndex = 6;
            // 
            // btnschedule
            // 
            btnschedule.Location = new Point(203, 326);
            btnschedule.Name = "btnschedule";
            btnschedule.Size = new Size(101, 32);
            btnschedule.TabIndex = 7;
            btnschedule.Text = "Schedule";
            btnschedule.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(468, 326);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 29);
            btnHome.TabIndex = 8;
            btnHome.Text = "Home ";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // PatientScheduleAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHome);
            Controls.Add(btnschedule);
            Controls.Add(cmbDoctor);
            Controls.Add(cmbService);
            Controls.Add(dtpAppointmentdate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PatientScheduleAppointment";
            Text = "PatientScheduleAppointment";
            Load += PatientScheduleAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpAppointmentdate;
        private ComboBox cmbService;
        private ComboBox cmbDoctor;
        private Button btnschedule;
        private Button btnHome;
    }
}