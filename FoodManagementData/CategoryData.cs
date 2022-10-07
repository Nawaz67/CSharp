using FoodManagementEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodManagementData
{
    public class CategoryData
    {
        FoodDAL db = new FoodDAL();
        public string AddFoodCategory(FoodCategory category)
        {
            db = new FoodDAL();
            db.FoodCategory.Add(category);
            db.SaveChanges();
            return "Added";
        }
        public string UpdateFoodCategory(FoodCategory category)
        {
            db = new FoodDAL();
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
            return "Updated";
        }
        public string DeleteFoodCategory(int categoryId)

        {
            
            FoodCategory foodObj = db.FoodCategory.Find(categoryId);
            db.Entry(foodObj).State = EntityState.Deleted;
            db.SaveChanges();
            return "Deleted";
        }
        public List<FoodCategory> ShowAllCategory()
        {
            db = new FoodDAL();
            List<FoodCategory> foodList = db.FoodCategory.ToList();
            return foodList;
        }
    }
}
