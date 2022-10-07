using FoodManagementData;
using FoodManagementEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodManagementPresentation
{
    public class CategoryMenu
    {
        public void CategoryMenuPL()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----Manage Food Category Section------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to Add new food category"); ;
            Console.WriteLine("2) Press 2 to Update food category");
            Console.WriteLine("3) Press 3 to view food category details");
            Console.WriteLine("4) Press 4 to list of food categories");
            Console.WriteLine("5) Press 5 to Admin section");
            int food = Convert.ToInt32(Console.ReadLine());
            switch (food)
            {
                case 1:
                    AddCategoryPL();
                    break;
                case 2:
                    UpdateCategoryPL();
                    break;
                case 3: 
                    ShowAllCategoryPL();
                    break;
                case 4:
                    ListAllCategoryPL();
                    break;
                case 5:
                    AdminPL adminPL = new AdminPL();
                    adminPL.SubMenu();
                    break;
            }
        }
            public void AddCategoryPL()
            {
                CategoryData categoryData = new CategoryData();
                FoodCategory foodCategory = new FoodCategory();
                Console.Write("Enter Category Name: ");
                foodCategory.CategoryName = Console.ReadLine();
                Console.Write("Enter Food Id: "); ;
                foodCategory.Id = Convert.ToInt32( Console.ReadLine());
                string msg = categoryData.AddFoodCategory(foodCategory);
                Console.WriteLine(msg);
            CategoryMenuPL();
            }
            public void ShowAllCategoryPL()
            {
            CategoryData categoryData = new CategoryData();
            List<FoodCategory> foodCategories = categoryData.ShowAllCategory();
                foreach (var item in foodCategories)
                {
                    Console.WriteLine("Id: " + item.CategoryId);
                    Console.WriteLine("Name: " + item.CategoryName);
                    Console.WriteLine("FoodId: " + item.Id);
               
                }
            CategoryMenuPL();
            }
            public void UpdateCategoryPL()
            {
                CategoryData categoryData = new CategoryData();
                FoodCategory foodCategory = new FoodCategory();
                Console.Write("Enter Category Id: ");
                foodCategory.CategoryId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Category Name: ");
                foodCategory.CategoryName = Console.ReadLine();
                Console.Write("Enter Food Id: "); ;
                foodCategory.Id = Convert.ToInt32( Console.ReadLine());
         
                string msg = categoryData.UpdateFoodCategory(foodCategory);
                Console.WriteLine(msg);
            CategoryMenuPL();
            }
        public void ListAllCategoryPL()
        {

            CategoryData categoryData = new CategoryData();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----Food Category Lists--------");
            Console.ForegroundColor = ConsoleColor.White;

            List<FoodCategory> foodCategories = categoryData.ShowAllCategory();
            Console.WriteLine("---Category Id------------Category Name-------------Food Id");
            foreach (var item in foodCategories)
            {
                Console.WriteLine(item.CategoryId + "\t\t " + item.CategoryName + "\t\t" + item.Id);

            }
            CategoryMenuPL();
        }

    }
    }

