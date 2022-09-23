using LibraryManagementBusiness;
using LibraryManagementData;
using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementPresentation
{
    public class BookPL
    {
        public void BookDetails()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Welcome-to-book-Section--------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1) Press 1 to add a Book \n");
            Console.Write("2) Press 2 to update a Book \n");
            Console.Write("3) Press 3 to delete a Book \n");
            Console.Write("4) Press 4 to show all Book \n");
            Console.Write("5) Press 5 to exit \n");
            int bk =Convert.ToInt32(Console.ReadLine());
            switch(bk)
            {
                case 1:
                    AddBookPL();
                    break;
                case 2:
                    UpdateBookPL();
                    break;
                case 3:
                    RemoveBookPL();
                    break;
                case 4:
                    ShowBookPL();
                    break;
                case 5:
                    Console.Read();
                    break;
            }

        }
        public void AddBookPL()
        {
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("Enter Book Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Book Id: ");
            int bookId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Book Name: ");
            string bookName = Console.ReadLine();   
            Console.Write("Book Author: ");
            string bookAuthor = Console.ReadLine();
            Console.Write("Book Copies: ");
            int bookCopies =Convert.ToInt32( Console.ReadLine());
            BookBLL bookBLL = new BookBLL();
            Book book = new Book(bookAuthor, bookCopies, bookId, bookName);
            bool flag=bookBLL.AddBookBLL(book);
            if (flag==true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Book added successfully...");
                BookDetails();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }
            
            Console.Write(flag);

        }
        public void UpdateBookPL()
        {
           
            BookBLL bookBLL = new BookBLL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Book Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Book Id: ");
            int BookId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Book Name: ");
            string BookName = Console.ReadLine();
            Console.Write("Book Author: ");
            string BookAuthor = Console.ReadLine();
            Console.Write("Book Copies: ");
            int BookCopies = Convert.ToInt32(Console.ReadLine());
            Book book = new Book(BookAuthor, BookCopies, BookId, BookName);
            bool flag = bookBLL.UpdateBookBLL(book);
            if (flag==true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Book updated successfully...");
                BookDetails();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Updated Successfully");
            Console.ForegroundColor = ConsoleColor.White;
            BookDetails();


        }
        public void RemoveBookPL()
        {
            BookBLL bookBLL = new BookBLL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Book Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Book Id: ");
            int Book = Convert.ToInt32(Console.ReadLine());
   
            Book book = new Book();
            bool flag = bookBLL.RemoveBookBLL(Book);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Book deleted successfully...");
                BookDetails();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Deleted Successfully");
            Console.ForegroundColor = ConsoleColor.White;
            BookDetails();

        }
        
        public void ShowBookPL()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------Book-List-------------------------");
            Console.WriteLine("--Id----Name----------Author-------------------Copies--------");
            Console.ForegroundColor = ConsoleColor.White;
            BookBLL bookBLL=new BookBLL();
            List<Book> bookBLLList=new List<Book>();
            bookBLLList = bookBLL.GetAllBookBLL();
            foreach (var item in bookBLLList)
            {
                Console.WriteLine(item.BookId+ "\t" +item.BookName+ "\t \t" +item.BookAuthor+ "\t \t \t" +item.BookCopies);

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            BookDetails();
           
        }
    }
}
