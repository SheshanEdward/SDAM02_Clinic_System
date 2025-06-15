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
        }

        private void LoadPrescriptions()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            prescription_id AS 'Prescription ID',
                            patient_id AS 'Patient ID',
                            drug_name AS 'Drug',
                            dosage AS 'Dosage',
                            date_prescribed AS 'Date'
                        FROM doctor_prescriptions
                        WHERE doctor_id = @doctorId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvViewprescriptions.DataSource = dt;
                    dgvViewprescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvViewprescriptions.ReadOnly = true;
                    dgvViewprescriptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading prescriptions: " + ex.Message);
                }
            }
        }

        private void btnCreateprescription_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DoctorCreatePrescriptions(doctorId).Show();
        }

        private void btnEditprescription_Click(object sender, EventArgs e)
        {
            if (dgvViewprescriptions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a prescription to edit.");
                return;
            }

            string prescriptionId = dgvViewprescriptions.SelectedRows[0].Cells["Prescription ID"].Value.ToString();
            this.Hide();
            new DoctorEditPrescription(doctorId, prescriptionId).Show();
        }

        private void btnDeletePrescription_Click(object sender, EventArgs e)
        {
            if (dgvViewprescriptions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a prescription to delete.");
                return;
            }

            string prescriptionId = dgvViewprescriptions.SelectedRows[0].Cells["Prescription ID"].Value.ToString();

            var confirm = MessageBox.Show("Are you sure you want to delete this prescription?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM doctor_prescriptions WHERE prescription_id = @id;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", prescriptionId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Prescription deleted successfully.");
                    LoadPrescriptions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting prescription: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DoctorDashboard().Show();
        }

    }
}
