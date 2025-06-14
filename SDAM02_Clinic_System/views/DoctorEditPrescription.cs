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
    public partial class DoctorEditPrescription : Form
    {
        public DoctorEditPrescription(string doctorId, string? prescriptionId)
        {
            InitializeComponent();
        }

        private void lstDrugs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
