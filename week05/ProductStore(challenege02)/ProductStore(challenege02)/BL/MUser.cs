using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_challenege02_
{
    internal class MUser
    {
        public string Name;
        public string Password;

        public MUser(string name, string password)
        {
            Name = name;
            Password = password;
        }
        //to be accessed by all
        public static bool IsAdmin(string role)
        {
            if (role.Equals("Admin",StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
