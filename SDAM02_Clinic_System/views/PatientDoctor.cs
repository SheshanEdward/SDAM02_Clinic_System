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
    public partial class PatientDoctor : Form
    {
        private int patientId;

        public PatientDoctor(int id)
        {
            InitializeComponent(); // Designer initializes controls
            patientId = id;

            // Hook event handlers if not done in Designer
            btnLoad.Click += BtnLoad_Click;
            btnBack.Click += BtnBack_Click;
        }

        private void LoadDoctorData()
        {
            try
            {
                DoctorManager manager = new DoctorManager();
                DataTable doctors = manager.GetAllDoctors();
                dgvViewalldoctors.DataSource = doctors;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctor data: " + ex.Message, "Database Error");
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadDoctorData();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            PatientDashboard dashboard = new PatientDashboard(patientId);
            dashboard.Show();
            this.Close();
        }
    }

    // Data access class remains the same
    public class DoctorManager
    {
        private string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

        public DataTable GetAllDoctors()
        {
            DataTable dt = new DataTable();

            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT 
                    firstname AS 'First Name', 
                    lastname AS 'Last Name', 
                    specialization AS 'Specialization', 
                    email AS 'Email' 
                FROM doctor_profiles";

                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    using (MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
