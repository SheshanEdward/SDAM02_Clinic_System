namespace SDAM02_Clinic_System.views
{
    partial class book_appointment
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
            label6 = new Label();
            label4 = new Label();
            patientIDTxt = new TextBox();
            doctorCmb = new ComboBox();
            serviceCmb = new ComboBox();
            dateTime = new DateTimePicker();
            Bookbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 83);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Patient ID ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 141);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Doctor ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 208);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Service ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(301, 9);
            label6.Name = "label6";
            label6.Size = new Size(184, 28);
            label6.TabIndex = 5;
            label6.Text = "Book Appointment ";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 263);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 6;
            label4.Text = "Date & Time ";
            // 
            // patientIDTxt
            // 
            patientIDTxt.Location = new Point(145, 83);
            patientIDTxt.Name = "patientIDTxt";
            patientIDTxt.Size = new Size(266, 27);
            patientIDTxt.TabIndex = 7;
            // 
            // doctorCmb
            // 
            doctorCmb.FormattingEnabled = true;
            doctorCmb.Location = new Point(146, 141);
            doctorCmb.Name = "doctorCmb";
            doctorCmb.Size = new Size(265, 28);
            doctorCmb.TabIndex = 8;
            // 
            // serviceCmb
            // 
            serviceCmb.FormattingEnabled = true;
            serviceCmb.Location = new Point(150, 203);
            serviceCmb.Name = "serviceCmb";
            serviceCmb.Size = new Size(261, 28);
            serviceCmb.TabIndex = 9;
            // 
            // dateTime
            // 
            dateTime.Location = new Point(154, 259);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(250, 27);
            dateTime.TabIndex = 10;
            // 
            // Bookbtn
            // 
            Bookbtn.BackColor = SystemColors.GradientActiveCaption;
            Bookbtn.Font = new Font("Segoe UI", 11F);
            Bookbtn.Location = new Point(352, 353);
            Bookbtn.Name = "Bookbtn";
            Bookbtn.Size = new Size(99, 35);
            Bookbtn.TabIndex = 11;
            Bookbtn.Text = "Book ";
            Bookbtn.UseVisualStyleBackColor = false;
            // 
            // book_appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Bookbtn);
            Controls.Add(dateTime);
            Controls.Add(serviceCmb);
            Controls.Add(doctorCmb);
            Controls.Add(patientIDTxt);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "book_appointment";
            Text = "book_appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label4;
        private TextBox patientIDTxt;
        private ComboBox doctorCmb;
        private ComboBox serviceCmb;
        private DateTimePicker dateTime;
        private Button Bookbtn;
    }
}