using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

                    // Generating ID
                    //string getLastIdQuery = "SELECT doctor_id FROM doctor_creation_approval ORDER BY doctor_id DESC LIMIT 1;";
                    //string newDoctorId = "DCR001";

                    //using (MySqlCommand getLastIdCmd = new MySqlCommand(getLastIdQuery, conn))
                    //{
                       // object result = getLastIdCmd.ExecuteScalar();
                        //if (result != null)
                        //{
                            //string lastId = result.ToString();
                            //int numericPart = int.Parse(lastId.Substring(1));
                            //numericPart++;
                            //newDoctorId = "DCR" + numericPart.ToString("D3");
                        //}
                    //}

                    string insertQuery = @"INSERT INTO doctor_creation_requests 
                    (nic, SLMCno, firstname, lastname, specialization, dob, email, mobile, address, password, available_days, start_time, end_time)
                    VALUES (@nic, @SLMCno, @firstname, @lastname, @specialization, @dob, @email, @mobile, @address, @password, @available_days, start_time, @end_time);";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        //cmd.Parameters.AddWithValue("@doctor_id", newDoctorId);
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
                        MessageBox.Show("Account creation request submitted successfully!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        public static void InsertIntoDoctorProfiles(int requestId)
        {
            string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string getLastIdQuery = "SELECT doctor_id FROM doctor_profiles ORDER BY doctor_id DESC LIMIT 1;";
                string newDoctorId = "D001";

                using (MySqlCommand getLastIdCmd = new MySqlCommand(getLastIdQuery, conn))
                {
                    object result = getLastIdCmd.ExecuteScalar();
                    if (result != null)
                    {
                        string lastId = result.ToString();
                        int numericPart = int.Parse(lastId.Substring(1));
                        numericPart++;
                        newDoctorId = "D" + numericPart.ToString("D3");
                    }
                }

                // Step 2: Read from doctor_creation_requests
                string selectQuery = "SELECT * FROM doctor_creation_requests WHERE id = @id";
                using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn))
                {
                    selectCmd.Parameters.AddWithValue("@id", requestId);

                    using (MySqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nic = reader["nic"].ToString();
                            string slmc = reader["SLMCno"].ToString();
                            string firstname = reader["firstname"].ToString();
                            string lastname = reader["lastname"].ToString();
                            string specialization = reader["specialization"].ToString();
                            DateTime dob = Convert.ToDateTime(reader["dob"]);
                            string email = reader["email"].ToString();
                            string mobile = reader["mobile"].ToString();
                            string address = reader["address"].ToString();
                            string password = reader["password"].ToString();

                            reader.Close(); // must close before insert

                            // Step 3: Insert into doctor_profiles
                            string insertQuery = @"INSERT INTO doctor_profiles 
                        (doctor_id, nic, SLMCno, firstname, lastname, specialization, dob, email, mobile, address, password) 
                        VALUES (@doctor_id, @nic, @SLMCno, @firstname, @lastname, @specialization, @dob, @email, @mobile, @address, @password);";

                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@doctor_id", newDoctorId);
                                insertCmd.Parameters.AddWithValue("@nic", nic);
                                insertCmd.Parameters.AddWithValue("@SLMCno", slmc);
                                insertCmd.Parameters.AddWithValue("@firstname", firstname);
                                insertCmd.Parameters.AddWithValue("@lastname", lastname);
                                insertCmd.Parameters.AddWithValue("@specialization", specialization);
                                insertCmd.Parameters.AddWithValue("@dob", dob);
                                insertCmd.Parameters.AddWithValue("@email", email);
                                insertCmd.Parameters.AddWithValue("@mobile", mobile);
                                insertCmd.Parameters.AddWithValue("@address", address);
                                insertCmd.Parameters.AddWithValue("@password", password);

                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
    }
}
