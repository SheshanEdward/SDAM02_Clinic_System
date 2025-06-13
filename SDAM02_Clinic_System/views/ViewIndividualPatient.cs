using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class ViewIndividualPatient : Form
    {
        private string patient_Id;

        public ViewIndividualPatient(string id)
        {
            InitializeComponent();
            patient_Id = id;
            LoadPatientDetails();
        }

        private void ViewIndividualPatient_Load(object sender, EventArgs e)
        {
            //Do not delete this line!!!!!
        }


        private void LoadPatientDetails()
        {
            string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";
            string query = "SELECT * FROM patient_profiles WHERE patient_id = @patient_id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patient_id", patient_Id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblPAtientID.Text = reader["patient_id"].ToString();
                            txtFirstname.Text = reader["firstname"].ToString();
                            txtLastname.Text = reader["lastname"].ToString();
                            txtDoB.Text = Convert.ToDateTime(reader["dob"]).ToString("yyyy-MM-dd");
                            txtNICnumber.Text = reader["nic"].ToString();
                            txtAddress.Text = reader["address"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtMobile.Text = reader["mobile"].ToString();
                            txtGender.Text = reader["gender"].ToString();
                            txtBloodtype.Text = reader["bloodtype"].ToString();
                            txtHeight.Text = reader["height"].ToString();
                            txtWeight.Text = reader["weight"].ToString();

                            // Add more if needed
                        }
                    }
                }
            }
        }
    }
}
