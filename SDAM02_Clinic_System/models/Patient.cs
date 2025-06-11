using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class Patient : Person
    {
        private string patient_id;
        private string gender;
        private string bloodtype;
        private double height;
        private double weight;


        public Patient(string patient_id, string gender, string bloodtype, double height, double weight) : base(NIC, firstname, lastname, DoB, address)
        {
            this.patient_id = patient_id;
            this.gender = gender;
            this.bloodtype = bloodtype;
            this.height = height;
            this.weight = weight;
        }
    }
}
