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
    public partial class PatientRegister : Form
    {
        public PatientRegister()
        {
            InitializeComponent();

            cmbBloodtype.Items.Add("A+");
            cmbBloodtype.Items.Add("A-");
            cmbBloodtype.Items.Add("B+");
            cmbBloodtype.Items.Add("B-");
            cmbBloodtype.Items.Add("AB+");
            cmbBloodtype.Items.Add("AB-");
            cmbBloodtype.Items.Add("O+");
            cmbBloodtype.Items.Add("O-");

            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Male");
            //cmbGender.Items.Add("Other");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient(
                txtNICnumber.Text,
                txtFirstname.Text,
                txtLastname.Text,
                dtpDoB.Value.Date,
                txtEmail.Text,
                txtMobile.Text,
                txtAddress.Text,
                txtPassword.Text,
                cmbGender.SelectedItem.ToString(),
                cmbBloodtype.SelectedItem.ToString(),
                double.Parse(txtHeight.Text),
                double.Parse(txtWeight.Text)
            );



            PatientManager manager = new PatientManager();

            manager.RegisterPatient(patient);
        }
    }
}
