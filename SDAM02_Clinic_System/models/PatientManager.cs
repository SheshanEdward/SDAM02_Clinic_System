using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    string getLastIdQuery = "SELECT patient_id FROM patient_profiles ORDER BY patient_id DESC LIMIT 1;";
                    string newPatientId = "p001";

                    using (MySqlCommand getLastIdCmd = new MySqlCommand(getLastIdQuery, conn))
                    {
                        object result = getLastIdCmd.ExecuteScalar();
                        if (result != null)
                        {
                            string lastId = result.ToString();
                            int numericPart = int.Parse(lastId.Substring(1));
                            numericPart++;
                            newPatientId = "p" + numericPart.ToString("D3");
                        }
                    }

                    string insertQuery = @"INSERT INTO patient_profiles 
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
                        cmd.Parameters.AddWithValue("@address", patient.Address);
                        cmd.Parameters.AddWithValue("@gender", patient.Gender);
                        cmd.Parameters.AddWithValue("@bloodtype", patient.Bloodtype);
                        cmd.Parameters.AddWithValue("@height", patient.Height);
                        cmd.Parameters.AddWithValue("@weight", patient.Weight);
                        cmd.Parameters.AddWithValue("@password", patient.Password); // Consider hashing

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Patient registered successfully! ID: {newPatientId}");
                    }

                    // Clean patient ID for table name
                    string safePatientId = Regex.Replace(newPatientId, @"[^\w]", "");

                    // Create appointments table for this patient
                    string createAppointmentsTable = $@"
                        CREATE TABLE IF NOT EXISTS appointments_patient_{safePatientId} (
                            appointment_id INT AUTO_INCREMENT PRIMARY KEY,
                            doctor_id VARCHAR(50),
                            appointment_date DATE,
                            appointment_time TIME
                        );";

                    using (MySqlCommand createAppointmentsCmd = new MySqlCommand(createAppointmentsTable, conn))
                    {
                        createAppointmentsCmd.ExecuteNonQuery();
                    }

                    // Create prescriptions table for this patient
                    string createPrescriptionsTable = $@"
                        CREATE TABLE IF NOT EXISTS prescriptions_patient_{safePatientId} (
                            prescription_id INT AUTO_INCREMENT PRIMARY KEY,
                            doctor_id VARCHAR(50),
                            date DATE,
                            medication TEXT
                        );";

                    using (MySqlCommand createPrescriptionsCmd = new MySqlCommand(createPrescriptionsTable, conn))
                    {
                        createPrescriptionsCmd.ExecuteNonQuery();
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
