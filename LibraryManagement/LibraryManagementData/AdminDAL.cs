using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementData
{
    public class AdminDAL
    {

       public List<Admin> admins;


        public List<Admin> GetAllAdminsDAL()
        {
            admins = new List<Admin>();
            Admin adminObj = new Admin("nawaz@gmail.com",11,"Nawaz","nawaz123");
            admins.Add(adminObj);

            adminObj = new Admin("sharieff@gmail.com",12,"sharieff","sharieff123");
            admins.Add (adminObj);

            adminObj = new Admin("prabhu@gmail.com", 13, "Prabhu", "prabhu123");
            admins.Add(adminObj);

            return admins;
        }
    }
}
