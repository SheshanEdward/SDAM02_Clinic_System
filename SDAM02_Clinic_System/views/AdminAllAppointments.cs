using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM02_Clinic_System.views
{
    public partial class AdminAllAppointments : Form
    {
        public AdminAllAppointments()
        {
            InitializeComponent();
            ViewallAppointments();
        }




        private void ViewallAppointments()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            string tableName = "all_appointments";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM {tableName};";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvAllappointments.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading appointments: " + ex.Message);
                }


            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
