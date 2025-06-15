using MySql.Data.MySqlClient;
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
    public partial class DoctorProfile : Form
    {
        private string doctorId;
        public DoctorProfile()
        {
            InitializeComponent();
            doctorId = SessionManager.LoggedIn.ToString();
            LoadDoctorData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DoctorDashboard doctorDashboard = new DoctorDashboard();
            doctorDashboard.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //Accidental, do not delete.
        }


        private void LoadDoctorData()
        {
            string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM doctor_profiles WHERE doctor_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", doctorId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblDoctorid.Text = reader["doctor_id"].ToString();
                                txtFirstname.Text = reader["firstname"].ToString();
                                txtLastname.Text = reader["lastname"].ToString();
                                txtDoB.Text = reader["dob"].ToString();
                                txtNICnumber.Text = reader["nic"].ToString();
                                txtSLMCnumber.Text = reader["SLMCno"].ToString();
                                txtSpecialization.Text = reader["specialization"].ToString();
                                txtMobile.Text = reader["mobile"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtAddress.Text = reader["address"].ToString();
                                txtPassword.Text = reader["password"].ToString();
                                txtDay.Text = reader["available_days"].ToString();
                                txtFrom.Text = reader["start_time"].ToString();
                                txtTo.Text = reader["end_time"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading doctor data: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string updateQuery = @"
                        UPDATE doctor_profiles SET 
                            firstname = @firstname,
                            lastname = @lastname,
                            dob = @dob,
                            nic = @nic,
                            specialization = @specialization,
                            SLMCno = @SLMCnumber,
                            mobile = @mobile,
                            email = @email,
                            address = @address,
                            password = @password, 
                            available_days = @available_days, 
                            start_time = @start_time, 
                            end_time = @end_time
                        WHERE doctor_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text.Trim());
                        cmd.Parameters.AddWithValue("@lastname", txtLastname.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", txtDoB.Text.Trim());
                        cmd.Parameters.AddWithValue("@nic", txtNICnumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@spcialization", txtSpecialization.Text);
                        cmd.Parameters.AddWithValue("@mobile", txtMobile.Text.Trim());
                        cmd.Parameters.AddWithValue("@SLMCnumber", txtSLMCnumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@available_days", txtDay);
                        cmd.Parameters.AddWithValue("@start_time", txtFrom);
                        cmd.Parameters.AddWithValue("@end_time", txtTo);
                        cmd.Parameters.AddWithValue("@id", doctorId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account updated successfully!", "Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating account: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete your account?",
                                          "Confirm Deletion",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM doctor_profiles WHERE doctor_id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", doctorId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Your account has been deleted.", "Deleted");

                            // Redirect to Welcome dashboard 
                            welcome dashboard = new welcome();
                            dashboard.Show();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting account: " + ex.Message);
                    }
                }
            }
        }
    }
}
