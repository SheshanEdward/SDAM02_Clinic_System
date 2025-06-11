using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class Admin : Person
    {
        private string gender;
        private string postalcode;

        public Admin(string NIC, string firstname, string lastname, DateTime DoB, string email, string mobile, string address, string password, string gender, string postalcode) : base(NIC, firstname, lastname, DoB, email, mobile, address, password)
        {
            this.gender = gender;
            this.postalcode = postalcode;
        }

        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public string Postalcode
        {
            get { return this.postalcode; }
            set { this.postalcode = value; }
        }
    }
}
