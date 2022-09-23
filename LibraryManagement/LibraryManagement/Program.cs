using LibraryManagementEntity;
using LibraryManagementPresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
           /* //Reflection
            Type type = typeof(Book);
            var members=type.GetMembers();
            var methods=type.GetMethods();
            var propInfo=type.GetProperties();
            var obj = Activator.CreateInstance(type);
            var t = "";*/
           

            AdminPL adminPL = new AdminPL();
            UserPL userPL=new UserPL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Welcome to Valtech_ Library ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to Login as Admin");
            Console.WriteLine("2) Press 2 to Login as User");
            Console.WriteLine("3) Press 3 to Exit");
            var details=Convert.ToInt32(Console.ReadLine());
            switch (details)
            {
                case 1:
                    adminPL.Login();
                    break;
                case 2:
                    userPL.UserLogin();
                    break;
                case 3:
                    Console.Read();
                    break;
                
            }
           // adminPL.AdminLogin();
            Console.Read();
        }
    }
}
