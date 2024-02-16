using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sats
    {
        public string name;
        public int damage;
        public string description;
        public int penetration;
        public int cost;
        public int heals;
        public Sats (string name, int peneteration, int heal, int cost, string description)
        {
            this.name = name;
            this.penetration = peneteration;
            this.description = description;
            this.heals = heal;
            this.cost = cost;
            

        }

    }
}
