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
    public partial class PatientPrescription : Form
    {
        private string patientId = SessionManager.LoggedIn;
        public PatientPrescription(string patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            ViewPrescriptions();
        }

        // Load button click - loads all prescriptions for the patient
        

        // Back button - go back to PatientDashboard
        private void btnBack_Click(object sender, EventArgs e)
        {
            PatientDashboard dashboard = new PatientDashboard();
            dashboard.Show();
            this.Close();
        }

        // Loads prescription data from the database for the current patient
        private void ViewPrescriptions()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            string tableName = $"prescriptions_patient_{patientId}";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM {tableName};";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvViewPrescription.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading appointments: " + ex.Message);
                }
            }
        }

        private void PatientPrescription_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            PatientDashboard back = new PatientDashboard();
            back.Show();
            this.Close();
        }
    }
}
