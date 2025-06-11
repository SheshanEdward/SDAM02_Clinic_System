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
        public void RegisterAdmin(Admin admin)
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Generating ID
                    string getLastIdQuery = "SELECT admin_id FROM admin_profile ORDER BY admin_id DESC LIMIT 1;";
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

                    string insertQuery = @"INSERT INTO admin_profile 
                    (admin_id, nic, firstname, lastname, dob, gender, email, mobile, address, postal_code, password)
                    VALUES (@admin_id, @nic, @firstname, @lastname, @dob, @gender, @email, @mobile, @address, @postal_code, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@admin_id", newAdminId);
                        cmd.Parameters.AddWithValue("@firstname", admin.Firstname);
                        cmd.Parameters.AddWithValue("@lastname", admin.Lastname);
                        cmd.Parameters.AddWithValue("@dob", admin.dob);
                        cmd.Parameters.AddWithValue("@email", admin.Email);
                        cmd.Parameters.AddWithValue("@mobile", admin.Mobile);
                        cmd.Parameters.AddWithValue("@nic", admin.nic);
                        cmd.Parameters.AddWithValue("@address", admin.Address);
                        cmd.Parameters.AddWithValue("@gender", admin.Gender);
                        cmd.Parameters.AddWithValue("@postal_code", admin.Postalcode);
                        cmd.Parameters.AddWithValue("@password", admin.Password); // Consider hashing

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
