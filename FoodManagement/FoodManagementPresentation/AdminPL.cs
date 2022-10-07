using FoodManagementBusiness;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodManagementPresentation
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
            Console.WriteLine("1) Press 1 to Manage Food Items");
            Console.WriteLine("2) Press 2 to Manage Food Category");
            Console.WriteLine("3) Press 3 to Manage Sales");
            Console.WriteLine("4) Press 4 to show Reports section");
            Console.Write("5) Press 5 to ");
            Console.WriteLine("logout", Console.ForegroundColor = ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.White;
            int bookmenu = Convert.ToInt32(Console.ReadLine());
            switch (bookmenu)
            {
                case 1:
                    FoodMenuPL foodMenu=new FoodMenuPL();
                    foodMenu.FoodMenu();    
                    break;
                case 2:
                    CategoryMenu categoryMenu=new CategoryMenu();
                    categoryMenu.CategoryMenuPL();
                    break;
                case 3:
                    SalesPL salesPL=new SalesPL();
                    salesPL.SalesMenuPL();
                    break;
                case 4:
                    ReportPL reportPL=new ReportPL();
                    reportPL.ReportMenuPL();
                    break;
                case 5:
                    Console.ReadLine();
                    break;

            }


        }
    }
}
