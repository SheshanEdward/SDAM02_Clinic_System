
namespace SDAM02_Clinic_System.views
{
    partial class PatientEditAppointment
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
            cmbDoctor = new ComboBox();
            cmbService = new ComboBox();
            dtpDatetime = new DateTimePicker();
            btnSaveeditedappointment = new Button();
            btnDeleteappointment = new Button();
            btnHome = new Button();
            dgvViewallappointments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvViewallappointments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "Edit Appointment ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 220);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Doctor ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 283);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Service ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 344);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Date ";
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(264, 217);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(306, 28);
            cmbDoctor.TabIndex = 4;
            // 
            // cmbService
            // 
            cmbService.FormattingEnabled = true;
            cmbService.Location = new Point(264, 283);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(301, 28);
            cmbService.TabIndex = 5;
            // 
            // dtpDatetime
            // 
            dtpDatetime.Location = new Point(260, 337);
            dtpDatetime.Name = "dtpDatetime";
            dtpDatetime.Size = new Size(305, 27);
            dtpDatetime.TabIndex = 6;
            // 
            // btnSaveeditedappointment
            // 
            btnSaveeditedappointment.Location = new Point(27, 403);
            btnSaveeditedappointment.Name = "btnSaveeditedappointment";
            btnSaveeditedappointment.Size = new Size(215, 35);
            btnSaveeditedappointment.TabIndex = 7;
            btnSaveeditedappointment.Text = "Save Edited Appointment ";
            btnSaveeditedappointment.UseVisualStyleBackColor = true;
            // 
            // btnDeleteappointment
            // 
            btnDeleteappointment.Location = new Point(312, 403);
            btnDeleteappointment.Name = "btnDeleteappointment";
            btnDeleteappointment.Size = new Size(161, 35);
            btnDeleteappointment.TabIndex = 8;
            btnDeleteappointment.Text = "Delete Appointment ";
            btnDeleteappointment.UseVisualStyleBackColor = true;
            btnDeleteappointment.Click += btnDeleteappointment_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(589, 403);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 35);
            btnHome.TabIndex = 9;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // dgvViewallappointments
            // 
            dgvViewallappointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewallappointments.Location = new Point(55, 52);
            dgvViewallappointments.Name = "dgvViewallappointments";
            dgvViewallappointments.RowHeadersWidth = 51;
            dgvViewallappointments.Size = new Size(661, 140);
            dgvViewallappointments.TabIndex = 10;
            dgvViewallappointments.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PatientEditAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvViewallappointments);
            Controls.Add(btnHome);
            Controls.Add(btnDeleteappointment);
            Controls.Add(btnSaveeditedappointment);
            Controls.Add(dtpDatetime);
            Controls.Add(cmbService);
            Controls.Add(cmbDoctor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PatientEditAppointment";
            Text = "PatientEditAppointment";
            Load += PatientEditAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewallappointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbDoctor;
        private ComboBox cmbService;
        private DateTimePicker dtpDatetime;
        private Button btnSaveeditedappointment;
        private Button btnDeleteappointment;
        private Button btnHome;
        private DataGridView dgvViewallappointments;
    }
}