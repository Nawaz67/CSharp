using FoodManagementData;
using FoodManagementEntity;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;

namespace FoodManagementPresentation
{
    public class FoodMenuPL
    {
        //FoodMenuPL foodMenuPL = new FoodMenuPL();
        public void FoodMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----Manage Food Items Section------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to Add new food"); ;
            Console.WriteLine("2) Press 2 to Update food items");
            Console.WriteLine("3) Press 3 to view food item details");
            Console.WriteLine("4) Press 4 to list of food items");
            Console.WriteLine("5) Press 5 to Admin section");
            int food=Convert.ToInt32(Console.ReadLine());
            switch(food)
            {
                case 1:
                    AddFoodPL();
                    break;
                case 2:
                    UpdateFoodPL();
                    break;
                case 3:
                    ShowAllFoodPL();
                    break;
                case 4:
                    ListAllPL();
                    break;
                case 5:
                    AdminPL adminPL = new AdminPL();
                    adminPL.SubMenu();
                    break;
            }

        }
        public void AddFoodPL()
        {
            FoodData foodData = new FoodData();
            FoodItem food = new FoodItem();
            Console.Write("Enter Food Name: ");
            food.FoodName = Console.ReadLine();
            Console.Write("Enter Food Price: "); ;
            food.FoodPrice = Convert.ToDouble( Console.ReadLine());
            string msg = foodData.AddFood(food);
            Console.WriteLine(msg);
            FoodMenu();
        }
        public void ShowAllFoodPL()
        {
            FoodData foodData = new FoodData();
            List<FoodItem> foodItems = foodData.ShowAllFood();
            foreach (var item in foodItems)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Name: " + item.FoodName);
                Console.WriteLine("Price: " + item.FoodPrice);
            }
            FoodMenu();
        }
       /* public void DeleteFoodPL()
        {
            
            Console.Write("Enter Food Id: ");
            int foodId = Convert.ToInt32(Console.ReadLine());
            FoodData foodData = new FoodData();
            string msg = foodData.DeleteFood(foodId);
            Console.WriteLine(msg);
            FoodMenu();

        }*/
        public void UpdateFoodPL()
        {
            FoodData foodData = new FoodData();
            FoodItem food = new FoodItem();
            Console.Write("Enter Food Id: ");
            food.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Food Name: ");
            food.FoodName = Console.ReadLine();
            Console.Write("Enter Food Price: "); ;
            food.FoodPrice = Convert.ToDouble(Console.ReadLine());
            string msg = foodData.UpdateFood(food);
            Console.WriteLine(msg);
            FoodMenu();
        }
        public void ListAllPL()
        {

            FoodData foodData = new FoodData();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----Food Lists--------");
            Console.ForegroundColor = ConsoleColor.White;
  
            List<FoodItem> food = foodData.ShowAllFood();
            Console.WriteLine("---Food Id-------------Food Name---------------Food Price");
            foreach (var item in food)
            {
                Console.WriteLine( item.Id+ "\t\t " +item.FoodName+ "\t\t" +item.FoodPrice);
                
            }
            FoodMenu(); 
        }



    }
}
