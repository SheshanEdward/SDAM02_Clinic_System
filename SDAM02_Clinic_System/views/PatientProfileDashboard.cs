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

namespace SDAM02_Clinic_System.views
{
    public partial class PatientProfileDashboard : Form
    {

        private int patientId;

        public PatientProfileDashboard(int id)
        {
            InitializeComponent();
            patientId = id;
            LoadPatientData();
        }

        private void LoadPatientData()
        {
            string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM patient_profiles WHERE patient_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", patientId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFirstname.Text = reader["firstname"].ToString();
                                txtLastname.Text = reader["lastname"].ToString();
                                dtpDoB.Value = Convert.ToDateTime(reader["dob"]);
                                txtNic.Text = reader["nic"].ToString();
                                cmbGender.Text = reader["gender"].ToString();
                                cmbBloodtype.Text = reader["blood_group"].ToString();
                                txtHeight.Text = reader["height"].ToString();
                                txtWeight.Text = reader["weight"].ToString();
                                txtMobile.Text = reader["contact"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtAddress.Text = reader["address"].ToString();
                                txtPassword.Text = reader["password"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patient data: " + ex.Message);
                }
            }
        }

        private void btnSaveEditedAccount_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string updateQuery = @"
                        UPDATE patient_profiles SET 
                            firstname = @firstname,
                            lastname = @lastname,
                            dob = @dob,
                            nic = @nic,
                            gender = @gender,
                            blood_group = @bloodgroup,
                            height = @height,
                            weight = @weight,
                            contact = @contact,
                            email = @email,
                            address = @address,
                            password = @password
                        WHERE patient_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text.Trim());
                        cmd.Parameters.AddWithValue("@lastname", txtLastname.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", dtpDoB.Value.Date);
                        cmd.Parameters.AddWithValue("@nic", txtNic.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@bloodgroup", cmbBloodtype.Text);
                        cmd.Parameters.AddWithValue("@height", txtHeight.Text.Trim());
                        cmd.Parameters.AddWithValue("@weight", txtWeight.Text.Trim());
                        cmd.Parameters.AddWithValue("@contact", txtMobile.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", patientId);

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            PatientDashboard dashboard = new PatientDashboard(patientId);
            dashboard.Show();
            this.Hide();
        }

        // Delete Account logic 

        private void btnDeleteAccount_Click(object sender, EventArgs e)
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
                        string deleteQuery = "DELETE FROM patient_profiles WHERE patient_id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", patientId);
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
