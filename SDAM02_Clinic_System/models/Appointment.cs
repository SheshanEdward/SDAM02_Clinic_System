using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    internal class Appointment
    {
        public string AppointmentId { get; set; }
        public string PatientId { get; set; }
        public string DoctorId { get; set; }
        public int ServiceId { get; set; }
        public DateTime AppointmentDate { get; set; }

        // Booked, scheduled, cancelled 
        public string Status { get; set; } 
    }
}
