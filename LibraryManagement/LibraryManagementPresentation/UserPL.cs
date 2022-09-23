using LibraryManagementBusiness;
using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementPresentation
{
    public class UserPL
    {
        public List<User> user;
        public void AddUser()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter User Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("User Id: ");
            int UserId = Convert.ToInt32(Console.ReadLine());
            Console.Write("User Name: ");
            string UserName = Console.ReadLine();
            Console.Write("User Email: ");
            string UserEmail = Console.ReadLine();
            Console.Write("User Password: ");
            string UserPassword = Console.ReadLine();
            UserBLL userBLL = new UserBLL();
            User user = new User(UserEmail,UserId,UserName,UserPassword);
            bool flag = userBLL.AddUserBLL(user); 
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("User added successfully...");
                UserSection();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }

            Console.Write(flag);


        }
        void DeleteRecieve()
        {

        }
        public void GetAllUser()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------User-List-------------------------");
            Console.WriteLine("--User Email--------------User Id----------User Name-------------User Password--------");
            Console.ForegroundColor = ConsoleColor.White;
            UserBLL userBLL = new UserBLL();
            List<User> userBLLList = new List<User>();
            userBLLList = userBLL.GetAllUsersBLL();  
            foreach (var item in userBLLList)
            {
                Console.WriteLine(item.UserEmail + "\t " + item.UserId + "\t" + item.UserName + "\t  " + item.UserPassword);

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            UserSection();

        }       
        public void GetRecievedBook()
        {

        }
        public void GetRequestBook()
        {

        }
        void GetUserHomeMenu()
        {


        }
        void GetUserMenu()
        {

        }
        void GetUserRecievedBook()
        {

        }
        void GetUserRequestBook()
        {

        }
        void RecieveSection()
        {

        }
        public void RemoveUser()
        {
            UserBLL userBLL = new UserBLL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter User Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("User Id: ");
            int User = Convert.ToInt32(Console.ReadLine());

            User user = new User();
            bool flag = userBLL.RemoveUsersBLL(User);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Book deleted successfully...");
                UserSection();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Deleted Successfully");
            Console.ForegroundColor = ConsoleColor.White;
            UserSection();


        }
        void RequestBook()
        {

        }
        void RequestSection()
        {

        }
        public void UpdateUser()
        {
            UserBLL userBLL = new UserBLL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter User Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("User Id: ");
            int UserId = Convert.ToInt32(Console.ReadLine());
            Console.Write("User Name: ");
            string UserName = Console.ReadLine();
            Console.Write("User Email ");
            string UserEmail = Console.ReadLine();  //string UserEmail, int UserId, string UserName, string UserPassword
            Console.Write("User Password: ");
            string UserPassword = Console.ReadLine();
            User user = new User(UserEmail, UserId, UserName, UserPassword);
            bool flag = userBLL.UpdateUsersBLL(user);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("User updated successfully...");
                UserSection();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Updated Successfully");
            Console.ForegroundColor = ConsoleColor.White;
            UserSection();


        }
        void UserHomeSection()
        {

        }
        public void UserLogin()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("User-Login------------ \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter User Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter User Password: ");
            string password = Console.ReadLine();
            UserBLL userBLL = new UserBLL();
            bool status = userBLL.UserLogin(email, password);
            if (status == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in Successfully... ");
                UserSection();
            }
            else
                Console.WriteLine("Invalid Credentials !");

        }

        public void UserSection()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to-User-Section-------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Press 1 to add a user");
            Console.WriteLine("2) Press 2 to update a user");
            Console.WriteLine("3) Press 3 to delete a user");
            Console.WriteLine("4) Press 4 to show all user");
            Console.Write("5) Press 5 to exit ");
            Console.WriteLine("logout", Console.ForegroundColor = ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.White;
            int usermenu = Convert.ToInt32(Console.ReadLine());
            switch (usermenu)
            {
                case 1:
                    UserPL userPL = new UserPL();
                    userPL.AddUser();
                    break;
                case 2:
                    UpdateUser();
                    break;
                case 3:
                    RemoveUser();
                    break;
                case 4:
                    GetAllUser();
                    break;
                case 5:
                    Console.Read();
                    break;

            }


        }
    }
}




