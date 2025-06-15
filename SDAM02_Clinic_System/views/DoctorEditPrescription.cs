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
    public partial class DoctorEditPrescription : Form
    {
        private string doctorId;
        private string prescriptionId;
        private string patientId;

        public DoctorEditPrescription(string doctorId, string prescriptionId)
        {
            InitializeComponent();
            this.doctorId = doctorId;
            this.prescriptionId = prescriptionId;
        }

       
        private void LoadPrescriptionData()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.prescription_id, p.patient_id, pf.firstname, pf.lastname,
                                            p.drug_name, p.dosage
                                     FROM doctor_prescriptions p
                                     JOIN patient_profiles pf ON p.patient_id = pf.patient_id
                                     WHERE p.prescription_id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", prescriptionId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        patientId = reader["patient_id"].ToString();
                        string patientName = reader["firstname"] + " " + reader["lastname"];
                        string drug = reader["drug_name"].ToString();
                        string dosage = reader["dosage"].ToString();

                        cmbPatients.Items.Add(new KeyValuePair<string, string>(patientId, patientName));
                        cmbPatients.SelectedIndex = 0;
                        cmbPatients.Enabled = false;

                        ListViewItem item = new ListViewItem(drug);
                        item.SubItems.Add(dosage);
                        lstDrugs.Items.Add(item);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading prescription: " + ex.Message);
                }
            }
        }

        private void btnAdddrud_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDrug.Text) || string.IsNullOrWhiteSpace(txtDosage.Text))
            {
                MessageBox.Show("Please fill in both drug name and dosage.");
                return;
            }

            ListViewItem item = new ListViewItem(txtDrug.Text.Trim());
            item.SubItems.Add(txtDosage.Text.Trim());
            lstDrugs.Items.Clear(); // Overwrite previous drug for single-drug editing
            lstDrugs.Items.Add(item);

            txtDrug.Clear();
            txtDosage.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstDrugs.Items.Count == 0)
            {
                MessageBox.Show("Please add at least one drug before saving.");
                return;
            }

            string drug = lstDrugs.Items[0].Text;
            string dosage = lstDrugs.Items[0].SubItems[1].Text;

            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = @"UPDATE doctor_prescriptions
                                           SET drug_name = @drug, dosage = @dosage
                                           WHERE prescription_id = @id";

                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@drug", drug);
                    cmd.Parameters.AddWithValue("@dosage", dosage);
                    cmd.Parameters.AddWithValue("@id", prescriptionId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prescription updated successfully.");
                    this.Hide();
                    new DoctorPrescriptions().Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating prescription: " + ex.Message);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DoctorDashboard().Show();
        }

        private void lstDrugs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DoctorEditPrescription_Load(object sender, EventArgs e)
        {
            LoadPrescriptionData();
        }
    }
}
