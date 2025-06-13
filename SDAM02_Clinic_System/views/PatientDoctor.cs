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
        private string patientId;
        public PatientDoctor(string patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDoctorData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientDashboard(patientId).Show();  // Redirect back to PatientDashboard
        }

        private void LoadDoctorData()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            doctor_id AS 'Doctor ID', 
                            firstname AS 'First Name', 
                            lastname AS 'Last Name', 
                            specialization AS 'Specialization', 
                            email AS 'Email', 
                            mobile AS 'Contact Number' 
                        FROM doctor_profiles;";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvViewalldoctors.DataSource = dt;

                    dgvViewalldoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvViewalldoctors.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading doctor data: " + ex.Message, "Database Error");
                }
            }
        }

        private void PatientDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
