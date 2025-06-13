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
    public partial class AdminRegisterDoctor : Form
    {
        public AdminRegisterDoctor()
        {
            InitializeComponent();

            cmbSpecialization.Items.Add("General Physician");
            cmbSpecialization.Items.Add("Cardiologist");
            cmbSpecialization.Items.Add("Dermatologist");
            cmbSpecialization.Items.Add("Neurologist");
            cmbSpecialization.Items.Add("Pediatrician");
            cmbSpecialization.Items.Add("Physiatrist");
            cmbSpecialization.Items.Add("Psychiatrist");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Doctor newDoctor = new Doctor(
                txtNICnumber.Text,
                txtFirstname.Text,
                txtLastname.Text,
                dtpDoB.Value.Date,
                txtEmail.Text,
                txtMobile.Text,
                txtAddress.Text,
                txtPassword.Text,
                txtSLMCnumber.Text,
                cmbSpecialization.SelectedItem.ToString()
             );

            AdminManager manager = new AdminManager();
            manager.RegisterDoctor(newDoctor);
        }
    }
}
