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
    public partial class AdminViewDoctors : Form
    {
        public AdminViewDoctors()
        {
            InitializeComponent();
        }

        private void LoadAllDoctors()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            string query = "SELECT doctor_id, nic, SLMCno, firstname, lastname, specialization, dob, email, mobile, address, available_days, start_time, end_time FROM doctor_profiles";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvViewdoctors.DataSource = table;
            }
        }

        private void AdminViewDoctors_Load(object sender, EventArgs e)
        {
            LoadAllDoctors();

            dgvViewdoctors.CellDoubleClick += dgvViewalldoctors_CellDoubleClick;
        }

        private void dgvViewalldoctors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvViewdoctors.Rows[e.RowIndex];
                string doctor_Id = Convert.ToString(row.Cells["doctor_id"].Value);

                AdminIndividualDoc viewDoctor = new AdminIndividualDoc(doctor_Id);
                viewDoctor.ShowDialog();
            }
        }
    }
}
