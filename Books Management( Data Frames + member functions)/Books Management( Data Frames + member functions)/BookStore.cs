using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Management__Data_Frames___member_functions_
{
    internal class BookStore
    {
        private BoooksRepositry books_repo;
        private MemberRepositry memeber_repo;

        public BookStore()
        {
            books_repo = new BoooksRepositry();
            memeber_repo = new MemberRepositry();
        }

        public void AddBook(Book book)
        {
            books_repo.AddBook(book);
        }

        public Book SearchBookByTitle(string title) {
            return books_repo.SearchBookByTitle(title);
        }
        public Book SearchBookById(int id)
        {
            return books_repo.SearchBookByISBN(id);
        }
        public bool UpdateBook(int id, Book updated_book)
        {
            return books_repo.UpdateBookStock(id, updated_book);
        }
        // ****Member Functions****
        public void AddMember(Member member)
        {
            memeber_repo.AddMember(member);
        }
        public Member SearchMember(string search_query)
        {
            return memeber_repo.GetMember(search_query);
        }

        public bool UpdateMemberInfo(string search_query, Member updated_member)
        {
            return memeber_repo.UpdateMemberInfo(search_query, updated_member);
        }

        public bool PurchaseBook(string member_name, bool isMember, int book_ISBN)
        {
            Book book = books_repo.SearchBookByISBN(book_ISBN);
            Member member = memeber_repo.GetMember(member_name);

            if (isMember)
            {
                member.money_in_bank-= (book.price*5)/100;
                return true;
            }
            else if(!isMember)
            {
                member.money_in_bank -= book.price;
                return true;
                
            }
            return false;
        }
    }
}
