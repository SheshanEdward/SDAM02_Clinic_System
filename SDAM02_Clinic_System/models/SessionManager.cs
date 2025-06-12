using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using SDAM02_Clinic_System.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class SessionManager
    {
        public static string LoggedIn;
        public static string UserType;
        public static bool IsLoggedIn;



        public static void DetectUser(string ID, string PWD)
        {
            //Need to shrink the code and make it to work using variables and fucntions instead of repeating code.
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

            if (ID.StartsWith("P"))
            {
                string query = "SELECT * FROM patient_profile WHERE patient_id = @id AND password = @password";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@password", PWD);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SessionManager.LoggedIn = ID;
                                SessionManager.UserType = "Patient";
                                MessageBox.Show("Patient login successful!");
                                patient_dashboard patientUser = new patient_dashboard();
                                patientUser.Show();
                                IsLoggedIn = true;
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID or password.");
                            }
                        }
                    }
                }
            }

            else if (ID.StartsWith("A"))
            {
                string query = "SELECT * FROM admin_profile WHERE admin_id = @id AND password = @password";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@password", PWD);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SessionManager.LoggedIn = ID;
                                SessionManager.UserType = "Admin";
                                MessageBox.Show("Admin login successful!");
                                admin_dashboard adminUser = new admin_dashboard();
                                adminUser.Show();
                                IsLoggedIn = true;
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID or password.");
                            }
                        }
                    }
                }
            }

            else if (ID.StartsWith("D"))
            {
                string query = "SELECT * FROM doctor_profile WHERE doctor_id = @id AND password = @password";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@password", PWD);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SessionManager.LoggedIn = ID;
                                SessionManager.UserType = "Doctor";
                                MessageBox.Show("Doctor login successful!");
                                doctor_dashboard doctorUser = new doctor_dashboard();
                                doctorUser.Show();
                                IsLoggedIn = true;
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID or password.");
                            }
                        }
                    }
                }
            }
        }
    }
}
