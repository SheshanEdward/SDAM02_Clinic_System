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


                    string insertToAllAppointments = @"
                        INSERT INTO all_appointments (patient_id, doctor_id, appointment_date, appointment_time)
                        VALUES (@patient_id_all, @doctor_id_all, @date_all, @time_all);";

                    using (MySqlCommand cmdAll = new MySqlCommand(insertToAllAppointments, conn))
                    {
                        cmdAll.Parameters.AddWithValue("@patient_id_all", patientId);
                        cmdAll.Parameters.AddWithValue("@doctor_id_all", appointment.doctor_Id);
                        cmdAll.Parameters.AddWithValue("@date_all", appointment.appointmentDate.Date);
                        cmdAll.Parameters.AddWithValue("@time_all", appointment.appointmentTime.TimeOfDay);
                        cmdAll.ExecuteNonQuery();
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
