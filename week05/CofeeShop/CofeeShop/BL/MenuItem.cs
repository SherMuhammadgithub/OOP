﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    internal class MenuItem
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

        public MenuItem(string name, string type, int price)
        {
            Name = name;
            Type = type;
            Price = price;
        }
    }
}
