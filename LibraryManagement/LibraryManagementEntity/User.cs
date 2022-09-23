using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementEntity
{
    public class User
    {
        public User()
        {

        }
        public string UserEmail { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public User(string UserEmail, int UserId, string UserName, string UserPassword)
        {
            this.UserEmail = UserEmail;
            this.UserId = UserId;
            this.UserName = UserName;
            this.UserPassword = UserPassword;

        }
    }
}
