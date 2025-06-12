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
    public partial class ReviewDoctor : Form
    {

        private int requestId;
        public ReviewDoctor(int id)
        {
            InitializeComponent();
            requestId = id;
            LoadDoctorDetails();
        }

        private void LoadDoctorDetails()
        {
            string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";
            string query = "SELECT * FROM doctor_creation_requests WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", requestId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFirstname.Text = reader["firstname"].ToString();
                            txtLastname.Text = reader["lastname"].ToString();
                            txtDoB.Text = Convert.ToDateTime(reader["dob"]).ToString("yyyy-MM-dd");
                            txtNICnumber.Text = reader["nic"].ToString();
                            txtSLMCregno.Text = reader["SLMCno"].ToString();
                            txtAddress.Text = reader["address"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtMobile.Text = reader["mobile"].ToString();
                            txtSpecialization.Text = reader["specialization"].ToString();

                            // Add more if needed
                        }
                    }
                }
            }
        }

        private void DeleteRequest()
        {
            string deleteQuery = "DELETE FROM doctor_creation_requests WHERE id = @id";
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=clinic_system_db;"))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", requestId);
                    cmd.ExecuteNonQuery();
                }
            }
        }



        public void InsertIntoDoctorProfiles(int requestId)
        {
            string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // Step 1: Generate new doctor_id
                string getLastIdQuery = "SELECT doctor_id FROM doctor_profiles ORDER BY doctor_id DESC LIMIT 1;";
                string newDoctorId = "D001";

                using (MySqlCommand getLastIdCmd = new MySqlCommand(getLastIdQuery, conn))
                {
                    object result = getLastIdCmd.ExecuteScalar();
                    if (result != null)
                    {
                        string lastId = result.ToString();
                        int numericPart = int.Parse(lastId.Substring(1));
                        numericPart++;
                        newDoctorId = "D" + numericPart.ToString("D3");
                    }
                }

                // Step 2: Read from doctor_creation_requests
                string selectQuery = "SELECT * FROM doctor_creation_requests WHERE id = @id";
                using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn))
                {
                    selectCmd.Parameters.AddWithValue("@id", requestId);

                    using (MySqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nic = reader["nic"].ToString();
                            string slmc = reader["SLMCno"].ToString();
                            string firstname = reader["firstname"].ToString();
                            string lastname = reader["lastname"].ToString();
                            string specialization = reader["specialization"].ToString();
                            DateTime dob = Convert.ToDateTime(reader["dob"]);
                            string email = reader["email"].ToString();
                            string mobile = reader["mobile"].ToString();
                            string address = reader["address"].ToString();
                            string password = reader["password"].ToString();

                            reader.Close(); // must close before insert

                            // Step 3: Insert into doctor_profiles
                            string insertQuery = @"INSERT INTO doctor_profiles 
                        (doctor_id, nic, SLMCno, firstname, lastname, specialization, dob, email, mobile, address, password) 
                        VALUES (@doctor_id, @nic, @SLMCno, @firstname, @lastname, @specialization, @dob, @email, @mobile, @address, @password);";

                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@doctor_id", newDoctorId);
                                insertCmd.Parameters.AddWithValue("@nic", nic);
                                insertCmd.Parameters.AddWithValue("@SLMCno", slmc);
                                insertCmd.Parameters.AddWithValue("@firstname", firstname);
                                insertCmd.Parameters.AddWithValue("@lastname", lastname);
                                insertCmd.Parameters.AddWithValue("@specialization", specialization);
                                insertCmd.Parameters.AddWithValue("@dob", dob);
                                insertCmd.Parameters.AddWithValue("@email", email);
                                insertCmd.Parameters.AddWithValue("@mobile", mobile);
                                insertCmd.Parameters.AddWithValue("@address", address);
                                insertCmd.Parameters.AddWithValue("@password", password);

                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            InsertIntoDoctorProfiles(requestId);
            DeleteRequest();
            MessageBox.Show("Doctor approved.");
            this.Close();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            DeleteRequest();
            MessageBox.Show("Doctor request declined.");
            this.Close();
        }
    }
}
