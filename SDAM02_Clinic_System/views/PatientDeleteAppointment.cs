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
    public partial class PatientDeleteAppointment : Form
    {
        private string patientId;
        public PatientDeleteAppointment()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PatientAppointmentDashboard back = new PatientAppointmentDashboard(patientId);
            back.Show();
            this.Hide();
        }
    }
}
