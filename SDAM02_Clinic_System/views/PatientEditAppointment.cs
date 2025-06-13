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
    public partial class PatientEditAppointment : Form
    {
        private string patientId;
        private string selectedAppointmentId;

        public PatientEditAppointment(string patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        private void PatientEditAppointment_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            LoadDoctorsAndServices();
        }

        private void LoadAppointments()
        {
            AppointmentManager manager = new AppointmentManager();
            var appointments = manager.ViewAppointmentsByPatient(patientId);
            dgvViewallappointments.DataSource = appointments;
            dgvViewallappointments.ClearSelection();
            selectedAppointmentId = null;
        }

        private void LoadDoctorsAndServices()
        {
            cmbDoctor.Items.Clear();
            cmbService.Items.Clear();

            using (var conn = new MySqlConnection("server=localhost;user=root;password=;database=clinic_system_db;"))
            {
                conn.Open();

                // Load doctors
                var doctorCmd = new MySqlCommand("SELECT doctor_id, firstname, lastname FROM doctor_profiles", conn);
                var dr = doctorCmd.ExecuteReader();
                while (dr.Read())
                {
                    string docId = dr["doctor_id"].ToString();
                    string fullName = $"{dr["firstname"]} {dr["lastname"]}";
                    cmbDoctor.Items.Add(new KeyValuePair<string, string>(docId, fullName));
                }
                dr.Close();

                // Load services
                var serviceCmd = new MySqlCommand("SELECT service_id, service_name FROM clinic_service", conn);
                var sr = serviceCmd.ExecuteReader();
                while (sr.Read())
                {
                    int serviceId = Convert.ToInt32(sr["service_id"]);
                    string serviceName = sr["service_name"].ToString();
                    cmbService.Items.Add(new KeyValuePair<int, string>(serviceId, serviceName));
                }
                sr.Close();
            }

            cmbDoctor.DisplayMember = "Value";
            cmbDoctor.ValueMember = "Key";
            cmbService.DisplayMember = "Value";
            cmbService.ValueMember = "Key";
        }

        private void dgvViewallappointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvViewallappointments.Rows[e.RowIndex];
                selectedAppointmentId = row.Cells["appointment_id"].Value.ToString();

                dtpDatetime.Value = Convert.ToDateTime(row.Cells["appointment_date"].Value);

                string doctorId = row.Cells["doctor_id"].Value.ToString();
                foreach (KeyValuePair<string, string> item in cmbDoctor.Items)
                {
                    if (item.Key == doctorId)
                    {
                        cmbDoctor.SelectedItem = item;
                        break;
                    }
                }

                int serviceId = Convert.ToInt32(row.Cells["service_id"].Value);
                foreach (KeyValuePair<int, string> item in cmbService.Items)
                {
                    if (item.Key == serviceId)
                    {
                        cmbService.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnSaveeditedappointment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedAppointmentId))
            {
                MessageBox.Show("Please select an appointment to edit.");
                return;
            }

            if (cmbDoctor.SelectedItem == null || cmbService.SelectedItem == null)
            {
                MessageBox.Show("Please select both a doctor and a service.");
                return;
            }

            var selectedDoctor = (KeyValuePair<string, string>)cmbDoctor.SelectedItem;
            var selectedService = (KeyValuePair<int, string>)cmbService.SelectedItem;
            DateTime newDate = dtpDatetime.Value;

            AppointmentManager manager = new AppointmentManager();
            if (!manager.CheckDoctorAvailability(selectedDoctor.Key, newDate))
            {
                MessageBox.Show("The doctor is not available at the selected time.");
                return;
            }

            string message;
            if (manager.UpdateAppointment(selectedAppointmentId, newDate, selectedService.Key, out message))
            {
                MessageBox.Show(message);
                LoadAppointments();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void btnDeleteappointment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedAppointmentId))
            {
                MessageBox.Show("Please select an appointment to cancel.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm Cancel", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                AppointmentManager manager = new AppointmentManager();
                string message;
                if (manager.CancelAppointment(selectedAppointmentId, out message))
                {
                    MessageBox.Show(message);
                    LoadAppointments();
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientDashboard dashboard = new PatientDashboard(patientId);
            dashboard.Show();
        }
    }
}
