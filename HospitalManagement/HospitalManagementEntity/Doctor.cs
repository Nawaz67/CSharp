using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementEntity
{
    public class Doctor
    {
        public Doctor()
        {

        }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorPassword { get; set; }

        public Doctor(int DoctorId, string DoctorName, string DoctorEmail, string DoctorPassword)
        {
            this.DoctorId = DoctorId;
            this.DoctorName = DoctorName;
            this.DoctorEmail = DoctorEmail;
            this.DoctorPassword = DoctorPassword;

        }
    }
}
