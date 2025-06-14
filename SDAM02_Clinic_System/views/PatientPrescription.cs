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
    public partial class PatientPrescription : Form
    {
        private string patientId;
        public PatientPrescription(string patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        // Load button click - loads all prescriptions for the patient
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadPrescriptions();
        }

        // Back button - go back to PatientDashboard
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientDashboard().Show();
        }

        // Loads prescription data from the database for the current patient
        private void LoadPrescriptions()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            prescription_id AS 'Prescription ID',
                            drug_name AS 'Drug Name',
                            dosage AS 'Dosage',
                            notes AS 'Notes',
                            date_prescribed AS 'Date Prescribed'
                        FROM prescriptions
                        WHERE patient_id = @patient_id;";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@patient_id", patientId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvViewPrescription.DataSource = dt;

                    dgvViewPrescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvViewPrescription.ReadOnly = true;
                    dgvViewPrescription.AllowUserToAddRows = false;
                    dgvViewPrescription.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading prescriptions: " + ex.Message, "Database Error");
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
            this.Hide();
        }
    }
}
