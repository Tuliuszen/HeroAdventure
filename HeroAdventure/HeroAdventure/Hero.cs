using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Hero
    {
        string heroName;
        int strength, agillity, defence, stamina, health, maxstamina, maxhealth;
        int herolevel, experience;
        
        public Hero(string heroName,int herolevel,int experience,  int strength, int agillity, int defence, int stamina, int health, int maxstamina, int maxhealth)
        {
            this.heroName = heroName;
            this.herolevel = herolevel;
            this.experience = experience;
            this.strength = strength;
            this.agillity = agillity;
            this.defence = defence;
            this.stamina = stamina;
            this.health = health;
            this.maxstamina = maxstamina;
            this.maxhealth = maxhealth;
        }

        public void Add_Stats_Points(int number_of_points)
        {
            int points;
            
            Console.Clear();

            Console.WriteLine("You have " + number_of_points + " Points, choose wisely");
            Console.WriteLine("strength=more damage, agillity=more frequent skills, defence=damage reduction");
            
            Console.WriteLine("How much points to strength? ");     //add points to strength
            points = int.Parse(Console.ReadLine());
            if(number_of_points > points)
            {
                hero.strength += points;
            }
            else
            {
                Add_Stats_Points(number_of_points);
            }
            number_of_points -= points;                             //remove points added from all points to strength and move to agility

            Console.WriteLine("How much points to agillity? ");
            points = int.Parse(Console.ReadLine());
            if (number_of_points > points)
            {
                hero.agillity += points;
            }
            else
            {
                Add_Stats_Points(number_of_points);
            }
            number_of_points -= points;

            Console.WriteLine("How much points to defence? ");
            points = int.Parse(Console.ReadLine());
            if (number_of_points > points)
            {
                hero.defence += points;
            }
            else
            {
                Add_Stats_Points(number_of_points);
            }
            number_of_points -= points;

        }

        

        public void show_stats()
        {
            Console.WriteLine(hero.strength);
            Console.WriteLine(hero.agillity);
            Console.WriteLine(hero.defence);
        }
    }

}
