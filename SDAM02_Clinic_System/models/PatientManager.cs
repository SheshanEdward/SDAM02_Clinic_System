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
        private string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

        public void RegisterPatient(Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string newPatientId = "P001";
                    string idQuery = "SELECT patient_id FROM patient_profiles ORDER BY patient_id DESC LIMIT 1;";
                    using (MySqlCommand cmd = new MySqlCommand(idQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int lastNum = int.Parse(result.ToString().Substring(1)) + 1;
                            newPatientId = "P" + lastNum.ToString("D3");
                        }
                    }

                    string insertQuery = @"INSERT INTO patient_profiles 
                (patient_id, nic, firstname, lastname, dob, gender, bloodtype, height, weight, email, mobile, address, password)
                VALUES 
                (@patient_id, @nic, @firstname, @lastname, @dob, @gender, @bloodtype, @height, @weight, @email, @mobile, @address, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", newPatientId);
                        cmd.Parameters.AddWithValue("@nic", patient.nic);
                        cmd.Parameters.AddWithValue("@firstname", patient.Firstname);
                        cmd.Parameters.AddWithValue("@lastname", patient.Lastname);
                        cmd.Parameters.AddWithValue("@dob", patient.dob);
                        cmd.Parameters.AddWithValue("@gender", patient.Gender);
                        cmd.Parameters.AddWithValue("@bloodtype", patient.Bloodtype);
                        cmd.Parameters.AddWithValue("@height", patient.Height);
                        cmd.Parameters.AddWithValue("@weight", patient.Weight);
                        cmd.Parameters.AddWithValue("@email", patient.Email);
                        cmd.Parameters.AddWithValue("@mobile", patient.Mobile);
                        cmd.Parameters.AddWithValue("@address", patient.Address);
                        cmd.Parameters.AddWithValue("@password", patient.Password); // Consider hashing

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Patient registered successfully! ID: {newPatientId}", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Registration failed: " + ex.Message, "Error");
                }
            }
        }
    }
}
