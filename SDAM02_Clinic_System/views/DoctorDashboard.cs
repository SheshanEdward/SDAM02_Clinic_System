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
    public partial class DoctorDashboard : Form
    {

        public DoctorDashboard()
        {
            InitializeComponent();
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            DoctorPrescriptions prescriptionsForm = new DoctorPrescriptions();
            prescriptionsForm.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            DoctorProfile doctorProfile = new DoctorProfile();
            doctorProfile.Show();
            this.Hide();
        }

        private void btnMyappointments_Click(object sender, EventArgs e)
        {
            DoctorsAppointments doctorAppointments = new DoctorsAppointments();
            doctorAppointments.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.LogOut();
            this.Close();
        }
    }
}
