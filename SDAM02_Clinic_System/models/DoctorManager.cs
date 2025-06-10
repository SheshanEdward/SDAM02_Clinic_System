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
        public void RegisterDoctor(string firstname, string lastname, DateTime dob, string email, string mobile, string nic, string address, string specialization, string SLMCno, string password)
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

                    string insertQuery = @"INSERT INTO doctor_creation_request 
                    (firstname, lastname, dob, email, mobile, nic, address, specialization, SLMCno, password)
                    VALUES (@firstname, @lastname, @dob, @email, @mobile, @nic, @address, @specialization, @SLMCno, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        //cmd.Parameters.AddWithValue("@doctor_id", newDoctorId);
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
                        MessageBox.Show("Account creation request submitted successfully!");
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
