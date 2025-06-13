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

            // Populate gender and blood type combo boxes only once during form initialization
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            cmbBloodtype.Items.AddRange(new string[]
            {
                "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"
            });

            cmbGender.Items.AddRange(new string[]
            {
                "Female", "Male"
            });
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
        // Optional: handle form load event if needed
        private void PatientRegister_Load(object sender, EventArgs e)
        {
            // If any logic needed on load, add here
        }
    }
}
