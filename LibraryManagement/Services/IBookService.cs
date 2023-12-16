using LibraryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services
{
    public interface IBookService
    {
        Book CreateBook(Book book);
        Book GetBook(Book book);
        Book UpdateBook(Book book);
        Book DeleteBook(Book book);

    }
}