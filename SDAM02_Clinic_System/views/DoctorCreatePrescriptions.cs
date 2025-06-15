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
    public partial class DoctorCreatePrescriptions : Form
    {
        private string doctorId;
        public DoctorCreatePrescriptions(string doctorId)
        {
            InitializeComponent();
            this.doctorId = doctorId;
        }

        private void DoctorCreatePrescriptions_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void LoadPatients()
        {
            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT patient_id, firstname, lastname FROM patient_profiles;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string patientId = reader["patient_id"].ToString();
                        string fullName = $"{reader["firstname"]} {reader["lastname"]}";
                        cmbPatients.Items.Add(new KeyValuePair<string, string>(patientId, fullName));
                    }

                    cmbPatients.DisplayMember = "Value";
                    cmbPatients.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patients: " + ex.Message);
                }
            }
        }

        private void btnAdddrug_Click(object sender, EventArgs e)
        {
            if (cmbPatients.SelectedItem == null || string.IsNullOrWhiteSpace(txtDrug.Text) || string.IsNullOrWhiteSpace(txtDosage.Text))
            {
                MessageBox.Show("Please fill all fields before adding a drug.");
                return;
            }

            string drug = txtDrug.Text.Trim();
            string dosage = txtDosage.Text.Trim();

            ListViewItem item = new ListViewItem(drug);
            item.SubItems.Add(dosage);
            lstDrugs.Items.Add(item);

            txtDrug.Clear();
            txtDosage.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbPatients.SelectedItem == null || lstDrugs.Items.Count == 0)
            {
                MessageBox.Show("Please select a patient and add at least one drug.");
                return;
            }

            var selectedPatient = (KeyValuePair<string, string>)cmbPatients.SelectedItem;
            string patientId = selectedPatient.Key;

            string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    foreach (ListViewItem item in lstDrugs.Items)
                    {
                        string drug = item.Text;
                        string dosage = item.SubItems[1].Text;

                        string insertQuery = @"INSERT INTO doctor_prescriptions 
                        (doctor_id, patient_id, drug_name, dosage, date_prescribed)
                        VALUES (@doctor_id, @patient_id, @drug_name, @dosage, @date);";

                        MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                        cmd.Parameters.AddWithValue("@doctor_id", doctorId);
                        cmd.Parameters.AddWithValue("@patient_id", patientId);
                        cmd.Parameters.AddWithValue("@drug_name", drug);
                        cmd.Parameters.AddWithValue("@dosage", dosage);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Prescriptions saved successfully.");
                    lstDrugs.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error submitting prescriptions: " + ex.Message);
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
