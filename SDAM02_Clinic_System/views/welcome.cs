using SDAM02_Clinic_System.models;
using SDAM02_Clinic_System.views;

namespace SDAM02_Clinic_System
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            reg_user_select select_user = new reg_user_select();
            select_user.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ID = txtUsername.Text.Trim();
            string PWD = txtPassword.Text;

            SessionManager.DetectUser(ID, PWD);

            if (SessionManager.IsLoggedIn == true)
            {
                this.Hide();
            }
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            //Do not delete!!!!!!
        }
    }
}
