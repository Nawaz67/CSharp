using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Configuration;
using System.Data;
using System.Xml.Serialization;
using System.IO;

namespace LibraryManagementData
{
    public class BookDAL
    {
        public static string sqlcon = "Data Source=VDC01LTC2106; Initial Catalog=LibraryManagement;Integrated Security=True";
        public List<Book> Books;
        public bool AddBookDAL(Book book)
        {
            /* Books = new List<Book>();    
             Books.Add(book);
             return Books;*/
            #region connected approach
            //SqlConnection con = new SqlConnection(sqlcon);
            //SqlCommand cmd = new SqlCommand("insert into BookClass values('"+book.BookAuthor+"',"+book.BookCopies+", "+book.BookId+",'"+book.BookName+"')",con); 
            //con.Open();
            //int row=cmd.ExecuteNonQuery();
            //con.Close();
            //return true;
            #endregion

            #region Disconnected approach
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("insert into BookClass values('" + book.BookAuthor + "'," + book.BookCopies + ", " + book.BookId + ",'" + book.BookName + "')", con);
            DataTable dt=new DataTable();
            //DataSet ds=new DataSet();
            adp.Fill(dt);

            return true;
            #endregion


        }
        public List<Book> GetAllBooksDAL()
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("select * from BookClass", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Books = new List<Book>();
            while (dr.Read())
            {
                Books.Add(new Book
                {
                    BookId = Convert.ToInt32(dr["BookId"]),
                    BookName = dr["BookName"].ToString(),
                    BookAuthor = dr["BookAuthor"].ToString(),
                    BookCopies = Convert.ToInt32(dr["BookCopies"])

                });
            }
            con.Close();

           /*SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("select * from book", con);
            DataTable dt = new DataTable();
            List<Book> bookList = new List<Book>();
            adp.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    bookList.Add(new Book
                    {
                        BookId = Convert.ToInt32(dt.Rows[i]["BookId"]),
                        BookName = dt.Rows[i]["BookName"].ToString(),
                        BookAuthor = dt.Rows[i]["BookAuthor"].ToString(),
                        BookCopies = Convert.ToInt32(dt.Rows[i]["BookCopies"])

                    });
                }
            }*/
           //IN this we can convert from object to xml format (how to Serialize)
            XmlSerializer xmlSerializer=new XmlSerializer(typeof(List<Book>));
            FileStream fileStream = new FileStream("books.xml", FileMode.Create);
            xmlSerializer.Serialize(fileStream, Books);
            fileStream.Close();

            //how to Deserialize
            var reader=new StreamReader("books.xml");
            var result=(List<Book>)xmlSerializer.Deserialize(reader);
            return Books;
        }
        public bool UpdateBooksDAL(Book book)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("update BookClass set BookAuthor='" + book.BookAuthor + "',BookCopies=" + book.BookCopies+  ", BookId=" + book.BookId + ",BookName='" + book.BookName + "' where BookId="+book.BookId, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return true;


        }
        public bool RemoveBooksDAL(int Book)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("delete from BookClass where BookId="+Book, con); 
            con.Open();
            int row=cmd.ExecuteNonQuery();
            con.Close();
            return true;


        }

    }
}
