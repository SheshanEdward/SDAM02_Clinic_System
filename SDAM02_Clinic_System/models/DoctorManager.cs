using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class DoctorManager
    {
        public void RegisterRequest(Doctor doctor)
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string getLastIdQuery = "SELECT doctor_id FROM doctor_profiles ORDER BY doctor_id DESC LIMIT 1;";
                    string newDoctorId = "d001";

                    using (MySqlCommand getLastIdCmd = new MySqlCommand(getLastIdQuery, conn))
                    {
                        object result = getLastIdCmd.ExecuteScalar();
                        string lastId = result?.ToString() ?? "";

                        if (!string.IsNullOrEmpty(lastId) && lastId.StartsWith("d") && lastId.Length > 1)
                        {
                            int numericPart;
                            if (int.TryParse(lastId.Substring(1), out numericPart))
                            {
                                numericPart++;
                                newDoctorId = "d" + numericPart.ToString("D3");
                            }
                        }

                        string insertQuery = @"INSERT INTO doctor_profiles 
                    (doctor_id, nic, SLMCno, firstname, lastname, specialization, dob, email, mobile, address, password, available_days, start_time, end_time)
                    VALUES (@doctor_id, @nic, @SLMCno, @firstname, @lastname, @specialization, @dob, @email, @mobile, @address, @password, @available_days, start_time, @end_time);";

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        {
                            
                            cmd.Parameters.AddWithValue("@doctor_id", newDoctorId);
                            cmd.Parameters.AddWithValue("@firstname", doctor.Firstname);
                            cmd.Parameters.AddWithValue("@lastname", doctor.Lastname);
                            cmd.Parameters.AddWithValue("@dob", doctor.dob);
                            cmd.Parameters.AddWithValue("@email", doctor.Email);
                            cmd.Parameters.AddWithValue("@mobile", doctor.Mobile);
                            cmd.Parameters.AddWithValue("@nic", doctor.nic);
                            cmd.Parameters.AddWithValue("@address", doctor.Address);
                            cmd.Parameters.AddWithValue("@specialization", doctor.Specialization);
                            cmd.Parameters.AddWithValue("@SLMCno", doctor.Slmcregno);
                            cmd.Parameters.AddWithValue("@password", doctor.Password);
                            cmd.Parameters.AddWithValue("@available_days", doctor.AvailableDays);
                            cmd.Parameters.AddWithValue("@start_time", doctor.StartTime);
                            cmd.Parameters.AddWithValue("@end_time", doctor.EndTime);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show($"Account created successfully!  ID: {newDoctorId}");
                        }

                        string safeDoctorId = Regex.Replace(newDoctorId, @"[^\w]", "");



                        string createAppointmentsTable = $@" 

                        CREATE TABLE IF NOT EXISTS appointments_{safeDoctorId} ( 

                            appointment_id INT AUTO_INCREMENT PRIMARY KEY, 

                            patient_id VARCHAR(50), 

                            appointment_date DATE, 

                            appointment_time TIME 

                        );";



                        using (MySqlCommand createTableCmd = new MySqlCommand(createAppointmentsTable, conn))

                        {

                            createTableCmd.ExecuteNonQuery();

                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
