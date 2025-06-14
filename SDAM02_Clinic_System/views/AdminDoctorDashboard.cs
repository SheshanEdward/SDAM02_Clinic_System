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
    public partial class AdminDoctorDashboard : Form
    {
        public AdminDoctorDashboard()
        {
            InitializeComponent();
        }

        private void btnCreationrequest_Click(object sender, EventArgs e)
        {
            //DoctorCreationRequests displayRequests = new DoctorCreationRequests();
           // displayRequests.Show();
            //this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DoctorRegister newDoctor = new DoctorRegister();
            newDoctor.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            AdminViewDoctors registeredDoctors = new AdminViewDoctors();
            registeredDoctors.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }
    }
}
