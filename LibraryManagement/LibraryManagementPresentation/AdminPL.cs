using LibraryManagementBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementPresentation
{
    public class AdminPL
    {
        public void Login()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Admin-Login------------ \n");
            Console.ForegroundColor= ConsoleColor.White;
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
          
        }

        public void SubMenu()
        {
            Console.ForegroundColor=ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to-Admin-Section-------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to show book section");
            Console.WriteLine("2) Press 2 to show user section");
            Console.WriteLine("3) Press 3 to show request section");
            Console.WriteLine("4) Press 4 to show accepted section");
            Console.Write("5) Press 5 to ");
            Console.WriteLine("logout", Console.ForegroundColor = ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.White;
            int bookmenu=Convert.ToInt32( Console.ReadLine());
            switch(bookmenu)
            {
                case 1:
                    BookPL bookPL = new BookPL();
                    bookPL.BookDetails();
                    break;
                case 2:
                    UserPL userPL = new UserPL();
                    userPL.UserSection();
                    break;

            }
            

        }
    }
}
