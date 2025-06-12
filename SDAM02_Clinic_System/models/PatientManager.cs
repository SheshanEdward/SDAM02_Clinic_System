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

                    string insertQuery = @"
                        INSERT INTO patients 
                        (nic, firstname, lastname, dob, email, mobile, address, password, gender, bloodtype, height, weight)
                        VALUES 
                        (@nic, @firstname, @lastname, @dob, @email, @mobile, @address, @password, @gender, @bloodtype, @height, @weight);
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", patient.nic);
                        cmd.Parameters.AddWithValue("@firstname", patient.Firstname);
                        cmd.Parameters.AddWithValue("@lastname", patient.Lastname);
                        cmd.Parameters.AddWithValue("@dob", patient.Dob);
                        cmd.Parameters.AddWithValue("@email", patient.Email);
                        cmd.Parameters.AddWithValue("@mobile", patient.Mobile);
                        cmd.Parameters.AddWithValue("@address", patient.Address);
                        cmd.Parameters.AddWithValue("@password", patient.Password);
                        cmd.Parameters.AddWithValue("@gender", patient.Gender);
                        cmd.Parameters.AddWithValue("@bloodtype", patient.Bloodtype);
                        cmd.Parameters.AddWithValue("@height", patient.Height);
                        cmd.Parameters.AddWithValue("@weight", patient.Weight);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Patient registered successfully!");
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
