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
        private int patientId;

        public PatientDashboard(string patientId)
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientProfileDashboard(patientId).Show();

        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientAppointmentDashboard(patientId).Show();
        }

        private void btnPrescriptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientPrescription(patientId).Show();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientDoctor(patientId).Show();
        }
    }
}
