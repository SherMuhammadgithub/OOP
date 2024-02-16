using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Management__Data_Frames___member_functions_
{
    internal class BoooksRepositry
    {
        List<Book> books;
        public BoooksRepositry()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book SearchBookByTitle(string title)
        {
            Book book_to_search = books.Find(book => book.title == title);
            if(book_to_search != null)
            {
                return book_to_search;
            }
            return null;
        }
        public Book SearchBookByISBN(int ISBN)
        {
            Book book_to_search = books.Find(book => book.ISBN == ISBN);
            if (book_to_search != null)
            {
                return book_to_search;
            }
            return null;
        }
        public bool UpdateBookStock(int ISBN, Book updated_book)
        {
            Book existing_book = books.Find(book => book.ISBN == ISBN);
            if(existing_book != null)
            {
                existing_book.no_of_copies = updated_book.no_of_copies;
                return true;
            }
            return false;
        }

    }
}
