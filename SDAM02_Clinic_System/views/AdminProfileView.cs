using SDAM02_Clinic_System.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM02_Clinic_System.views
{
    public partial class AdminProfileView : Form
    {
        public AdminProfileView()
        {
            InitializeComponent();
            LoadAdminProfile();
        }

        private void LoadAdminProfile()
        {
            Admin admin = SessionManager.GetLoggedInAdminProfile();

            if (admin != null)
            {
                lblFirstname.Text = admin.Firstname;
                lblLastname.Text = admin.Lastname;
                lblDob.Text = admin.dob.ToShortDateString();
                lblGender.Text = admin.Gender;
                lblEmail.Text = admin.Email;
                lblMobile.Text = admin.Mobile;
                lblAddress.Text = admin.Address;
                lblPostal.Text = admin.Postalcode;
            }
            else
            {
                MessageBox.Show("Could not load profile.");
            }
        }

    }


}
