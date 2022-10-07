using FoodManagementData;
using FoodManagementData.Migrations;
using FoodManagementEntity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FoodManagementPresentation
{
    public class ReportPL
    {
        public void ReportMenuPL()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----Report Section------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to view report of all food items"); ;
            Console.WriteLine("2) Press 2 to view report of all food category");
            Console.WriteLine("3) Press 3 to view report of all sales");
            Console.WriteLine("4) Press 4 to Admin section");
            int food = Convert.ToInt32(Console.ReadLine());
            switch (food)
            {
                case 1:
                    ReportFoodPL();
                    break;
                case 2:
                    ReportCategoryPL();
                    break;
                case 3:
                    ReportSales();
                    break;
                case 4:
                    AdminPL adminPL = new AdminPL();
                    adminPL.SubMenu();
                    break;
            }

        }
        public void ReportFoodPL()
        {
            FoodDAL db = new FoodDAL();
            List<FoodItem> foodItems = db.foodItems.ToList();
            string json = JsonConvert.SerializeObject(foodItems);
            File.WriteAllText("FoodItem.json", json);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<FoodItem>));
            FileStream fileStream = new FileStream("FoodItem.xml", FileMode.Create);
            xmlSerializer.Serialize(fileStream, foodItems);
            fileStream.Close();


            ReportMenuPL();
            
        }
        public void ReportCategoryPL()
        {
            FoodDAL db = new FoodDAL();
            List<FoodCategory> foodCategories1 = db.FoodCategory.ToList();
            string json = JsonConvert.SerializeObject(foodCategories1);
            File.WriteAllText("FoodCategory.json", json);


            
            //List<FoodCategory> foodCategories1 = new List<FoodCategory>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<FoodCategory>));
            FileStream fileStream = new FileStream("FoodCategory.xml", FileMode.Create);
            xmlSerializer.Serialize(fileStream, foodCategories1);
            fileStream.Close();

            ReportMenuPL();
            //var reader = new StreamReader("FoodCategory.xml");
            //var result = (List<FoodCategory>)xmlSerializer.Deserialize(reader);

        }
        public void ReportSales()
        {
            FoodDAL db = new FoodDAL();
            List<Sales> salesLists = db.Sales.ToList();
            string json = JsonConvert.SerializeObject(salesLists);
            File.WriteAllText("SalesReport.json", json);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Sales>));
            FileStream fileStream = new FileStream("Sales.xml", FileMode.Create);
            xmlSerializer.Serialize(fileStream, salesLists);
            fileStream.Close();


            ReportMenuPL();

        }
    }
}
