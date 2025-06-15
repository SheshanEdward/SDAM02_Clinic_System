using MySql.Data.MySqlClient;
using SDAM02_Clinic_System.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM02_Clinic_System.views
{
    public partial class PatientAllAppointments : Form
    {
        private string patientId =  SessionManager.LoggedIn;

        public PatientAllAppointments()
        {
            InitializeComponent();
            this.patientId = patientId.ToLower();
            ViewAppointments();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            PatientScheduleAppointment ScheduleAppointment = new PatientScheduleAppointment();
            ScheduleAppointment.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //do not delete this
        }

        private void ViewAppointments()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            string tableName = $"appointments_patient_{patientId}";

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
                        dgvPatientappointments.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading appointments: " + ex.Message);
                }
            }
        }


        private void dgvPatientappointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) // Make sure it's not the header row
            {
                DataGridViewRow row = dgvPatientappointments.Rows[e.RowIndex];

                string appointmentId = row.Cells["appointment_id"].Value.ToString();
                string doctorId = row.Cells["doctor_id"].Value.ToString();
                string appointmentDate = row.Cells["appointment_date"].Value.ToString();
                string appointmentTime = row.Cells["appointment_time"].Value.ToString();

                PatientIndividualAppointment detailsForm = new PatientIndividualAppointment(
                    appointmentId, doctorId, appointmentDate, appointmentTime);
                detailsForm.Show();
            }
        }

        private void PatientAllAppointments_Load(object sender, EventArgs e)
        {
            //Note to myself, please dont delete 
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            PatientDashboard patientDashboard = new PatientDashboard();
            patientDashboard.Show();
            this.Hide();
        }

        private void btnSchedule_Click_1(object sender, EventArgs e)
        {
            PatientScheduleAppointment scheduleAppointment = new PatientScheduleAppointment();
            scheduleAppointment.Show();
            this.Hide();
        }
    }
}
