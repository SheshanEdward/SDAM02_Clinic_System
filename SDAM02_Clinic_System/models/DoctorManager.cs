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
                    (nic, SLMCno, firstname, lastname, specialization, dob, email, mobile, address, password)
                    VALUES (@nic, @SLMCno, @firstname, @lastname, @specialization, @dob, @email, @mobile, @address, @password);";

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
                        cmd.Parameters.AddWithValue("@password", doctor.Password); // If there is time, have to mask

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
