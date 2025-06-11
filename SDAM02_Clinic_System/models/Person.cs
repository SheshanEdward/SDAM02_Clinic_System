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
        private string firstname;
        private string lastname;
        private DateTime DoB;
        private string address;

        public Person(int NIC, string firstname, string lastname, DateTime DoB, string address)
        {
            this.NIC = NIC;
            this.firstname = firstname;
            this.lastname = lastname;
            this.DoB = DoB;
            this.address = address;
        }

        public int nic
        {
            get { return NIC; }
            set { NIC = value; }
        }



        public string Firstname
        {
            get { return firstname;}
            set { firstname = value; }
        }


        public string Lastname
        {
            get { return lastname;}
            set { lastname = value;}
        }

        public DateTime dob
        {
            get { return DoB; }
            set {  DoB = value; }
        }

        public string Address
        {
            get { return address;}
            set { address = value; }
        }
    }
}
