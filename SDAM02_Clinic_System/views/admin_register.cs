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
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AdminManager manager = new AdminManager();

            manager.RegisterAdmin(
                txtFirstname.Text,
                txtLastname.Text,
                dtpDoB.Value.Date,
                txtEmail.Text,
                txtMobile.Text,
                txtNICnumber.Text,
                txtAddress.Text,
                txtPassword.Text
            );
        }
    }
}
