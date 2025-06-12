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

            // Populate gender and blood type combo boxes
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
            if (!ValidateForm()) return;

            Patient patient = new Patient(
                txtNICnumber.Text.Trim(),
                txtFirstname.Text.Trim(),
                txtLastname.Text.Trim(),
                dtpDoB.Value.Date,
                txtEmail.Text.Trim(),
                txtMobile.Text.Trim(),
                txtAddress.Text.Trim(),
                txtPassword.Text.Trim(),
                cmbGender.SelectedItem.ToString(),
                cmbBloodtype.SelectedItem.ToString(),
                double.Parse(txtHeight.Text.Trim()),
                double.Parse(txtWeight.Text.Trim())
            );

            PatientManager manager = new PatientManager();
            manager.RegisterPatient(patient);
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text) ||
                string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(txtNICnumber.Text) ||
                cmbGender.SelectedItem == null ||
                cmbBloodtype.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtHeight.Text) ||
                string.IsNullOrWhiteSpace(txtWeight.Text) ||
                string.IsNullOrWhiteSpace(txtMobile.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error");
                return false;
            }

            if (!double.TryParse(txtHeight.Text, out _) || !double.TryParse(txtWeight.Text, out _))
            {
                MessageBox.Show("Height and weight must be valid numbers.", "Validation Error");
                return false;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error");
                return false;
            }

            return true;
        }

        private void PatientRegister_Load(object sender, EventArgs e)
        {
            // Optional if needed during form load
        }
    }
}
