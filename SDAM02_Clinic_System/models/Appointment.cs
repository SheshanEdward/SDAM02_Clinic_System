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

        // Optional notes from doctor/admin
        public string Notes { get; set; }

        // Status: Scheduled, Cancelled, etc.
        public string Status { get; set; }

        public static class AppointmentStatuses
        {
            public const string Scheduled = "Scheduled";
            public const string Cancelled = "Cancelled";
            public const string Completed = "Completed";
            public const string NoShow = "No Show";
        }

        public override string ToString()
        {
            return $"[ID: {AppointmentId}] {AppointmentDate:dd MMM yyyy hh:mm tt} - Patient: {PatientId}, Doctor: {DoctorId}, Status: {Status}";
        }
    }
}
