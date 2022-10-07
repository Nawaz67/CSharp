﻿using FoodManagementData;
using FoodManagementEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodManagementBusiness
{
    public class AdminBLL
    {
        public bool AdminLogin(string adminEmail, string adminPassword)
        {
            bool flag = false;

            AdminDAL adminDAL = new AdminDAL();
            List<Admin> admins = adminDAL.GetAllAdminsDAL();

            foreach (Admin item in admins)
            {
                if (item.AdminEmail == adminEmail && item.AdminPassword == adminPassword)
                {
                    flag = true;
                    break;
                }


            }
            return flag;
        }
    }
}