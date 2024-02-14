using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Management__Data_Frames___member_functions_
{
    internal class Member
    {
        public string name;
        public int id;
        public List<string> books_bought = new List<string>();
        public int no_of_books_bought;
        public int money_in_bank;
        public int amount_spent;
        public bool is_member;


        public Member(string name, int id, bool is_member, int money_in_bank ) {
            this.name = name;
            this.id = id;
            this.is_member = is_member;
            this.is_member = is_member;
        }
    }
}
