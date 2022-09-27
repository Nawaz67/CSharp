using HospitalManagementDAL;
using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBLL
{
    public class DoctorBLL
    {
        List<Doctor> dalDoctor = new List<Doctor>();
        public bool DoctorLoginBLL(string doctorEmail, string doctorPassword)
        {
            bool flag = false;

            DoctorDAL doctorDAL = new DoctorDAL();
            List<Doctor> doctors = doctorDAL.GetAllDoctorsDAL();

            foreach (Doctor item in doctors)
            {
                if (item.DoctorEmail == doctorEmail && item.DoctorPassword == doctorPassword)
                {
                    flag = true;
                    break;
                }


            }
            return flag;
        }
        public bool AddDoctorBLL(Doctor doctor)
        {
            DoctorDAL doctorDAL = new DoctorDAL();
            return doctorDAL.AddDoctorDAL(doctor);

        }
        List<Doctor> BookValidation()
        {
            return dalDoctor;

        }
        public List<Doctor> GetAllDoctorBLL()
        {
            DoctorDAL doctorDAL = new DoctorDAL();
            return doctorDAL.GetAllDoctorsDAL();

        }
        public bool RemoveDoctorBLL(int Doctor)
        {
            DoctorDAL doctorDAL = new DoctorDAL();
            return doctorDAL.RemoveDoctorsDAL(Doctor);

        }
        public bool UpdateDoctorBLL(Doctor doctor)
        {
            DoctorDAL doctorDAL = new DoctorDAL();
            return doctorDAL.UpdateDoctorsDAL(doctor);

        }
    }
}

