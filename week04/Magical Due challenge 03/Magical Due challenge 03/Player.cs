using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Magical_Due_challenge_03
{
    internal class Player
    {
        public string player_name;
        public int health;
        public int max_health;
        public int energy;
        public int max_energy;
        public int armor;
        public Stats skills_learn;
        public Player(string name, int health, int max_health, int energy, int max_energy, int armor)
        {
            player_name = name;
            this.health = health;
            this.max_health = max_health;
            this.energy = energy;
            this.armor = armor;
        }
        public void LearnSkill(Stats skill)
        {
            skills_learn = skill;
        }
        public string Attack (Player target)
        {
            int effective_armor = target.armor - skills_learn.penetration;
            if(effective_armor < 0)
            {
                effective_armor = 0;
            }
            if(skills_learn.cost > target.energy)
            {
                return $"{player_name} attempted to use {skills_learn.skill_name}, but didn't have enough energy!";
            }
            target.energy -= skills_learn.cost;

            // calculate damage 20 * 
            double damage = skills_learn.damage * ((100 - effective_armor) / 100.0);

            // apply the damage to the target

            target.health-=(int)damage;

            // check for healing effect

            if(skills_learn.heal > 0)
            {
                health+=skills_learn.heal;
            }

            // can't increase by max health 
            if(health > max_health)
            {
                health = max_health;
            }

            // cheking if the target died
            if(target.health <= 0)
            {
                return $"{player_name} used {skills_learn.skill_name}, {skills_learn.description}, against {target.player_name}, doing {damage} damage! {player_name} healed for {skills_learn.heal} health! {target.player_name} died.";
            }
            else
            {
                return $"{player_name} used {skills_learn.skill_name}, {skills_learn.description}, " +
                    $"against {target.player_name}, doing {damage} damage! {player_name} healed for " +
                    $"{skills_learn.heal} health! {target.player_name} is at {(target.health * 100 / target.max_health)}% health.";
            }
        }
    }
}
