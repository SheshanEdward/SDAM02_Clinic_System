using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SDAM02_Clinic_System.models
{
    internal class AdminManager
    {
        public void RegisterAdmin(string firstname, string lastname, DateTime dob, string email, string mobile, string nic, string address, string password)
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Generating ID
                    string getLastIdQuery = "SELECT admin_id FROM admin_information ORDER BY admin_id DESC LIMIT 1;";
                    string newAdminId = "A001";

                    using (MySqlCommand getLastIdCmd = new MySqlCommand(getLastIdQuery, conn))
                    {
                        object result = getLastIdCmd.ExecuteScalar();
                        if (result != null)
                        {
                            string lastId = result.ToString(); 
                            int numericPart = int.Parse(lastId.Substring(1));
                            numericPart++;
                            newAdminId = "A" + numericPart.ToString("D3");
                        }
                    }

                    string insertQuery = @"INSERT INTO admin_information 
                    (admin_id, firstname, lastname, dob, email, mobile, nic, address, password)
                    VALUES (@admin_id, @firstname, @lastname, @dob, @email, @mobile, @nic, @address, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@admin_id", newAdminId);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@mobile", mobile);
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@address", address);
                        //cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // Consider hashing

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Admin registered successfully! ID: {newAdminId}");
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
