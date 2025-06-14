﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class Appointment
    {
        private string AppointmentId;
        private string PatientId;
        private string DoctorId;
        private DateTime AppointmentDate;
        private DateTime AppointmentTime;
        public Appointment(string AppointmentId, string PatientId, string DoctorId, DateTime AppointmentDate, DateTime AppointmentTime)
        {
            this.AppointmentId = AppointmentId;
            this.PatientId = PatientId;
            this.DoctorId = DoctorId;
            this.AppointmentDate = AppointmentDate;
            this.AppointmentTime = AppointmentTime;
        }

        public string appointmentId
        {
            get { return AppointmentId; }
            set { AppointmentId = value; }
        }

        public string patientId
        {
            get { return PatientId; }
            set { PatientId = value; }
        }

        public string doctor_Id
        {
            get { return DoctorId; }
            set { DoctorId = value; }
        }

        public DateTime appointmentDate
        {
            get { return AppointmentDate; }
            set { AppointmentDate = value; }
        }

        public DateTime appointmentTime
        {
            get { return AppointmentTime; }
            set { AppointmentTime = value; }
        }
    }
}
