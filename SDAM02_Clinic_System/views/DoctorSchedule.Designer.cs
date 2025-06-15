namespace SDAM02_Clinic_System.views
{
    partial class DoctorSchedule
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
            btnBack = new Button();
            label1 = new Label();
            btnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDay = new TextBox();
            txtFrom = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(20, 414);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 29);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Schedule";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(459, 417);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 184);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 112);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 255);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // txtDay
            // 
            txtDay.Location = new Point(247, 105);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(168, 27);
            txtDay.TabIndex = 6;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(247, 184);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(168, 27);
            txtFrom.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(247, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 27);
            textBox3.TabIndex = 8;
            // 
            // DoctorSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 462);
            Controls.Add(textBox3);
            Controls.Add(txtFrom);
            Controls.Add(txtDay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Name = "DoctorSchedule";
            Text = "DoctorSchedule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private Button btnSave;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDay;
        private TextBox txtFrom;
        private TextBox textBox3;
    }
}