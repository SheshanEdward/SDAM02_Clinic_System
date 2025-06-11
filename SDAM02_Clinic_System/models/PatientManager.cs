using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class PatientManager
    {
        public void RegisterPatient(string firstname, string lastname, DateTime dob, string nic, int height, int weight, string contact, string email, string bloodgroup, string medicalhistory)
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Generate new patient_id
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
                (patient_id, firstname, lastname, dob, nic, height, weight, contact, email, blood_group, medical_history) 
                VALUES 
                (@patient_id, @firstname, @lastname, @dob, @nic, @height, @weight, @contact, @email, @blood_group, @medical_history);";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", newPatientId);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@blood_group", bloodgroup);
                        cmd.Parameters.AddWithValue("@medical_history", medicalhistory);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Patient registered successfully! ID: {newPatientId}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error registering patient: " + ex.Message);
                }
            }
        }

    }
}
