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
    public partial class reg_user_select : Form
    {
        public reg_user_select()
        {
            InitializeComponent();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            DoctorRegister register_new_doctor = new DoctorRegister();
            register_new_doctor.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            admin_register register_new_admin = new admin_register();
            register_new_admin.Show();
            this.Hide();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            PatientRegister register_new_patient = new PatientRegister(); 
            register_new_patient.Show(); 
            this.Hide(); 
        }
        
        private void reg_user_select_Load(object sender, EventArgs e)
        {

        }
    }
}
