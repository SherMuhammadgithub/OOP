using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("J.D. Salinger");
            Book book = new Book("The Catcher in the Rye", "978-0-316-76948-0");
            book.AddAuthor(author);
        }
    }
}
