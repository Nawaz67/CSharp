using LibraryManagementData;
using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBusiness
{

    public class UserBLL
    {
        public void AcceptRequestBLL()
        {

        }
        public bool AddUserBLL(User user)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.AddUsersDAL(user);

        }
        public void DeleteRecievedBLL()
        {

        }
        public List<User> GetAllUsersBLL()
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.GetAllUserDetails();  

        }
        public void GetRecievedBookBLL()
        {

        }
        public void GetRequestedBookBLL()
        {

        }
        public void GetUserIdBLL()
        {

        }
        public bool RemoveUsersBLL(int user)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.RemoveUsersDAL(user);

        }
        public void RequestBookBLL()
        {

        }
        public bool UpdateUsersBLL(User user)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.UpdateUsersDAL(user);

        }
        public bool UserLogin(string userEmail, string userPassword)
        {
            
            UserDAL userDAL = new UserDAL();
            List<User> users = userDAL.GetAllUserDetails();

            foreach (var item in users)
            {
                if (item.UserEmail == userEmail && item.UserPassword == userPassword)
                {
                    return true;
                }

            }
            return true;

        }
        public void UserValidation()
        {

        }



    }
}


