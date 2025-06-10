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
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string insertQuery = @"INSERT INTO admin_information 
                (firstname, lastname, dob, email, mobile, nic, address, username, password)
                VALUES (@firstname, @lastname, @dob, @email, @mobile, @nic, @address, @username, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                        cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
                        cmd.Parameters.AddWithValue("@dob", dtpDoB.Value.Date);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);
                        cmd.Parameters.AddWithValue("@nic", txtNICnumber.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text); // Have to asterisk pwd in real time

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Admin registered successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
