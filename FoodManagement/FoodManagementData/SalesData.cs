using FoodManagementEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodManagementData
{
    public class SalesData
    {
        FoodDAL db = new FoodDAL();
        public string AddSales(Sales sales)
        {
            db = new FoodDAL();
            FoodData foodData = new FoodData();
            List<FoodItem> foodItems = foodData.ShowAllFood();
            db.Sales.Add(sales);
            var result=from obj in foodItems
                       where obj.Id == sales.Id
                       select obj.FoodPrice*sales.TotalItem;
            double total = 0;   
            foreach (var item in result)
            {
                total = item;
            }
            sales.TotalBill=total;
            db.SaveChanges();
            return "Added";
        }
        public string UpdateSales(Sales sales)
        {
            db = new FoodDAL();
            FoodData foodData = new FoodData();
            List<FoodItem> foodItems = foodData.ShowAllFood();
            db.Entry(sales).State = EntityState.Modified;
            var result1 = from obj in foodItems
                         where obj.Id == sales.Id
                         select obj.FoodPrice * sales.TotalItem;
            double total = 0;
            foreach (var item in result1)
            {
                total = item;
            }
            sales.TotalBill = total;
            db.SaveChanges();
            return "Updated";
        }
        public string DeleteSales(int salesId)

        {
            
            Sales salesObj = db.Sales.Find(salesId);
            db.Entry(salesObj).State = EntityState.Deleted;
            db.SaveChanges();
            return "Deleted";
        }
        public List<Sales> ShowAllSales()
        {
            db = new FoodDAL();
            List<Sales> salesList = db.Sales.ToList();
            return salesList;
        }
    }
}
