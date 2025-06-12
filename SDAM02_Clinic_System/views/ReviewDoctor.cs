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

        
        
        private void btnApprove_Click(object sender, EventArgs e)
        {
            DoctorManager.InsertIntoDoctorProfiles(requestId);
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
