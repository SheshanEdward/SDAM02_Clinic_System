using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDAM02_Clinic_System.models;

namespace SDAM02_Clinic_System.views
{
    public partial class admin_register : Form
    {
        public admin_register()
        {
            InitializeComponent();

            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Male");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Admin newAdmin = new Admin(
                txtNICnumber.Text,
                txtFirstname.Text,
                txtLastname.Text,
                dtpDoB.Value.Date,
                txtEmail.Text,
                txtMobile.Text,
                txtAddress.Text,
                txtPassword.Text,
                cmbGender.SelectedItem.ToString(),
                txtPostalcode.Text);

            AdminManager manager = new AdminManager();

            manager.RegisterAdmin(newAdmin);
        }

        private void dtpDoB_ValueChanged(object sender, EventArgs e)
        {
            //Do not delete this, the form will crash!!!!!
        }

        private void admin_register_Load(object sender, EventArgs e)
        {
            
        }
    }
}
