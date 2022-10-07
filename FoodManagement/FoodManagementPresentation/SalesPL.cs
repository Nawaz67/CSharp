using FoodManagementData;
using FoodManagementEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodManagementPresentation
{
    public class SalesPL
    {
        public void SalesMenuPL()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----Manage Sales Section------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to Add new sales"); ;
            Console.WriteLine("2) Press 2 to Update sales");
            Console.WriteLine("3) Press 3 to view sales details");
            Console.WriteLine("4) Press 4 to list of sales");
            Console.WriteLine("5) Press 5 to Admin section");
            int food = Convert.ToInt32(Console.ReadLine());
            switch (food)
            {
                case 1:
                    AddSalesPL();
                    break;
                case 2:
                    UpdateSalesPL();
                    break;
                case 3:
                    ShowAllSalesPL();
                    break;
                case 4:
                    ListAllSalesPL();
                    break;

                case 5:
                    AdminPL adminPL = new AdminPL();
                    adminPL.SubMenu();
                    break;
            }

        }
        public void AddSalesPL()
        {
            SalesData salesData = new SalesData();
            Sales sales = new Sales();
            Console.Write("Enter Sales Name: ");
            sales.SalesName = Console.ReadLine();
            Console.Write("Enter Food Id: "); ;
            sales.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Total Item: ");
            sales.TotalItem= Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Total Bill: ");
            //sales.TotalBill= Convert.ToDouble(Console.ReadLine());
            string msg = salesData.AddSales(sales);
            Console.WriteLine(msg);
            SalesMenuPL();
        }
        public void ShowAllSalesPL()
        {
            SalesData salesData = new SalesData();
            List<Sales> Sales = salesData.ShowAllSales();
            foreach (var item in Sales)
            {
                Console.WriteLine("Id: " + item.SalesId);
                Console.WriteLine("Name: " + item.SalesName);
                Console.WriteLine("FoodId: " + item.Id);
                Console.WriteLine("Total Item: " +item.TotalItem);
                Console.WriteLine("Total Bill: " +item.TotalBill);

            }
            SalesMenuPL();
        }

        public void UpdateSalesPL()
        {
            SalesData salesData = new SalesData();
            Sales sales = new Sales();
            Console.Write("Enter Sales Id: ");
            sales.SalesId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Sales Name: ");
            sales.SalesName = Console.ReadLine();
            Console.Write("Enter Food Id: "); ;
            sales.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Total Item: ");
            sales.TotalItem = Convert.ToInt32(Console.ReadLine());

            //sales.TotalBill = Convert.ToDouble(Console.ReadLine());
            string msg = salesData.UpdateSales(sales);
            Console.WriteLine(msg);
            SalesMenuPL();
        }
        public void ListAllSalesPL()
        {

            SalesData salesData = new SalesData();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----Sales Lists--------");
            Console.ForegroundColor = ConsoleColor.White;

            List<Sales> sales = salesData.ShowAllSales();
            Console.WriteLine("---Sales Id-----------Sales Name-----------Food Id----------Total Item--------Total Bill");
            foreach (var item in sales)
            {
                Console.WriteLine(item.SalesId + "\t\t " + item.SalesName + "\t\t" + item.Id+ "\t\t" + item.TotalItem+ "\t\t" + item.TotalBill );

            }
            SalesMenuPL();
        }
    }
}
