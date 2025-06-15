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
            //LoadPatients();
        }

        //private void LoadPatients()
        //{
        //    string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";
        //    using (MySqlConnection conn = new MySqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            conn.Open();
        //            string query = "SELECT patient_id, firstname, lastname FROM patient_profiles;";
        //            MySqlCommand cmd = new MySqlCommand(query, conn);
        //            MySqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                string patientId = reader["patient_id"].ToString();
        //                string fullName = $"{reader["firstname"]} {reader["lastname"]}";
        //                cmbPatients.Items.Add(new KeyValuePair<string, string>(patientId, fullName));
        //            }

        //            cmbPatients.DisplayMember = "Value";
        //            cmbPatients.ValueMember = "Key";
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error loading patients: " + ex.Message);
        //        }
        //    }
        //}

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DoctorDashboard().Show();
        }

    }
}
