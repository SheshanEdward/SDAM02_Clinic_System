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
    public partial class PatientScheduleAppointment : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

        // Add this private field for the logged-in patient ID
        private string currentLoggedInPatientId;

        // Replace the parameterless constructor with this one:
        public PatientScheduleAppointment(string patientId)
        {
            InitializeComponent();
            currentLoggedInPatientId = patientId;
        }

        // Remove or comment out this old parameterless constructor:
        // public PatientScheduleAppointment()
        // {
        //     InitializeComponent();
        // }

        private void PatientScheduleAppointment_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            LoadServices();
        }

        private void LoadDoctors()
        {
            string query = "SELECT doctor_id, name FROM doctor_data";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbDoctor.Items.Add(new ComboBoxItem
                        {
                            Text = reader["name"].ToString(),
                            Value = reader["doctor_id"].ToString()
                        });
                    }
                }
            }
        }

        private void LoadServices()
        {
            string query = "SELECT service_id, service_name FROM clinic_service";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbService.Items.Add(new ComboBoxItem
                        {
                            Text = reader["service_name"].ToString(),
                            Value = reader["service_id"].ToString()
                        });
                    }
                }
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (cmbDoctor.SelectedItem == null || cmbService.SelectedItem == null)
            {
                MessageBox.Show("Please select both doctor and service.");
                return;
            }

            string doctorId = ((ComboBoxItem)cmbDoctor.SelectedItem).Value;
            int serviceId = int.Parse(((ComboBoxItem)cmbService.SelectedItem).Value);
            DateTime appointmentDate = dtpAppointmentdate.Value;

            // Use the patient ID passed in the constructor
            string patientId = currentLoggedInPatientId;

            AppointmentManager manager = new AppointmentManager();
            if (manager.BookAppointment(patientId, doctorId, serviceId, appointmentDate, out string message))
            {
                MessageBox.Show("Appointment scheduled successfully!\n" + message);
            }
            else
            {
                MessageBox.Show("Failed to schedule appointment.\n" + message);
            }
        }
    }

    class ComboBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public override string ToString() => Text;
    }
}
