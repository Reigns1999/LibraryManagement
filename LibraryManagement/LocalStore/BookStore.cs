using LibraryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.LocalStore
{
    public class BookStore
    {
        static List<Book> _bookStore = new();

        public static void AddBook(Book book)
        {
            _bookStore.Add(book);
        }

        public static void DeleteBook(Book book)
        {
            if (_bookStore.Contains(book))
            {
                _bookStore.Remove(book);
            }
        }

        public static void GetBook(Book book) 
        {
            if(_bookStore.Contains(book))
            {
                Console.WriteLine("Book Available");
            }
            else
            {
                Console.WriteLine("Book not available");
            }
        }
    }
}