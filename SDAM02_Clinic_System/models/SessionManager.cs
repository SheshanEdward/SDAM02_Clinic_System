using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using SDAM02_Clinic_System.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
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

            if (ID.StartsWith("p"))
            {
                string query = "SELECT * FROM patient_profiles WHERE patient_id = @id AND password = @password";
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
                                PatientDashboard patientUser = new PatientDashboard();
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

            else if (ID.StartsWith("a"))
            {
                string query = "SELECT * FROM admin_profiles WHERE admin_id = @id AND password = @password";
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
                                AdminDashboard adminUser = new AdminDashboard();
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

            else if (ID.StartsWith("d"))
            {
                string query = "SELECT * FROM doctor_profiles WHERE doctor_id = @id AND password = @password";
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
                                DoctorDashboard doctorUser = new DoctorDashboard();
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

        public static Admin GetLoggedInAdminProfile()
        {
            string id = LoggedIn;
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            string query = "SELECT * FROM admin_profiles WHERE admin_id = @id";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Map to your Admin constructor
                            string nic = reader["nic"].ToString();
                            string fname = reader["firstname"].ToString();
                            string lname = reader["lastname"].ToString();
                            DateTime dob = Convert.ToDateTime(reader["dob"]);
                            string email = reader["email"].ToString();
                            string mobile = reader["mobile"].ToString();
                            string address = reader["address"].ToString();
                            string pwd = ""; // Password excluded, or set to empty
                            string gender = reader["gender"].ToString();
                            string postal = reader["postal_code"].ToString();

                            return new Admin(nic, fname, lname, dob, email, mobile, address, pwd, gender, postal);
                        }
                    }
                }
            }

            return null;
        }



        public static void LogOut()
        {
            SessionManager.LoggedIn = null;
            welcome loginpage = new welcome();
            loginpage.Show();
        }


    }
}
