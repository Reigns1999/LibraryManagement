// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using LibraryManagement.Entities;
using LibraryManagement.LocalStore;

namespace LibraryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //start point
            Book book = new Book("123","er","rew","hfdy","ewe","wee");
            BookStore.AddBook(book);

            Book book2 = new Book("123", "er", "rew", "hfdy", "ewe", "wee");
            BookStore.AddBook(book2);

            Book book3 = new Book("123", "er", "rew", "hfdy", "ewe", "wee");

            BookStore.GetBook(book3);
        }
    }
}
