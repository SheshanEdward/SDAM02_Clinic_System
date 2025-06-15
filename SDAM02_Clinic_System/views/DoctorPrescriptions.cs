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
    public partial class DoctorPrescriptions : Form
    {
        private string doctorId;
        public DoctorPrescriptions()
        {
            InitializeComponent();
        }


        private void DoctorPrescriptions_Load(object sender, EventArgs e)
        {
            LoadPrescriptions();
            dgvViewprescriptions.CellDoubleClick += dgvViewprescriptions_CellDoubleClick;
        }

        private void LoadPrescriptions()
        {
            string doctorId = SessionManager.LoggedIn; // or however you're storing the current doctor ID 

            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

            string tableName = $"appointments_{doctorId}";
            string query = $"SELECT patient_id AS 'Patient ID', medication AS 'Medication' FROM `{tableName}`;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))

            {
                try
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvViewprescriptions.DataSource = table; 
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DoctorDashboard().Show();
        }


        private void dgvViewprescriptions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex >= 0)

            {
                string selectedPatientId = dgvViewprescriptions.Rows[e.RowIndex].Cells["Patient ID"].Value.ToString();
                string doctorId = SessionManager.LoggedIn;

                DoctorCreatePrescriptions detailsForm = new DoctorCreatePrescriptions(doctorId, selectedPatientId);
                detailsForm.ShowDialog(); 
            }

        }



    }
}
