using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SDAM02_Clinic_System.views
{
    public partial class DoctorCreationRequests : Form
    {
        public DoctorCreationRequests()
        {
            InitializeComponent();
        }


        private void LoadCreationRequests()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            string query = "SELECT id, nic, SLMCno, firstname, lastname, specialization, dob, email, mobile, address FROM doctor_creation_request";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCreationrequests.DataSource = table;
            }
        }

        private void DoctorCreationRequests_Load(object sender, EventArgs e)
        {
            LoadCreationRequests();
        }
    }
}
