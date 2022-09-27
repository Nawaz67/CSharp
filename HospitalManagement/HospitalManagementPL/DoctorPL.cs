using HospitalManagementBLL;
using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementPL
{
    public class DoctorPL
    {
        public void DoctorDetails()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Welcome-to-Doctor-Section--------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1) Press 1 to add a Doctor \n");
            Console.Write("2) Press 2 to update a Doctor \n");
            Console.Write("3) Press 3 to delete a Doctor \n");
            Console.Write("4) Press 4 to show all Doctor \n");
            Console.Write("5) Press 5 to exit \n");
            int dc = Convert.ToInt32(Console.ReadLine());
            switch (dc)
            {
                case 1:
                    AddDoctorPL();
                    break;
                case 2:
                    UpdateDoctorPL();
                    break;
                case 3:
                    RemoveDoctorPL();
                    break;
                case 4:
                    ShowDoctorPL();
                    break;
                case 5:
                    Console.Read();
                    break;
            }

        }
        public void AddDoctorPL()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Doctor Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Doctor Id: ");
            int DoctorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Doctor Name: ");
            string DoctorName = Console.ReadLine();
            Console.Write("Doctor Email: ");
            string DoctorEmail = Console.ReadLine();
            Console.Write("Doctor Password: ");
            string DoctorPassword = Console.ReadLine();
            DoctorBLL doctorBLL = new DoctorBLL();
            Doctor doctor = new Doctor(DoctorId, DoctorName, DoctorEmail, DoctorPassword);
            bool flag = doctorBLL.AddDoctorBLL(doctor);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Doctor added successfully...");
                DoctorDetails();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }

            Console.Write(flag);

        }
        public void UpdateDoctorPL()
        {

            DoctorBLL doctorBLL = new DoctorBLL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Doctor Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Doctor Id: ");
            int DoctorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Doctor Name: ");
            string DoctorName = Console.ReadLine();
            Console.Write("Doctor Email: ");
            string DoctorEmail = Console.ReadLine();
            Console.Write("Doctor Password: ");
            string DoctorPassword = Console.ReadLine();
            Doctor doctor = new Doctor(DoctorId, DoctorName, DoctorEmail, DoctorPassword);
            bool flag = doctorBLL.UpdateDoctorBLL(doctor);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Doctor updated successfully...");
                DoctorDetails();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Updated Successfully");
            Console.ForegroundColor = ConsoleColor.White;
            DoctorDetails();


        }
        public void RemoveDoctorPL()
        {
            DoctorBLL doctorBLL = new DoctorBLL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Book Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Doctor Id: ");
            int DoctorId = Convert.ToInt32(Console.ReadLine());

            Doctor doctor = new Doctor();
            bool flag = doctorBLL.RemoveDoctorBLL(DoctorId);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Book deleted successfully...");
                DoctorDetails();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Deleted Successfully");
            Console.ForegroundColor = ConsoleColor.White;
            DoctorDetails();

        }

        public void ShowDoctorPL()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------Doctor-List-------------------------");
            Console.WriteLine("--DoctorId----------DoctorName-------------DoctorEmail---------------------DoctorPassword--------");
            Console.ForegroundColor = ConsoleColor.White;
            DoctorBLL doctorBLL = new DoctorBLL();
            List<Doctor> doctorBLLList = new List<Doctor>();
            doctorBLLList = doctorBLL.GetAllDoctorBLL();
            foreach (var item in doctorBLLList)
            {
                Console.WriteLine(item.DoctorId + "\t \t" + item.DoctorName + "\t \t \t" + item.DoctorEmail + "\t \t \t" + item.DoctorPassword);

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            DoctorDetails();

        }
        public void DoctorLogin()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Doctor-Login------------ \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Doctor Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Doctor Password: ");
            string password = Console.ReadLine();
            DoctorBLL doctorBLL = new DoctorBLL();
            bool status = doctorBLL.DoctorLoginBLL(email, password);
            if (status == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in Successfully... ");
                DoctorMenu();
            }
            else
                Console.WriteLine("Invalid Credentials !");
            //DoctorLogin();
        }
        public void DoctorMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to-Doctor-Section-------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to view patient details");
            Console.WriteLine("2) Press 2 to view an appointment details");
            Console.Write("3) Press 3 to ");
            Console.WriteLine("logout", Console.ForegroundColor = ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.White;
            int doctormenu = Convert.ToInt32(Console.ReadLine());
            switch (doctormenu)
            {
                case 3:
                    Console.Read();
                    break;

            }
        }
    }
}
