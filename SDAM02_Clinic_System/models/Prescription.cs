using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM02_Clinic_System.models
{
    class Prescription
    {
        private string prescriptionId;
        private string patientId;
        private string medication;
        private DateTime date;

        public Prescription(string prescriptionId, string patientId, string medication, DateTime date)
        {
            this.prescriptionId = prescriptionId;
            this.patientId = patientId;
            this.medication = medication;
            this.date = date;
        }


        public string PrescriptionId
        {
            get { return prescriptionId; }
            set { prescriptionId = value; }
        }

        public string PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }


        public string Medication
        {
            get { return medication; }
            set { medication = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
