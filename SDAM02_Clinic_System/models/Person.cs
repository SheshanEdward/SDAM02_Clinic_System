using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class Person
    {
        private string NIC;
        private string firstname;
        private string lastname;
        private DateTime DoB;
        private string email;
        private string mobile;
        private string address;
        private string password;

        public Person(string NIC, string firstname, string lastname, DateTime DoB, string email, string mobile, string address, string password)
        {
            this.NIC = NIC;
            this.firstname = firstname;
            this.lastname = lastname;
            this.DoB = DoB;
            this.email = email;
            this.mobile = mobile;
            this.address = address;
            this.password = password;
        }

        public string nic
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

        public string Email
        {
            get{ return email;}
            set { email = value; }  
        }


        public string Mobile
        {
            get { return mobile;}
            set { mobile = value; }
        }

        public string Address
        {
            get { return address;}
            set { address = value; }
        }


        public string Password
        {
            get { return password;}
            set { password = value; }
        }
    }
}
