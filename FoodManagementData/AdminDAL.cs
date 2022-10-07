using FoodManagementEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodManagementData
{
    public class AdminDAL
    {
        public List<Admin> admins;


        public List<Admin> GetAllAdminsDAL()
        {
            admins = new List<Admin>();
            Admin adminObj = new Admin(111, "Nawaz", "nawaz@gmail.com", "nawaz123");
            admins.Add(adminObj);

            adminObj = new Admin(222, "Prabhu", "prabhu@gmail.com", "prabhu123");
            admins.Add(adminObj);

            return admins;
        }
    }
}
