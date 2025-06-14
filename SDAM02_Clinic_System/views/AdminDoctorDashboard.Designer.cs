namespace SDAM02_Clinic_System.views
{
    partial class AdminDoctorDashboard
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
            btnCreationrequest = new Button();
            btnEditrequest = new Button();
            btnRegister = new Button();
            btnView = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnCreationrequest
            // 
            btnCreationrequest.Location = new Point(49, 199);
            btnCreationrequest.Name = "btnCreationrequest";
            btnCreationrequest.Size = new Size(122, 54);
            btnCreationrequest.TabIndex = 0;
            btnCreationrequest.Text = "Creation Requests";
            btnCreationrequest.UseVisualStyleBackColor = true;
            btnCreationrequest.Click += btnCreationrequest_Click;
            // 
            // btnEditrequest
            // 
            btnEditrequest.Location = new Point(244, 199);
            btnEditrequest.Name = "btnEditrequest";
            btnEditrequest.Size = new Size(112, 54);
            btnEditrequest.TabIndex = 1;
            btnEditrequest.Text = "Edit Requests";
            btnEditrequest.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(449, 199);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(107, 54);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(632, 199);
            btnView.Name = "btnView";
            btnView.Size = new Size(108, 54);
            btnView.TabIndex = 3;
            btnView.Text = "View Doctors";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(354, 386);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AdminDoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnView);
            Controls.Add(btnRegister);
            Controls.Add(btnEditrequest);
            Controls.Add(btnCreationrequest);
            Name = "AdminDoctorDashboard";
            Text = "AdminDoctorDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreationrequest;
        private Button btnEditrequest;
        private Button btnRegister;
        private Button btnView;
        private Button btnBack;
    }
}