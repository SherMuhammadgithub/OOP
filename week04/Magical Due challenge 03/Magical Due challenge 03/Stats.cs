using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magical_Due_challenge_03
{
    internal class Stats
    {
        public string skill_name;
        public int damage;
        public int penetration;
        public int heal;
        public int cost;
        public string description;

        public Stats (string name, int damage, int penetration, int heal, int cost, string description)
        {
            skill_name = name;
            this.damage = damage;
            this.penetration = penetration;
            this.heal = heal;
            this.cost = cost;
            this.description = description;
        }

       
    }
}
