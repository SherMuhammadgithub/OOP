using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Management__Data_Frames___member_functions_
{
    internal class Program
    {

        enum MenuOption
        {
            AddBook = 1,
            SearchBookByISBN,
            SearchBookByTitle,
            UpdateStock,
            AddMember,
            SearchMember,
            UpdateMemberInfo,
            PurchaseBook,
            Exit
        }

        static void Main(string[] args)
        {
            BookStore bookStore = new BookStore();
            Console.WriteLine("****BookStore****");
            while(true)
            {
                Console.Clear();
                MenuOption choice = UserMenu();
                if(choice == MenuOption.AddBook)
                {
                    bookStore.AddBook(InputBookDetails());
                    Console.WriteLine("Book added Successfully.....");
                }
                else if(choice == MenuOption.SearchBookByISBN)
                {
                    Console.Clear();
                    Console.WriteLine("Enter IBSN number: ");
                    int IBSN = int.Parse(Console.ReadLine());
                    Book book = bookStore.SearchBookByIBSN(IBSN);
                    if(book != null)
                    {
                        ShowBookDetails(book);
                    }
                    else
                    {
                        Console.WriteLine("Book Not Found");
                    }
                    Console.ReadKey();
                }
                
                }
        }
        static MenuOption UserMenu()
        {
            Console.WriteLine("1.Add a Book");
            Console.WriteLine("2.Search for a Book by ISBN");
            Console.WriteLine("3.Search for a Book by Title");
            Console.WriteLine("4.Update Stock of a Book");
            Console.WriteLine("5.Add a Member");
            Console.WriteLine("6.Search for a Member by Name or ID");
            Console.WriteLine("7.Update Member Information");
            Console.WriteLine("8.Purchase a Book");
            Console.WriteLine("9.Exit");
            int option;
            if(!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 9 )
            {
                UserMenu();
            }
            return (MenuOption)option;

        }
        static Book InputBookDetails()
        {
            Console.Clear();
            Console.WriteLine("Enter Title: ");
            string title = Console.ReadLine();
            string[] authors = new string[4];
            authors[0] = "sd";
            Console.WriteLine("Enter ISBN: ");
            int ISBN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of copies: ");
            int copies = int.Parse(Console.ReadLine());
            Book book = new Book(title, authors, ISBN, price, copies);
            return book;
        }
        static void ShowBookDetails(Book book)
        {
            Console.WriteLine("****Book Detail****");
            Console.WriteLine($"Title: {book.title}");
            Console.WriteLine($"Author {book.author[0]}");
            Console.WriteLine($"Stock: {book.no_of_copies}");
        }
    }
}
