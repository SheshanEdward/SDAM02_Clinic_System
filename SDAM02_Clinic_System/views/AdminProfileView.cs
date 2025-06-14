using MySql.Data.MySqlClient;
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
                lblAdminid.Text = SessionManager.LoggedIn.ToString();
                txtNICnumber.Text = admin.nic;
                txtFirstname.Text = admin.Firstname;
                txtLastname.Text = admin.Lastname;
                txtDoB.Text = admin.dob.ToShortDateString();
                txtGender.Text = admin.Gender;
                txtEmail.Text = admin.Email;
                txtMobile.Text = admin.Mobile;
                txtAddress.Text = admin.Address;
                txtPostalcode.Text = admin.Postalcode;
            }
            else
            {
                MessageBox.Show("Could not load profile.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";
            string query = @"UPDATE admin_profiles 
                     SET firstname = @firstname,
                         lastname = @lastname,
                         dob = @dob,
                         nic = @nic,
                         address = @address,
                         email = @email,
                         mobile = @mobile,
                         gender = @gender,
                         postal_code = @postal_code
                     WHERE admin_id = @admin_id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text.Trim());
                    cmd.Parameters.AddWithValue("@lastname", txtLastname.Text.Trim());
                    cmd.Parameters.AddWithValue("@dob", DateTime.Parse(txtDoB.Text));
                    cmd.Parameters.AddWithValue("@nic", txtNICnumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@mobile", txtMobile.Text.Trim());
                    cmd.Parameters.AddWithValue("@gender", txtGender.Text.Trim());
                    cmd.Parameters.AddWithValue("@postal_code", txtPostalcode.Text.Trim());
                    cmd.Parameters.AddWithValue("@admin_id", SessionManager.LoggedIn.ToString());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Optional: close the form after update

                    }
                    else
                    {
                        MessageBox.Show("Update failed. No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }
    }


}
