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
    public partial class PatientDashboard : Form
    {
        private string patientId;

        public PatientDashboard()
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            PatientProfileView profile = new PatientProfileView();
            profile.Show();
            this.Hide();

        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            PatientAllAppointments allAppointments = new PatientAllAppointments();
            allAppointments.Show();
            this.Hide();
        }

        private void btnPrescriptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientPrescription(patientId).Show();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientDoctor().Show();
        }


        internal void show()
        {
            throw new NotImplementedException();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SessionManager.LogOut();
            this.Close();
        }
    }
}
