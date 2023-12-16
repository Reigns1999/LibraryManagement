/*using LibraryManagement.Entities;
using LibraryManagement.LocalStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services
{
    public class BookService : IBookService
    {
        public Book CreateBook(Book book)
        {
            BookStore.AddBook(book);
            return book;
        }

        public Book DeleteBook(Book book)
        {
            BookStore.DeleteBook(book);
        }

        public void GetBook(string ISBN)
        {
            BookStore.GetBook(ISBN);
        }

        public Book UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}*/
