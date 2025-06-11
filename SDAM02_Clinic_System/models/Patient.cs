using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class Patient : Person
    {
        //private string patient_id;
        private string gender;
        private string bloodtype;
        private double height;
        private double weight;


        public Patient(string NIC, string firstname, string lastname, DateTime DoB, string email, string mobile, string address, string password, string gender, string bloodtype, double height, double weight) : base(NIC, firstname, lastname, DoB, email, mobile, address, password)
        {
            //this.patient_id = patient_id;
            this.gender = gender;
            this.bloodtype = bloodtype;
            this.height = height;
            this.weight = weight;
        }

        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public string Bloodtype
        {
            get { return this.bloodtype; }
            set { this.bloodtype = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }


        public double Weight
        {
            get { return this.weight; } 
            set { this.weight = value; }
        }

    }
}
