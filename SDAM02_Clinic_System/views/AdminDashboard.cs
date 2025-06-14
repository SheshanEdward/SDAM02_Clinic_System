﻿using SDAM02_Clinic_System.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM02_Clinic_System.views
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            AdminViewDoctors viewDoctors = new AdminViewDoctors();
            viewDoctors.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            AdminProfileView viewProfile = new AdminProfileView();
            viewProfile.Show();
            this.Hide();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            AdminViewPatients viewPatients = new AdminViewPatients();
            viewPatients.Show();
            this.Hide();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AdminAllAppointments adminAllAppointments = new AdminAllAppointments();
            adminAllAppointments.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.LogOut();
            this.Close();
        }
    }
}
