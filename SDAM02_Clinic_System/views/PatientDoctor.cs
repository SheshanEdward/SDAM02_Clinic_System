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
    public partial class PatientDoctor : Form
    {
        public PatientDoctor()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PatientDashboard dashboard = new PatientDashboard();
            dashboard.Show();
            this.Close();
        }

        private void LoadAllDoctors()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            string query = "SELECT doctor_id, SLMCno, firstname, lastname, specialization, email, mobile FROM doctor_profiles";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvViewdoctors.DataSource = table;
            }
        }

        private void PatientDoctor_Load(object sender, EventArgs e)
        {
            LoadAllDoctors();
        }
    }
}
