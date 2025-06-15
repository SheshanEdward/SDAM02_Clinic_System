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
    public partial class PatientConfirmAppointment : Form
    {
        public string doctor_Id;
        public PatientConfirmAppointment(string id)
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
                            lblFirstname.Text = reader["firstname"].ToString();
                            lblLastname.Text = reader["lastname"].ToString();
                            lblSpecialization.Text = reader["specialization"].ToString();
                            lblSLMCnumber.Text = reader["SLMCno"].ToString();
                            lblAvailable.Text = reader["available_days"].ToString();
                            lblFrom.Text = reader["start_time"].ToString();
                            lblTo.Text = reader["end_time"].ToString();
                            // Add more if needed
                        }
                    }
                }
            }
        }
    }
}
