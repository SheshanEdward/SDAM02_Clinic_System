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
    public partial class DoctorRegister : Form
    {
        public DoctorRegister()
        {
            InitializeComponent();

            //Values for the specialization
            cmbSpecialization.Items.Add("General Physician");
            cmbSpecialization.Items.Add("Cardiologist");
            cmbSpecialization.Items.Add("Dermatologist");
            cmbSpecialization.Items.Add("Neurologist");
            cmbSpecialization.Items.Add("Pediatrician");
            cmbSpecialization.Items.Add("Physiatrist");
            cmbSpecialization.Items.Add("Psychiatrist");

        }

        private void DoctorRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
