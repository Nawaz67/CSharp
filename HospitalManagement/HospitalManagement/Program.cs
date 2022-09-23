using HospitalManagementPL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            AdminPL adminPL = new AdminPL();
            PatientPL patientPL = new PatientPL();
            DoctorPL doctorPL = new DoctorPL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Welcome to Hospital Management System ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to Login as Admin");
            Console.WriteLine("2) Press 2 to Login as Patient");
            Console.WriteLine("3) Press 3 to Login as Doctor");
            Console.WriteLine("4) Press 4 to Exit");
            var details = Convert.ToInt32(Console.ReadLine());
            switch (details)
            {
                case 1:
                    adminPL.Login();
                    break;
                case 2:
                    patientPL.PatientLogin();
                    break;
                case 3:
                    doctorPL.DoctorLogin();
                    break;
                case 4:
                    Console.Read();
                    break;

            }
            // adminPL.AdminLogin();
            Console.Read();
        }
    }
}
