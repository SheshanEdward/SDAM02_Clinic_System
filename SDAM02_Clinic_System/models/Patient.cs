using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class Patient : Person
    {
        public string Gender { get; set; }
        public string Bloodtype { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Patient(
            string nic, string firstname, string lastname, DateTime dob,
            string email, string mobile, string address, string password,
            string gender, string bloodtype, double height, double weight
        ) : base(nic, firstname, lastname, dob, email, mobile, address, password)


        {
            this.Gender = gender;
            this.Bloodtype = bloodtype;
            this.Height = height;
            this.Weight = weight;
        }
    }
}
