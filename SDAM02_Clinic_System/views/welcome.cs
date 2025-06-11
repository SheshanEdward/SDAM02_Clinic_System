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

        }
    }
}
