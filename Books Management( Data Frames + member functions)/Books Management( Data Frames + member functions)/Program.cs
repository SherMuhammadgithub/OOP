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
                MenuOption choice = UserMenu();
                if(choice == MenuOption.AddBook)
                {

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
    }
}
