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
    public partial class PatientAllAppointments : Form
    {
        private string patientId;
        private DataGridView dvgPatientappointments;

        public PatientAllAppointments(string patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientScheduleAppointment(patientId).Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientDashboard().Show();
        }

        private void LoadAppointments()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        a.appointment_id AS 'Appointment ID',
                        CONCAT(d.firstname, ' ', d.lastname) AS 'Doctor Name',
                        s.service_name AS 'Service',
                        a.appointment_date AS 'Date & Time',
                        a.status AS 'Status',
                        a.notes AS 'Notes'
                    FROM appointment_data a
                    JOIN doctor_profiles d ON a.doctor_id = d.doctor_id
                    JOIN clinic_service s ON a.service_id = s.service_id
                    WHERE a.patient_id = @patientId
                    ORDER BY a.appointment_date DESC;
                ";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@patientId", patientId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPatientappointments.DataSource = dt;
                    dgvPatientappointments.ReadOnly = true;
                    dgvPatientappointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load appointments: " + ex.Message, "Database Error");
                }
            }

        }
        private void dgvPatientappointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PatientAllAppointments_Load(object sender, EventArgs e)
        {
            //Note to myself, please dont delete 
        }
    }
}
