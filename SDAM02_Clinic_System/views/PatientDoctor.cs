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
    public partial class PatientDoctor : Form
    {

        private int patientId;

        
        private DataGridView dgvViewalldoctors;
        private Button btnLoad;
        private Button btnBack;

        public PatientDoctor(int id)
        {
            InitializeComponent(); 
            patientId = id;
        }

        private void InitializeComponent()
        {
            this.dgvViewalldoctors = new DataGridView();
            this.btnLoad = new Button();
            this.btnBack = new Button();

            // 
            // dgvViewalldoctors
            // 
            this.dgvViewalldoctors.Location = new System.Drawing.Point(12, 50);
            this.dgvViewalldoctors.Size = new System.Drawing.Size(600, 300);
            this.dgvViewalldoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewalldoctors.ReadOnly = true;
            this.dgvViewalldoctors.AllowUserToAddRows = false;
            this.dgvViewalldoctors.AllowUserToDeleteRows = false;

            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Size = new System.Drawing.Size(75, 30);
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new EventHandler(BtnLoad_Click);

            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(100, 12);
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new EventHandler(BtnBack_Click);

            // 
            // PatientDoctor Form
            // 
            this.ClientSize = new System.Drawing.Size(640, 370);
            this.Controls.Add(this.dgvViewalldoctors);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnBack);
            this.Text = "Patient Doctor";
        }

        // OOP Applied: Separated database logic into its own class and method for encapsulation and clarity
        private void LoadDoctorData()
        {
            try
            {
                DoctorManager manager = new DoctorManager();
                DataTable doctors = manager.GetAllDoctors();
                dgvViewalldoctors.DataSource = doctors;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctor data: " + ex.Message, "Database Error");
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadDoctorData();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            PatientDashboard dashboard = new PatientDashboard(patientId);
            dashboard.Show();
            this.Close();
        }
    }

    // OOP Applied: Created a separate class to encapsulate doctor data access logic
    public class DoctorManager
    {
        private string connectionString = "server=localhost;user=root;password=;database=clinic_system_db;";

        public DataTable GetAllDoctors()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT 
                    firstname AS 'First Name', 
                    lastname AS 'Last Name', 
                    specialization AS 'Specialization', 
                    email AS 'Email' 
                FROM doctor_profiles";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
