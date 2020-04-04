using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Hero
    {
        public string heroName;
        public int strength, agillity, defence, stamina, health, maxstamina, maxhealth;
        public int herolevel, experience;
        
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

        public void Add_Stats_Points(int number_of_points, Hero hero)
        {
            int points;

            Console.Clear();

            int previoushealth = hero.health;
            int previousstamina = hero.stamina;
            int previousdefence = hero.defence;

            Console.WriteLine("You have " + number_of_points + " Points, choose wisely");
            Console.WriteLine("strength=more damage, agillity=more frequent skills, defence=damage reduction");
            
            Console.WriteLine("How much points to strength? ");     //add points to strength
            points = int.Parse(Console.ReadLine());
            if(number_of_points >= points)
            {
                hero.strength += points;
            }
            else
            {
                Add_Stats_Points(number_of_points, hero);
                hero.health = previoushealth;
                hero.stamina = previousstamina;
                hero.defence = previousdefence;
            }
            number_of_points -= points;

            Console.WriteLine("How much points to agillity? ");
            points = int.Parse(Console.ReadLine());
            if (number_of_points >= points)
            {
                hero.agillity += points;
            }
            else
            {
                Add_Stats_Points(number_of_points, hero);
                hero.health = previoushealth;
                hero.stamina = previousstamina;
                hero.defence = previousdefence;
            }
            number_of_points -= points;

            Console.WriteLine("How much points to defence? ");
            points = int.Parse(Console.ReadLine());
            if (number_of_points >= points)
            {
                hero.defence += points;
            }
            else
            {
                Add_Stats_Points(number_of_points, hero);
                hero.health = previoushealth;
                hero.stamina = previousstamina;
                hero.defence = previousdefence;
            }
            number_of_points -= points;

            if(number_of_points > 0)
            {
                Add_Stats_Points(number_of_points, hero);
            }
        }


        public void show_stats(Hero hero)
        {
            Console.WriteLine("Hero Stats:");
            Console.WriteLine("Lvl " + hero.herolevel);
            Console.WriteLine("Health " + hero.health);
            Console.WriteLine("Stamina " + hero.stamina);
            Console.WriteLine("Strength " + hero.strength);
            Console.WriteLine("Agility " + hero.agillity);
            Console.WriteLine("Defence " + hero.defence);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }

}
