using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Book
    {
        public string Name { get; set; }
        public string ISBN { get; set; }
        public List<Author> Authors { get; private set; } // this is a list of authors

        public Book(string name, string isbn)
        {
            Name = name;
            ISBN = isbn;
            Authors = new List<Author>();
        }
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}
