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
    public partial class DoctorProfile : Form
    {
        private string doctorId;
        public DoctorProfile()
        {
            InitializeComponent();
            LoadDoctorData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DoctorDashboard doctorDashboard = new DoctorDashboard();
            doctorDashboard.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //Accidental, do not delete.
        }


        private void LoadDoctorData()
        {
            string connStr = "server=localhost;user=root;password=;database=clinic_system_db;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM doctor_profiles WHERE doctor_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", doctorId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblDoctorid.Text = reader["doctor_id"].ToString();
                                txtFirstname.Text = reader["firstname"].ToString();
                                txtLastname.Text = reader["lastname"].ToString();
                                txtDoB.Text = reader["dob"].ToString();
                                txtNICnumber.Text = reader["nic"].ToString();
                                txtSpecialization.Text = reader["gender"].ToString();
                                txtSLMCnumber.Text = reader["bloodtype"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtAddress.Text = reader["address"].ToString();
                                txtPassword.Text = reader["password"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patient data: " + ex.Message);
                }
            }
        }
    }
}
