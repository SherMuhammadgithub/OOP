using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magical_Due_challenge_03
{
    internal class GameManager
    {
        private List<Player> players;
        private List<Stats> skills;
        public GameManager() { 
            players = new List<Player>();
            skills = new List<Stats>();
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public void AddSkill(Stats skill)
        {
            skills.Add(skill);
        }
        public void PlayerInfo()
        {
            foreach(var player in players)
            {
                Console.WriteLine($"{player.player_name} has {player.health}, energy {player.energy} and armor {player.armor}");
            }
        }
        public string Attack(string attacker_name, string target_name)
        {
            Player attacker = players.Find(a => a.player_name == attacker_name);
            Player target = players.Find(t => t.player_name == target_name);
            if(target != null && attacker != null)
            {
               return attacker.Attack(target);
            }
            return null;
            
        }
        public bool  LearnSkill(string player, string skill_to_learn)
        {
            Player attacker = players.Find(p => p.player_name == player);
            Stats learn_skill = skills.Find(s => s.skill_name == skill_to_learn);
            if(learn_skill != null && attacker != null)
            {
                attacker.LearnSkill(learn_skill);
                return true;
            }
            return false;
        }
    }
}
