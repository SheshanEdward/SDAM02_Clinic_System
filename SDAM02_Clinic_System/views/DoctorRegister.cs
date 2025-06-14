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
    public partial class DoctorRegister : Form
    {
        public DoctorRegister()
        {
            InitializeComponent();

            //Values for the specialization
            cmbSpecialization.Items.Add("General Physician");
            cmbSpecialization.Items.Add("Cardiologist");
            cmbSpecialization.Items.Add("Dermatologist");
            cmbSpecialization.Items.Add("Neurologist");
            cmbSpecialization.Items.Add("Pediatrician");
            cmbSpecialization.Items.Add("Physiatrist");
            cmbSpecialization.Items.Add("Psychiatrist");

        }

        private void DoctorRegister_Load(object sender, EventArgs e)
        {
            clbAvailability.Items.AddRange(new string[] {
            "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            });

            dtpStart.Value = DateTime.Today.AddHours(9);
            dtpEnd.Value = DateTime.Today.AddHours(17);
        }

        List<(string Day, TimeSpan Start, TimeSpan End)> availabilityList = new List<(string, TimeSpan, TimeSpan)>();

        private void btnApproval_Click(object sender, EventArgs e)
        {
            Doctor newDoctor = new Doctor(
                txtNICnumber.Text,
                txtFirstname.Text,
                txtLastname.Text,
                dtpDoB.Value.Date,
                txtEmail.Text,
                txtMobile.Text,
                txtAddress.Text,
                txtPassword.Text,
                txtSLMCnumber.Text,
                cmbSpecialization.SelectedItem.ToString()

             );


            List<string> daysList = new List<string>();
            TimeSpan start = TimeSpan.Zero;
            TimeSpan end = TimeSpan.Zero;

            foreach (DataGridViewRow row in dgvSchedule.Rows)

            {

                if (row.Cells["Day"].Value != null)

                {

                    daysList.Add(row.Cells["Day"].Value.ToString());



                    // Assign start/end time from the first valid row 

                    if (start == TimeSpan.Zero && end == TimeSpan.Zero)

                    {

                        start = TimeSpan.Parse(row.Cells["StartTime"].Value.ToString());

                        end = TimeSpan.Parse(row.Cells["EndTime"].Value.ToString());

                    }

                }

            }

            newDoctor.AvailableDays = string.Join(",", daysList);
            newDoctor.StartTime = start;
            newDoctor.EndTime = end;



            DoctorManager manager = new DoctorManager();

            manager.RegisterRequest(newDoctor);
            this.Close();
        }

        private void btnAddschedule_Click(object sender, EventArgs e)
        {
            TimeSpan start = dtpStart.Value.TimeOfDay;

            TimeSpan end = dtpEnd.Value.TimeOfDay;



            if (start >= end)

            {

                MessageBox.Show("Start time must be earlier than end time.");

                return;

            }


            dgvSchedule.Columns.Add("Day", "Day");
            dgvSchedule.Columns.Add("StartTime", "Start Time");
            dgvSchedule.Columns.Add("EndTime", "End Time");



            foreach (string day in clbAvailability.CheckedItems)

            {

                availabilityList.Add((day, start, end));
                dgvSchedule.Rows.Add(day, start, end);

            }
        }
    }
}
