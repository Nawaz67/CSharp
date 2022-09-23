using HospitalManagementBLL;
using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementPL
{
    public class PatientPL
    {
        public List<Patient> patient;
        public void AddPatient()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Patient Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Patient Id: ");
            int PatientId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Patient Name: ");
            string PatientName = Console.ReadLine();
            Console.Write("Patient Email: ");
            string PatientEmail = Console.ReadLine();
            Console.Write("Patient Password: ");
            string PatientPassword = Console.ReadLine();
            PatientBLL patientBLL = new PatientBLL();
            Patient patient = new Patient(PatientId,PatientName,PatientEmail,PatientPassword);
            bool flag = patientBLL.AddPatientBLL(patient);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Patient added successfully...");
                PatientSection();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }

            Console.Write(flag);


        }
       
        public void GetAllPatient()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------Patient-List-------------------------");
            Console.WriteLine("--Patient Id--------------Patient Name----------Patient Email-------------Patient Password--------");
            Console.ForegroundColor = ConsoleColor.White;
            PatientBLL patientBLL = new PatientBLL();
            List<Patient> patientBLLList = new List<Patient>();
            patientBLLList = patientBLL.GetAllPatientsBLL();
            foreach (var item in patientBLLList)
            {
                Console.WriteLine(item.PatientId + "\t \t " + item.PatientName + "\t \t" + item.PatientEmail + "\t  \t" + item.PatientPassword);

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            PatientSection();

        }
        public void RemovePatient()
        {
            PatientBLL patientBLL = new PatientBLL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Patient Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Patient Id: ");
            int PatientId = Convert.ToInt32(Console.ReadLine());

            Patient patient = new Patient();
            bool flag = patientBLL.RemovePatientsBLL(PatientId);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Patient deleted successfully...");
                PatientSection();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Deleted Successfully");
            Console.ForegroundColor = ConsoleColor.White;
            PatientSection();


        }
        public void UpdatePatient()
        {
            PatientBLL patientBLL = new PatientBLL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Patient Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Patient Id: ");
            int PatientId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Patient Name: ");
            string PatientName = Console.ReadLine();
            Console.Write("Patient Email ");
            string PatientEmail = Console.ReadLine();  
            Console.Write("Patient Password: ");
            string PatientPassword = Console.ReadLine();
            Patient patient = new Patient(PatientId, PatientName, PatientEmail, PatientPassword);
            bool flag = patientBLL.UpdatePatientsBLL(patient);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Patient updated successfully...");
                PatientSection();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Updated Successfully");
            Console.ForegroundColor = ConsoleColor.White;
            PatientSection();


        }
        public void PatientLogin()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Patient-Login------------ \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Patient Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Patient Password: ");
            string password = Console.ReadLine();
            PatientBLL patientBLL = new PatientBLL();
            bool status = patientBLL.PatientLoginBLL(email, password);
            if (status == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in Successfully... ");
                PatientMenu();
            }
            else
                Console.WriteLine("Invalid Credentials !");

        }

        public void PatientSection()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to-Patient-Section-------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to add a Patient");
            Console.WriteLine("2) Press 2 to update a Patient");
            Console.WriteLine("3) Press 3 to delete a Patient");
            Console.WriteLine("4) Press 4 to show all Patient");
            Console.Write("5) Press 5 to exit ");
            Console.WriteLine("logout", Console.ForegroundColor = ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.White;
            int patientmenu = Convert.ToInt32(Console.ReadLine());
            switch (patientmenu)
            {
                case 1:
                     PatientPL patientPL = new PatientPL();
                    patientPL.AddPatient();
                    break;
                case 2:
                    UpdatePatient();
                    break;
                case 3:
                    RemovePatient();
                    break;
                case 4:
                    GetAllPatient();
                    break;
                case 5:
                    Console.Read();
                    break;

            }


        }
        public void PatientMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to-Patient-Section-------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to view room");
            Console.WriteLine("2) Press 2 to book an appointment");
            Console.WriteLine("3) Press 3 to view an appointment");
            Console.WriteLine("4) Press 4 to view Bill details");
            Console.WriteLine("5) Press 5 to view prescription");
            Console.WriteLine("6) Press 6 to view history");
            Console.Write("7) Press 7 to ");
            Console.WriteLine("logout", Console.ForegroundColor = ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.White;
            int patientmenup = Convert.ToInt32(Console.ReadLine());
            switch (patientmenup)
            {
                case 5:
                    Console.Read();
                    break;

            }


        }
    }
}
