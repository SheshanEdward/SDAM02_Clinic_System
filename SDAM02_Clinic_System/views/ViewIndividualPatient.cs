using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class ViewIndividualPatient : Form
    {
        private string patient_Id;

        public ViewIndividualPatient(string id)
        {
            InitializeComponent();
            patient_Id = id;
            LoadPatientDetails();
        }

        private void ViewIndividualPatient_Load(object sender, EventArgs e)
        {
            //Do not delete this line!!!!!
        }


        private void LoadPatientDetails()
        {
            string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";
            string query = "SELECT * FROM patient_profiles WHERE patient_id = @patient_id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patient_id", patient_Id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblPAtientID.Text = reader["patient_id"].ToString();
                            txtFirstname.Text = reader["firstname"].ToString();
                            txtLastname.Text = reader["lastname"].ToString();
                            txtDoB.Text = Convert.ToDateTime(reader["dob"]).ToString("yyyy-MM-dd");
                            txtNICnumber.Text = reader["nic"].ToString();
                            txtAddress.Text = reader["address"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtMobile.Text = reader["mobile"].ToString();
                            txtGender.Text = reader["gender"].ToString();
                            txtBloodtype.Text = reader["bloodtype"].ToString();
                            txtHeight.Text = reader["height"].ToString();
                            txtWeight.Text = reader["weight"].ToString();

                            // Add more if needed
                        }
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminViewPatients allPatients = new AdminViewPatients();
            allPatients.Show();
            this.Close();
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
                        cmd.Parameters.AddWithValue("@dob", txtDoB.Text.Trim());
                        cmd.Parameters.AddWithValue("@nic", txtNICnumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                        cmd.Parameters.AddWithValue("@bloodtype", txtBloodtype.Text);
                        cmd.Parameters.AddWithValue("@height", txtHeight.Text.Trim());
                        cmd.Parameters.AddWithValue("@weight", txtWeight.Text.Trim());
                        cmd.Parameters.AddWithValue("@contact", txtMobile.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", patient_Id);

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
                        string deleteQuery = "DELETE FROM patient_profiles WHERE patient_id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", patient_Id);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Your account has been deleted.", "Deleted");

                            // Redirect to Welcome dashboard 
                            //AdminViewPatients allPatients = new AdminViewPatients();
                            //allPatients.Show();
                            //this.Close();
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
