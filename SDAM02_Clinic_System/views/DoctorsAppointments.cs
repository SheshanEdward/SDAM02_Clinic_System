using MySql.Data.MySqlClient;
using SDAM02_Clinic_System.models;
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
    public partial class DoctorsAppointments : Form
    {
        private string doctor_Id = SessionManager.LoggedIn;

        public DoctorsAppointments()
        {
            InitializeComponent();
            ViewAppointments();
        }

        private void ViewAppointments()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            string tableName = $"appointments_{doctor_Id}";

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
                        dgvMyappointments.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading appointments: " + ex.Message);
                }
            }

        }

        private void DoctorsAppointments_Load(object sender, EventArgs e)
        {
            ViewAppointments();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DoctorDashboard dashboard = new DoctorDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
