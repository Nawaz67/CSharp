using FoodManagementEntity;
using Microsoft.EntityFrameworkCore;
using System;

namespace FoodManagementData
{
    public class FoodDAL:DbContext
    {
        public DbSet<FoodItem> foodItems { get; set; }
        public DbSet<FoodCategory> FoodCategory { get; set; }
        public DbSet<Sales> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2106; Initial Catalog=Food_Management_d; Integrated Security=true;");
        }

    }
}
