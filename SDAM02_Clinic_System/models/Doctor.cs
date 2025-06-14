using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class Doctor : Person
    {
        private string specialization;
        private string slmcregno;
        private string availabledays;
        private TimeSpan startTime;
        private TimeSpan endTime;


        public Doctor(string NIC, string firstname, string lastname, DateTime DoB, string email, string mobile, string address, string password, string slmcregno, string specialization) : base(NIC, firstname, lastname, DoB, email, mobile, address, password)
        {
            this.specialization = specialization;
            this.slmcregno = slmcregno;
            //this.availabledays = availabledays;
            //this.startTime = endTime;

        }


        public string Specialization
        {
            get { return this.specialization; }
            set { this.specialization = value; }
        }

        public string Slmcregno
        {
            get { return this.slmcregno; }
            set { this.slmcregno = value; }
        }

        public string AvailableDays
        {
            get { return this.availabledays; }
            set { this.availabledays = value; }
        }

        public TimeSpan StartTime
        {
            get { return this.startTime; }
            set { this.startTime = value; }
        }

        public TimeSpan EndTime
        {
            get { return this.endTime; }
            set { this.endTime = value; }
        }

    }
}
