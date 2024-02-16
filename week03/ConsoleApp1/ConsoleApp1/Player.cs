using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player
    {
        public int hp;
        public int maxHp;
        public int energy;
        public int maxEnergy;
        public int armor;
        public string name;
        public Sats skillstatistcs;
        //public have to add skills satistics
        public Player(string name, int hp, int energy, int armor)
        {
            this.name = name;
            this.hp = hp;
            this.energy = energy;
            this.armor = armor;

        }
        public void LearnSkill(Sats skills_stats)
        {
            skillstatistcs = skills_stats;
        }
        public string attack(Player player)
        {
            int effective_armor = player.armor - skillstatistcs.penetration;
            if(player.energy > skillstatistcs.penetration)
            {
            }
                return "s";
        }

    }
}
