namespace SDAM02_Clinic_System.views
{
    partial class reg_user_select
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
            btnPatient = new Button();
            btnDoctor = new Button();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(181, 45);
            label1.Name = "label1";
            label1.Size = new Size(422, 46);
            label1.TabIndex = 0;
            label1.Text = "What type of user are you?";
            // 
            // btnPatient
            // 
            btnPatient.Font = new Font("Segoe UI", 15F);
            btnPatient.Location = new Point(89, 148);
            btnPatient.Name = "btnPatient";
            btnPatient.Size = new Size(112, 51);
            btnPatient.TabIndex = 1;
            btnPatient.Text = "Patient";
            btnPatient.UseVisualStyleBackColor = true;
            // 
            // btnDoctor
            // 
            btnDoctor.Font = new Font("Segoe UI", 15F);
            btnDoctor.Location = new Point(344, 148);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(122, 49);
            btnDoctor.TabIndex = 2;
            btnDoctor.Text = "Doctor";
            btnDoctor.UseVisualStyleBackColor = true;
            btnDoctor.Click += btnDoctor_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Font = new Font("Segoe UI", 15F);
            btnAdmin.Location = new Point(610, 151);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(109, 48);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // reg_user_select
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdmin);
            Controls.Add(btnDoctor);
            Controls.Add(btnPatient);
            Controls.Add(label1);
            Name = "reg_user_select";
            Text = "reg_user_select";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPatient;
        private Button btnDoctor;
        private Button btnAdmin;
    }
}