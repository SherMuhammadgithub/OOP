<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 929eb54b0403aac88bf256c4649c760b01f8f8b0
