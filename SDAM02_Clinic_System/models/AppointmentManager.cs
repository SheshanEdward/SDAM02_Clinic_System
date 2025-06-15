using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SDAM02_Clinic_System.models
{
    internal class AppointmentManager
    {
        //private readonly string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

        // Utility: Create connection
        //private MySqlConnection GetConnection()
        //{
        //return new MySqlConnection(connectionString);
        //}

        // Utility: Generate next appointment ID
        //private string GenerateNextId(MySqlConnection conn)
        //{
        //string newId = "AP001";
        //string query = "SELECT appointment_id FROM appointment_data ORDER BY appointment_id DESC LIMIT 1;";
        //using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //{
        //object result = cmd.ExecuteScalar();
        //if (result != null)
        //{
        //int lastNumber = int.Parse(result.ToString().Substring(2)) + 1;
        //newId = $"AP{lastNumber:D3}";
        //}
        //}
        //return newId;
        //}

        // Utility: Map reader to Appointment object
        //private Appointment MapReaderToAppointment(MySqlDataReader reader)
        //{
        //return new Appointment
        //{
        //AppointmentId = reader["appointment_id"].ToString(),
        //PatientId = reader["patient_id"].ToString(),
        //DoctorId = reader["doctor_id"].ToString(),
        //ServiceId = Convert.ToInt32(reader["service_id"]),
        //AppointmentDate = Convert.ToDateTime(reader["appointment_date"]),
        //Status = reader["status"].ToString()
        //};
        //}

        // Public: Check if a doctor is available at a time
        //public bool CheckDoctorAvailability(string doctorId, DateTime date)
        //{
        //using (var conn = GetConnection())
        //{
        //conn.Open();
        //string query = @"SELECT COUNT(*) FROM appointment_data 
        //WHERE doctor_id = @doctor_id AND appointment_date = @date AND status = 'Scheduled';";
        //using (var cmd = new MySqlCommand(query, conn))
        //{
        //cmd.Parameters.AddWithValue("@doctor_id", doctorId);
        //cmd.Parameters.AddWithValue("@date", date);
        //return Convert.ToInt32(cmd.ExecuteScalar()) == 0;
        //}
        //}
        //}

        // Public: Book appointment
        //public bool BookAppointment(string patientId, string doctorId, int serviceId, DateTime appointmentDate, out string message)
        //{
        //message = "";
        //using (var conn = GetConnection())
        //{
        // try
        //{
        //conn.Open();

        //if (!CheckDoctorAvailability(doctorId, appointmentDate))
        //{
        //message = "Doctor is not available at this time.";
        //return false;
        //}

        //string newId = GenerateNextId(conn);
        //string query = @"INSERT INTO appointment_data 
        //(appointment_id, patient_id, doctor_id, service_id, appointment_date, status)
        //VALUES (@id, @patient, @doctor, @service, @date, 'Scheduled');";

        //using (var cmd = new MySqlCommand(query, conn))
        //{
        //cmd.Parameters.AddWithValue("@id", newId);
        //cmd.Parameters.AddWithValue("@patient", patientId);
        //cmd.Parameters.AddWithValue("@doctor", doctorId);
        //cmd.Parameters.AddWithValue("@service", serviceId);
        //cmd.Parameters.AddWithValue("@date", appointmentDate);
        //cmd.ExecuteNonQuery();
        //}

        //message = $"Appointment booked successfully! ID: {newId}";
        //return true;
        //}
        //catch (Exception ex)
        //{
        //message = "Error: " + ex.Message;
        //return false;
        //}
        //}
        //}

        // Public: View appointments by patient
        //public List<Appointment> ViewAppointmentsByPatient(string patientId)
        //{
        //var appointments = new List<Appointment>();
        //    using (var conn = GetConnection())
        //    {
        //        conn.Open();
        //        string query = "SELECT * FROM appointment_data WHERE patient_id = @patient_id;";
        //        using (var cmd = new MySqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@patient_id", patientId);
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                    appointments.Add(MapReaderToAppointment(reader));
        //            }
        //        }
        //    }
        //    return appointments;
        //}

        //// Public: View appointments by doctor
        //public List<Appointment> ViewAppointmentsByDoctor(string doctorId)
        //{
        //    var appointments = new List<Appointment>();
        //    using (var conn = GetConnection())
        //    {
        //        conn.Open();
        //        string query = "SELECT * FROM appointment_data WHERE doctor_id = @doctor_id;";
        //        using (var cmd = new MySqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@doctor_id", doctorId);
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                    appointments.Add(MapReaderToAppointment(reader));
        //            }
        //        }
        //    }
        //    return appointments;
        //}

        // Public: Update appointment
        //public bool UpdateAppointment(string appointmentId, DateTime newDate, int newServiceId, out string message)
        //{
        //    using (var conn = GetConnection())
        //    {
        //        try
        //        {
        //            conn.Open();
        //            string query = @"UPDATE appointment_data 
        //                         SET appointment_date = @date, service_id = @service 
        //                         WHERE appointment_id = @id;";
        //            using (var cmd = new MySqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@date", newDate);
        //                cmd.Parameters.AddWithValue("@service", newServiceId);
        //                cmd.Parameters.AddWithValue("@id", appointmentId);
        //                cmd.ExecuteNonQuery();
        //            }
        //            message = "Appointment updated successfully.";
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            message = "Error updating: " + ex.Message;
        //            return false;
        //        }
        //    }
        //}

        // Public: Cancel appointment
        //public bool CancelAppointment(string appointmentId, out string message)
        //{
        //    using (var conn = GetConnection())
        //    {
        //        try
        //        {
        //            conn.Open();
        //            string query = "UPDATE appointment_data SET status = 'Cancelled' WHERE appointment_id = @id;";
        //            using (var cmd = new MySqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@id", appointmentId);
        //                cmd.ExecuteNonQuery();
        //            }
        //            message = "Appointment cancelled.";
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            message = "Error cancelling: " + ex.Message;
        //            return false;
        //        }
        //    }
        //}

        // Public: Get appointment by ID
        //public Appointment GetAppointmentById(string appointmentId)
        //{
        //    using (var conn = GetConnection())
        //    {
        //        conn.Open();
        //        string query = "SELECT * FROM appointment_data WHERE appointment_id = @id;";
        //        using (var cmd = new MySqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@id", appointmentId);
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                    return MapReaderToAppointment(reader);
        //            }
        //        }
        //    }
        //    return null;
        //}

        //public virtual void scheduleappointment()
        //{
        //    string patient = sessionmanager.loggedin;
        //}

        public void SubmitAppointment(Appointment appointment)
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            string patientId = appointment.patientId;
            string tableName = $"appointments_patient_{patientId}";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string insertQuery = $@"
                INSERT INTO `{tableName}` (doctor_id, appointment_date, appointment_time)
                VALUES (@doctor_id, @date, @time);";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@doctor_id", appointment.doctor_Id);
                        cmd.Parameters.AddWithValue("@date", appointment.appointmentDate.Date);
                        cmd.Parameters.AddWithValue("@time", appointment.appointmentTime.TimeOfDay);

                        cmd.ExecuteNonQuery();
                    }


                    string insertToDoctorTable = $@"
                INSERT INTO `appointments_{appointment.doctor_Id}` (patient_id, appointment_date, appointment_time)
                VALUES (@patient_id, @date, @time);";

                    using (MySqlCommand cmdDoctor = new MySqlCommand(insertToDoctorTable, conn))
                    {
                        cmdDoctor.Parameters.AddWithValue("@patient_id", patientId);
                        cmdDoctor.Parameters.AddWithValue("@date", appointment.appointmentDate.Date);
                        cmdDoctor.Parameters.AddWithValue("@time", appointment.appointmentTime.TimeOfDay);
                        cmdDoctor.ExecuteNonQuery();
                    }


                    MessageBox.Show("Appointment scheduled successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
