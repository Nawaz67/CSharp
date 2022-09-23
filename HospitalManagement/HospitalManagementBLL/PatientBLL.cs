using HospitalManagementDAL;
using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBLL
{
    public class PatientBLL
    {
        public bool PatientLoginBLL(string patientEmail, string patientPassword)
        {
            bool flag = false;

            PatientDAL patientDAL = new PatientDAL();
            List<Patient> patients = patientDAL.GetAllPatientDetails();

            foreach (Patient item in patients)
            {
                if (item.PatientEmail == patientEmail && item.PatientPassword == patientPassword)
                {
                    flag = true;
                    break;
                }


            }
            return flag;
        }

        public bool AddPatientBLL(Patient patient)
        {
            PatientDAL patientDAL = new PatientDAL();
            return patientDAL.AddPatientsDAL(patient);

        }
        public List<Patient> GetAllPatientsBLL()
        {
            PatientDAL patientDAL = new PatientDAL();
            return patientDAL.GetAllPatientDetails();

        }
        public bool RemovePatientsBLL(int patient)
        {
            PatientDAL patientDAL = new PatientDAL();
            return patientDAL.RemovePatientsDAL(patient);

        }
        public bool UpdatePatientsBLL(Patient patient)
        {
            PatientDAL patientDAL = new PatientDAL();
            return patientDAL.UpdatePatientsDAL(patient);

        }
        /*public bool PatientLogin(string patientEmail, string patientPassword)
        {

            PatientDAL patientDAL = new PatientDAL();
            List<Patient> patients = patientDAL.GetAllPatientDetails();

            foreach (var item in patients)
            {
                if (item.PatientEmail == patientEmail && item.PatientPassword == patientPassword)
                {
                    return true;
                }

            }
            return true;

        }*/
    }
}
