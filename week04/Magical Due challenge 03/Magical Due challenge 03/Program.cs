using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magical_Due_challenge_03
{
    internal class Program
    {
        enum MenuOption
        {
            add_player = 1,
            add_skill,
            display_player_info,
            learn_skill,
            attack,
            exit
        }

        static void Main(string[] args)
        {
            GameManager game = new GameManager();
            while (true)
            {
                MenuOption choose = Menu();
                if (choose == MenuOption.add_player)
                {
                    game.AddPlayer(TakePlayerInput());
                }
                else if (choose == MenuOption.add_skill)
                {
                    game.AddSkill(TakeSkillInput());
                }
                else if(choose == MenuOption.display_player_info)
                {
                    game.PlayerInfo();
                }
                else if(choose == MenuOption.learn_skill)
                {
                    Console.WriteLine("Enter Player name: ");
                    string player_name = Console.ReadLine();
                    Console.WriteLine("Enter Skill to learn: ");
                    string skill_name = Console.ReadLine();
                    bool is_learned = game.LearnSkill(player_name, skill_name);
                    if(is_learned)
                    {
                        Console.WriteLine("Skill learned successfully...");
                    }
                    else
                    {
                        Console.WriteLine("There is an error in learning this skill....");
                    }
                }
                else if(choose == MenuOption.attack)
                {
                    Console.WriteLine("Enter Attacker name: ");
                    string attacker = Console.ReadLine();
                    Console.WriteLine("Enter Target name: ");
                    string target = Console.ReadLine();
                    string response = game.Attack(attacker, target);
                    if(response != null)
                    {
                        Console.WriteLine(response);
                    }
                    else
                    {
                        Console.WriteLine("target or attacker not found.........");
                    }
                }
                Console.ReadKey();
            }
        }

        static MenuOption Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Player");
            Console.WriteLine("2. Add Skill Statistics");
            Console.WriteLine("3. Display Player Info");
            Console.WriteLine("4. Learn a Skill");
            Console.WriteLine("5. Attack");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            return (MenuOption)option;
        }
        static Player TakePlayerInput()
        {
            Console.Write("Enter player name: ");
            string name = Console.ReadLine();
            Console.Write("Enter health: ");
            int health = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter maxHealth: ");
            int maxHealth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter energy: ");
            int energy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter maxEnergy: ");
            int maxEnergy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter armor: ");
            int armor = Convert.ToInt32(Console.ReadLine());

            return new Player(name, health, maxHealth, energy, maxEnergy, armor);
        }
        static Stats TakeSkillInput()
        {
            Console.Write("Enter skill name: ");
            string skillName = Console.ReadLine();
            Console.Write("Enter damage: ");
            int damage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter penetration: ");
            int penetration = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter heal: ");
            int heal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter cost: ");
            int cost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            return new Stats(skillName, damage, penetration, heal, cost, description);
        }
    }
}
