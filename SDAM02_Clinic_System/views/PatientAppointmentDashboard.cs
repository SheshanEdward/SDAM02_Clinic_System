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
    public partial class PatientAppointmentDashboard : Form
    {
        private string patientId;

        public PatientAppointmentDashboard(string patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientEditAppointment(patientId).Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientScheduleAppointment(patientId).Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PatientDashboard back = new PatientDashboard();
            back.Show();
            this.Hide();
        }
    }
}
