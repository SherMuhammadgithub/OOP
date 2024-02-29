<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    internal class CoffeeShop
    {
        public string Name { get; set; }
        public List<MenuItem> MenuItems;
        public string[] Orders;
        public int TotalSales { get; set; }

        public CoffeeShop(string name)
        {
            Name = name;
            MenuItems = new List<MenuItem>();
            Orders = new string[0];
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    internal class CoffeeShop
    {
        public string Name { get; set; }
        public List<MenuItem> MenuItems;
        public string[] Orders;
        public int TotalSales { get; set; }

        public CoffeeShop(string name)
        {
            Name = name;
            MenuItems = new List<MenuItem>();
            Orders = new string[0];
        }
    }
}
>>>>>>> 929eb54b0403aac88bf256c4649c760b01f8f8b0
