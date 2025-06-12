using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class Patient : Person
    {
        private string gender;
        private string bloodtype;
        private double height;
        private double weight;

        public Patient(
            string nic, string firstname, string lastname, DateTime dob,
            string email, string mobile, string address, string password,
            string gender, string bloodtype, double height, double weight
        ) : base(nic, firstname, lastname, dob, email, mobile, address, password)
        {
            this.gender = gender;
            this.bloodtype = bloodtype;
            this.height = height;
            this.weight = weight;
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Bloodtype
        {
            get { return bloodtype; }
            set { bloodtype = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public object Dob { get; internal set; }
    }
}
