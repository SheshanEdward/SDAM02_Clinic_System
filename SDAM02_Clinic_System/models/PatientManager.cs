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
        public void RegisterPatient(Patient patient)
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Generating ID
                    string getLastIdQuery = "SELECT patient_id FROM patient_profile ORDER BY patient_id DESC LIMIT 1;";
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

                    string insertQuery = @"INSERT INTO patient_profile 
                    (patient_id, nic, firstname, lastname, dob, gender, bloodtype, height, weight, email, mobile, address, password)
                    VALUES (@patient_id, @nic, @firstname, @lastname, @dob, @gender, @bloodtype, @height, @weight, @email, @mobile, @address, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", newPatientId);
                        cmd.Parameters.AddWithValue("@firstname", patient.Firstname);
                        cmd.Parameters.AddWithValue("@lastname", patient.Lastname);
                        cmd.Parameters.AddWithValue("@dob", patient.dob);
                        cmd.Parameters.AddWithValue("@email", patient.Email);
                        cmd.Parameters.AddWithValue("@mobile", patient.Mobile);
                        cmd.Parameters.AddWithValue("@nic", patient.nic);
                        cmd.Parameters.AddWithValue("@gender", patient.Gender);
                        cmd.Parameters.AddWithValue("@bloodtype", patient.Bloodtype);
                        cmd.Parameters.AddWithValue("@height", patient.Height);
                        cmd.Parameters.AddWithValue("@weight", patient.Weight);
                        cmd.Parameters.AddWithValue("@address", patient.Address);
                        cmd.Parameters.AddWithValue("@password", patient.Password); // Try to figure real time masking

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
