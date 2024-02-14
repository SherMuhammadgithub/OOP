using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Management__Data_Frames___member_functions_
{
    internal class Book
    {
        public string title;
        public string[] author = new string[4];
        public string publisher;
        public int ISBN;
        public int price;
        public int no_of_copies;
        public int no_of_authors;

        public Book(string title, string[] author, int ISBN, int price, int no_of_copies) { 
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.price = price;
            this.no_of_copies = no_of_copies;
        }
    }
}
