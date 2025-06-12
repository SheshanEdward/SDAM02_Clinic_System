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

        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            DoctorPrescriptions prescriptionsForm = new DoctorPrescriptions();
            prescriptionsForm.Show();
        }
    }
}
