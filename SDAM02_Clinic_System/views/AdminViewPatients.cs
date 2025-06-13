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
    public partial class AdminViewPatients : Form
    {
        public AdminViewPatients()
        {
            InitializeComponent();
        }

        private void LoadAllPatients()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            string query = "SELECT patient_id, nic, firstname, lastname, dob, gender, bloodtype, height, weight, email, mobile, address FROM patient_profiles";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvAllpatients.DataSource = table;
            }
        }

        private void AdminViewPatients_Load(object sender, EventArgs e)
        {
            LoadAllPatients();

            dgvAllpatients.CellDoubleClick += dgvViewallpatients_CellDoubleClick;
        }

        private void dgvViewallpatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAllpatients.Rows[e.RowIndex];
                int requestId = Convert.ToInt32(row.Cells["id"].Value);

                AdminViewPatients AllPatients = new AdminViewPatients();
                AllPatients.ShowDialog();

                //LoadAllPatients(); 
            }
        }
    }
}
