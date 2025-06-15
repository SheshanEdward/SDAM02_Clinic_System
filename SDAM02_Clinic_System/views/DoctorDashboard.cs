using SDAM02_Clinic_System.models;
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

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            DoctorAppointments doctorAppointments = new DoctorAppointments();
            doctorAppointments.Show();
            this.Hide();
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            DoctorPrescriptions prescriptionsForm = new DoctorPrescriptions();
            prescriptionsForm.Show();
            this.Hide();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            DoctorAssignedPatients assignedPatients = new DoctorAssignedPatients();
            assignedPatients.Show();
            this.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            DoctorSchedule doctorSchedule = new DoctorSchedule();
            doctorSchedule.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            DoctorProfile doctorProfile = new DoctorProfile();
            doctorProfile.Show();
            this.Hide();
        }
    }
}
