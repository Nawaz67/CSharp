using FoodManagementEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FoodManagementData
{
    public class FoodData
    {
        FoodDAL db = new FoodDAL();
        public string AddFood(FoodItem food)
        {
            db = new FoodDAL();
            db.foodItems.Add(food);
            db.SaveChanges();
            return "Added";
        }
        public string UpdateFood(FoodItem food)
        {
            db = new FoodDAL();
            db.Entry(food).State = EntityState.Modified;
            db.SaveChanges();
            return "Updated";
        }
        /*public string DeleteFood(int foodId)

        {
            
            FoodItem foodObj = db.foodItems.Find(foodId);
            db.Entry(foodObj).State = EntityState.Deleted;
            db.SaveChanges();
            return "Deleted";
        }*/
        public List<FoodItem> ShowAllFood()
        {
            db = new FoodDAL();
            List<FoodItem> foodList = db.foodItems.ToList();

           
            return foodList;
        }
        public List<FoodItem> SearchFoodByName(string foodName)
        {
            db = new FoodDAL();
            List<FoodItem> foodList = db.foodItems.ToList();

            //Linq query- select * from movie where movietype='type'
            var result = from foods in foodList
                         where foods.FoodName == foodName
                         orderby foods.FoodName
                         select new FoodItem
                         {
                             Id = foods.Id,
                             FoodName = foodName,
                             FoodPrice = foods.FoodPrice,
                            
                         };
            List<FoodItem> foodResult = new List<FoodItem>();
            foreach (var item in result) //linq query execution
            {
                foodResult.Add(item);
            }
            return foodResult;
        }

        public List<FoodItem> SearchFoodById(int id)
        {
            db = new FoodDAL();
            List<FoodItem> foodList = db.foodItems.ToList();

            //Linq query- select * from movie where movietype='type'
            var result = from foods in foodList
                         where foods.Id == id
                         orderby foods.FoodName
                         select new FoodItem
                         {
                             Id = id,
                             //Id = foods.Id,
                             FoodName = foods.FoodName,
                             FoodPrice = foods.FoodPrice,

                         };
            List<FoodItem> foodResult = new List<FoodItem>();
            foreach (var item in result) //linq query execution
            {
                foodResult.Add(item);
            }
            return foodResult;
        }

    }
}
