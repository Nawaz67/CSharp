using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementData
{
    public class UserDAL
    {
        public static string sqlcon = "Data Source=VDC01LTC2106; Initial Catalog=LibraryManagement;Integrated Security=True";
        public List<RecievedBook> recievedBooks;
        public List<RequestedBook> requestedBooks;
        public List<User> Users;

        public List<RecievedBook> AcceptRequestDAL()
        {
            return recievedBooks;
        }
        public bool AddUsersDAL(User user)
        {

            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("insert into UserClass values('" + user.UserEmail + "'," + user.UserId + ", '" + user.UserName + "','" + user.UserPassword + "')", con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public List<RecievedBook> DeleteRecievedDAL()
        {
            return recievedBooks;
        }
        public List<User> GetAllUserDetails()
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("select * from UserClass", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Users = new List<User>();
            while (dr.Read())
            {
                Users.Add(new User
                {
                    UserId = Convert.ToInt32(dr["UserId"]),
                    UserName = dr["UserName"].ToString(),
                    UserEmail = dr["UserEmail"].ToString(),
                    UserPassword = dr["UserPassword"].ToString()

                });
            }
            con.Close();
            return Users;
        }
        public List<RecievedBook> GetRecievedBookDAL()
        {
            return recievedBooks;
        }
        public List<RequestedBook> GetRequestBookDAL()
        {
            return requestedBooks;
        }
        public bool RemoveUsersDAL(int User)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("delete from UserClass where UserId=" + User, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public List<RequestedBook> RequestBookDAL()
        {
            return requestedBooks;
        }
        public bool UpdateUsersDAL(User user)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("update UserClass set UserEmail='" + user.UserEmail + "',UserID=" + user.UserId + ", UserName='" + user.UserName + "',UserPassword='" + user.UserPassword + "' where UserId=" +user.UserId, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}

