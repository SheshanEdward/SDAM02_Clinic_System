using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class DoctorManager
    {
        public void RegisterDoctor(string firstname, string lastname, DateTime dob, string email, string mobile, string nic, string address, int specialization, string SLMCno, string password)
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Generating ID
                    string getLastIdQuery = "SELECT doctor_id FROM doctor_information ORDER BY doctor_id DESC LIMIT 1;";
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

                    string insertQuery = @"INSERT INTO doctor_information 
                    (doctor_id, firstname, lastname, dob, email, mobile, nic, address, specialization, SLMCno, password)
                    VALUES (@doctor_id, @firstname, @lastname, @dob, @email, @mobile, @nic, @address, @specialization, @SLMCno, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@doctor_id", newDoctorId);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@mobile", mobile);
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@specialization", specialization);
                        cmd.Parameters.AddWithValue("@SLMCno", SLMCno);
                        cmd.Parameters.AddWithValue("@password", password); // Consider hashing

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Admin registered successfully! ID: {newDoctorId}");
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
