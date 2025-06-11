using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class Person
    {
        private int NIC;
        private string fristname;
        private string lastname;
        private DateTime DoB;
        private string address;

        public Person(int NIC, string firstname, string lastname, DateTime DoB, string address)
        {
            this.NIC = NIC;
            this.fristname = firstname;
            this.lastname = lastname;
            this.DoB = DoB;
            this.address = address;
        }


    }
}
