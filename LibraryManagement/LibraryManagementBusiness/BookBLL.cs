using LibraryManagementData;
using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBusiness
{
    public class BookBLL
    {
        List<Book> dalBook = new List<Book>();
        public bool AddBookBLL(Book book)
        {
            BookDAL bookDAL = new BookDAL();
            return bookDAL.AddBookDAL(book);

        }
        List<Book> BookValidation()
        {
            return dalBook;

        }
        public List<Book> GetAllBookBLL()
        {
            BookDAL bookDAL=new BookDAL();
            return bookDAL.GetAllBooksDAL();

        }
        public bool RemoveBookBLL(int Book)
        {
            BookDAL bookDAL = new BookDAL();
            return bookDAL.RemoveBooksDAL(Book);

        }
        public bool UpdateBookBLL(Book book)
        {
            BookDAL bookDAL = new BookDAL();
            return bookDAL.UpdateBooksDAL(book);

        }
    }
}
