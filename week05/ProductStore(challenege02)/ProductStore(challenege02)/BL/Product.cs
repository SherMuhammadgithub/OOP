<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_challenege02_
{
    internal class Product
    {
        public string Name;
        public string Category;
        public int Price;
        public  int StockQty;
        public int  MinStockQty; // threshold for stock\
        public Product(string name, string category, int price, int stockQty, int minStockQty)
        {
            Name = name;
            Category = category;
            Price = price;
            StockQty = stockQty;
            MinStockQty = minStockQty;
        }
        public Product()
        {
            
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
    internal class Product
    {
        public string Name;
        public string Category;
        public int Price;
        public  int StockQty;
        public int  MinStockQty; // threshold for stock\
        public Product(string name, string category, int price, int stockQty, int minStockQty)
        {
            Name = name;
            Category = category;
            Price = price;
            StockQty = stockQty;
            MinStockQty = minStockQty;
        }
        public Product()
        {
            
        }

    }
}
>>>>>>> 929eb54b0403aac88bf256c4649c760b01f8f8b0
