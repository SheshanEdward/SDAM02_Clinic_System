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
    public partial class PatientIndividualAppointment : Form
    {
        public PatientIndividualAppointment(string appointmentId, string doctorId, string date, string time)
        {
            InitializeComponent();

            lblAppid.Text = appointmentId;
            txtDocid.Text = doctorId;
            txtDate.Text = date;
            txtTime.Text = time;
        }
    }
}
