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

        // Optional: Notes added by admin or doctor (e.g., special instructions or cancellation reasons)
        public string Notes { get; set; }

        // Appointment status (Scheduled, Cancelled, Completed, etc.)
        public string Status { get; set; }

        public static class AppointmentStatuses
        {
            public const string Scheduled = "Scheduled";
            public const string Cancelled = "Cancelled";
            public const string Completed = "Completed";
            public const string NoShow = "No Show";
        }
    }
}
