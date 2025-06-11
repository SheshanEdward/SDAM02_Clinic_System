using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SDAM02_Clinic_System.models
{
    internal class PatientManager
    {
        public void RegisterPatient(string firstname, string lastname, DateTime dob, string email, string mobile, string nic, string gender, string bloodtype, double height, double weight, string address, string password)
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Generating ID
                    string getLastIdQuery = "SELECT patient_id FROM patient_data ORDER BY patient_id DESC LIMIT 1;";
                    string newPatientId = "P001";

                    using (MySqlCommand getLastIdCmd = new MySqlCommand(getLastIdQuery, conn))
                    {
                        object result = getLastIdCmd.ExecuteScalar();
                        if (result != null)
                        {
                            string lastId = result.ToString();
                            int numericPart = int.Parse(lastId.Substring(1));
                            numericPart++;
                            newPatientId = "P" + numericPart.ToString("D3");
                        }
                    }

                    // Insert query
                    string insertQuery = @"INSERT INTO patient_data 
                    (patient_id, firstname, lastname, dob, email, mobile, nic, gender, bloodtype, height, weight, address, password)
                    VALUES (@patient_id, @firstname, @lastname, @dob, @email, @mobile, @nic, @address, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", newPatientId);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@mobile", mobile);
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@bloodtype", bloodtype);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@password", password); // Consider hashing

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Admin registered successfully! ID: {newPatientId}");
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
