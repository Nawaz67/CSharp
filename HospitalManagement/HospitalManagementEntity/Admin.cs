using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementEntity
{
    public class Admin
    {
        public string AdminEmail { get; set; }
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }

        public Admin(int AdminId, string AdminName, string AdminEmail, string AdminPassword)
        {
            this.AdminId = AdminId;
            this.AdminEmail = AdminEmail;
            this.AdminName = AdminName;
            this.AdminPassword = AdminPassword;

        }
    }
}
