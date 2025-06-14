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
    public partial class AdminIndividualDoc : Form
    {
        private string doctor_Id;
        public AdminIndividualDoc(string id)
        {
            InitializeComponent();
            doctor_Id = id;
            LoadDoctorDetails();
        }


        private void LoadDoctorDetails()
        {
            string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";
            string query = "SELECT * FROM doctor_profiles WHERE doctor_id = @doctor_id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@doctor_id", doctor_Id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblDoctorid.Text = reader["doctor_id"].ToString();
                            txtFirstname.Text = reader["firstname"].ToString();
                            txtLastname.Text = reader["lastname"].ToString();
                            txtDoB.Text = Convert.ToDateTime(reader["dob"]).ToString("yyyy-MM-dd");
                            txtNICnumber.Text = reader["nic"].ToString();
                            txtAddress.Text = reader["address"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtMobile.Text = reader["mobile"].ToString();
                            txtSpecialization.Text = reader["specialization"].ToString();
                            txtSLMCnumber.Text = reader["SLMCno"].ToString();
                            txtAvailable.Text = reader["available_days"].ToString();
                            txtFrom.Text = reader["start_time"].ToString();
                            txtTo.Text = reader["end_time"].ToString();
                            // Add more if needed
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";
            string query = @"UPDATE doctor_profiles 
                     SET firstname = @firstname,
                         lastname = @lastname,
                         dob = @dob,
                         nic = @nic,
                         address = @address,
                         email = @email,
                         mobile = @mobile,
                         specialization = @specialization,
                         SLMCno = @slmcno,
                         available_days = @available_days,
                         start_time = @start_time,
                         end_time = @end_time
                     WHERE doctor_id = @doctor_id";

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
                    cmd.Parameters.AddWithValue("@specialization", txtSpecialization.Text.Trim());
                    cmd.Parameters.AddWithValue("@slmcno", txtSLMCnumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@available_days", txtAvailable.Text.Trim());
                    cmd.Parameters.AddWithValue("@start_time", txtFrom.Text.Trim());
                    cmd.Parameters.AddWithValue("@end_time", txtTo.Text.Trim());
                    cmd.Parameters.AddWithValue("@doctor_id", doctor_Id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Doctor details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Optional: close the form after update

                    }
                    else
                    {
                        MessageBox.Show("Update failed. No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this account?",
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
                            cmd.Parameters.AddWithValue("@id", doctor_Id);
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
