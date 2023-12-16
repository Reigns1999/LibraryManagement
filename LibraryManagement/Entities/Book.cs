using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Entities
{
    public class Book
    {
        private string ISBN { get; }
        private string Name { get; }
        private string Title { get; }
        private string Description { get; }
        private string Author { get; }
        private string Publisher { get; }

        public Book(string Isbn,
            string Namw,
            string Title,
            string Description,
            string Author,
            string Publisher)
        {
            ISBN = Isbn;
            Name = Namw;
            this.Title = Title;
            this.Description = Description;
            this.Author = Author;
            this.Publisher = Publisher;

        }


        public override string ToString()
        {
            return string.Format("ISBN {0} \t Name {1}", ISBN, Name);
        }

        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return System.HashCode.Combine(Name, Title, Description, ISBN, Author, Publisher);
        }

        public override bool Equals(object? obj)
        {
            //return base.Equals(obj);
            return obj is Book other && Name==other.Name && Title==other.Title && Description==other.Description && ISBN==other.ISBN && Author==other.Author && Publisher==other.Publisher;
        }

    }

}
