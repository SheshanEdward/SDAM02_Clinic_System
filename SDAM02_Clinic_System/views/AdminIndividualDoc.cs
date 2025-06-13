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

                            // Add more if needed
                        }
                    }
                }
            }
        }
    }
}
