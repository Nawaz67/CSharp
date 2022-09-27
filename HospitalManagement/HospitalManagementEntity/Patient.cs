using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementEntity
{
    public class Patient
    {
        public Patient()
        {

        }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientEmail { get; set; }
        public string PatientPassword { get; set; }
        public string PatientType { get; set; } 

        public Patient(int PatientId, string PatientName, string PatientEmail, string PatientPassword, string PatientType)
        {
            this.PatientId = PatientId;
            this.PatientName = PatientName;
            this.PatientEmail = PatientEmail;
            this.PatientPassword = PatientPassword;
            this.PatientType = PatientType;
        }
    }
}
