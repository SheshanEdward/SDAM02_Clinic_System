using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class AppointmentManager
    {
        private string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

        // Generate next ID like AP001
        private string GetNextAppointmentId(MySqlConnection conn)
        {
            string newId = "AP001";
            string query = "SELECT appointment_id FROM appointment_data ORDER BY appointment_id DESC LIMIT 1;";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string lastId = result.ToString();
                    int number = int.Parse(lastId.Substring(2)) + 1;
                    newId = "AP" + number.ToString("D3");
                }
            }
            return newId;
        }

        // Check if the doctor is available at the given time
        public bool CheckDoctorAvailability(string doctorId, DateTime date)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM appointment_data WHERE doctor_id=@doctor_id AND appointment_date=@date AND status='Scheduled';";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@doctor_id", doctorId);
                    cmd.Parameters.AddWithValue("@date", date);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 0;
                }
            }
        }

        // Book a new appointment
        public void BookAppointment(string patientId, string doctorId, int serviceId, DateTime appointmentDate)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    if (!CheckDoctorAvailability(doctorId, appointmentDate))
                    {
                        MessageBox.Show("Doctor is not available at this time.");
                        return;
                    }

                    string appointmentId = GetNextAppointmentId(conn);

                    string insertQuery = @"INSERT INTO appointment_data 
                (appointment_id, patient_id, doctor_id, service_id, appointment_date, status) 
                VALUES 
                (@appointment_id, @patient_id, @doctor_id, @service_id, @appointment_date, 'Scheduled');";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@appointment_id", appointmentId);
                        cmd.Parameters.AddWithValue("@patient_id", patientId);
                        cmd.Parameters.AddWithValue("@doctor_id", doctorId);
                        cmd.Parameters.AddWithValue("@service_id", serviceId);
                        cmd.Parameters.AddWithValue("@appointment_date", appointmentDate);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Appointment booked successfully! ID: " + appointmentId);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error booking appointment: " + ex.Message);
                }
            }
        }

        // View appointments by patient
        public List<Appointment> ViewAppointmentsByPatient(string patientId)
        {
            List<Appointment> appointments = new List<Appointment>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM appointment_data WHERE patient_id = @patient_id;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patient_id", patientId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointments.Add(new Appointment
                            {
                                AppointmentId = reader["appointment_id"].ToString(),
                                PatientId = reader["patient_id"].ToString(),
                                DoctorId = reader["doctor_id"].ToString(),
                                ServiceId = Convert.ToInt32(reader["service_id"]),
                                AppointmentDate = Convert.ToDateTime(reader["appointment_date"]),
                                Status = reader["status"].ToString()
                            });
                        }
                    }
                }
            }
            return appointments;
        }

        // View appointments by doctor
        public List<Appointment> ViewAppointmentsByDoctor(string doctorId)
        {
            List<Appointment> appointments = new List<Appointment>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM appointment_data WHERE doctor_id = @doctor_id;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@doctor_id", doctorId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointments.Add(new Appointment
                            {
                                AppointmentId = reader["appointment_id"].ToString(),
                                PatientId = reader["patient_id"].ToString(),
                                DoctorId = reader["doctor_id"].ToString(),
                                ServiceId = Convert.ToInt32(reader["service_id"]),
                                AppointmentDate = Convert.ToDateTime(reader["appointment_date"]),
                                Status = reader["status"].ToString()
                            });
                        }
                    }
                }
            }
            return appointments;
        }

        // Update appointment
        public void UpdateAppointment(string appointmentId, DateTime newDate, int newServiceId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE appointment_data SET appointment_date=@newDate, service_id=@newServiceId WHERE appointment_id=@appointment_id;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@newDate", newDate);
                    cmd.Parameters.AddWithValue("@newServiceId", newServiceId);
                    cmd.Parameters.AddWithValue("@appointment_id", appointmentId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment updated.");
                }
            }
        }

        // Cancel appointment
        public void CancelAppointment(string appointmentId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE appointment_data SET status='Cancelled' WHERE appointment_id=@appointment_id;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@appointment_id", appointmentId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment cancelled.");
                }
            }
        }

        // Get a specific appointment by ID
        public Appointment GetAppointmentById(string appointmentId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM appointment_data WHERE appointment_id=@appointment_id;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@appointment_id", appointmentId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Appointment
                            {
                                AppointmentId = reader["appointment_id"].ToString(),
                                PatientId = reader["patient_id"].ToString(),
                                DoctorId = reader["doctor_id"].ToString(),
                                ServiceId = Convert.ToInt32(reader["service_id"]),
                                AppointmentDate = Convert.ToDateTime(reader["appointment_date"]),
                                Status = reader["status"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }


    }
}
