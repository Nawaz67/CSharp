using HospitalManagementBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementPL
{
    public class AdminPL
    {
        public void Login()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Admin-Login------------ \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Admin Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Admin Password: ");
            string password = Console.ReadLine();
            AdminBLL adminBLL = new AdminBLL();
            bool status = adminBLL.AdminLogin(email, password);
            if (status == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in Successfully... ");
                SubMenu();
            }
            else
                Console.WriteLine("Invalid Credentials !");
           // Login();

        }

        public void SubMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to-Admin-Section-------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to show Doctor section");
            Console.WriteLine("2) Press 2 to show Patient section");
            Console.WriteLine("3) Press 3 to show Bill section");
            Console.WriteLine("4) Press 4 to show Appointment section");
            Console.WriteLine("5) Press 5 to show Room section");
            Console.Write("6) Press 6 to ");
            Console.WriteLine("logout", Console.ForegroundColor = ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.White;
            int bookmenu = Convert.ToInt32(Console.ReadLine());
            switch (bookmenu)
            {
                case 1:
                    DoctorPL doctorPL = new DoctorPL();
                    doctorPL.DoctorDetails();
                    break;
                case 2:
                    PatientPL patientPL = new PatientPL();
                    patientPL.PatientSection();
                    break;
                case 5:
                    RoomPL roompl=new RoomPL();
                    roompl.AddRoom();
                    break;
                case 6:
                    Console.ReadLine();
                    break;

            }


        }
    }
}
