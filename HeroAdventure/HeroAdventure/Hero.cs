﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Hero
    {
        public string heroName;
        public int strength, agillity, defence, stamina, health, maxStamina, maxHealth;
        public int heroLevel, experience, gold;
        static int levels;
        static int heroLevelBefore;
        public Items weapon, armor;

        public Hero(string heroName,int heroLevel,int experience,int gold,  int strength, int agillity, int defence, int stamina, int health, int maxStamina, int maxHealth, Items weapon, Items armor)
        {
            this.heroName = heroName;
            this.heroLevel = heroLevel;
            this.experience = experience;
            this.gold = gold;
            this.strength = strength;
            this.agillity = agillity;
            this.defence = defence;
            this.stamina = stamina;
            this.health = health;
            this.maxStamina = maxStamina;
            this.maxHealth = maxHealth;
            this.weapon = weapon;
            this.armor = armor;
        }

        public void addStatsPoints(int numberOfPoints)
        {
            int points;

            Console.Clear();
            
            int previousHealth = this.health;
            int previousStamina = this.stamina;
            int previousDefence = this.defence;

            Console.WriteLine("You have " + numberOfPoints + " Points, choose wisely");
            Console.WriteLine("strength=more damage, agillity=more frequent skills, defence=damage reduction");
            
            Console.WriteLine("How much points to strength? ");     //add points to strength
            points = int.Parse(Console.ReadLine());
            if(numberOfPoints >= points)
            {
                this.strength += points;
            }
            else
            {
                addStatsPoints(numberOfPoints);
                this.health = previousHealth;
                this.stamina = previousStamina;
                this.defence = previousDefence;
            }
            numberOfPoints -= points;

            Console.WriteLine("How much points to agillity? ");
            points = int.Parse(Console.ReadLine());
            if (numberOfPoints >= points)
            {
                this.agillity += points;
            }
            else
            {
                addStatsPoints(numberOfPoints);
                this.health = previousHealth;
                this.stamina = previousStamina;
                this.defence = previousDefence;
            }
            numberOfPoints -= points;

            Console.WriteLine("How much points to defence? ");
            points = int.Parse(Console.ReadLine());
            if (numberOfPoints >= points)
            {
                this.defence += points;
            }
            else
            {
                addStatsPoints(numberOfPoints);
                this.health = previousHealth;
                this.stamina = previousStamina;
                this.defence = previousDefence;
            }
            numberOfPoints -= points;

            if(numberOfPoints > 0)
            {
                addStatsPoints(numberOfPoints);
            }
        }

        static List<int> expToLevelUp = new List<int>(new int[] { 10, 30, 50, 90, 140, 200, 280, 400, 600 });

        static public void checkLevel(Hero hero)
        {
            foreach (int expGrade in expToLevelUp)
            {
                if(hero.experience >= expGrade)
                {
                    levels++;
                }
                if(levels > heroLevelBefore)
                {
                    Console.WriteLine("You Leveled Up!");
                    Console.ReadKey();
                    hero.addStatsPoints(5);
                    hero.heroLevel = levels + 1;
                    heroLevelBefore = hero.heroLevel;
                }
            }

        }
        public void showStats()
        {
            Console.WriteLine("Hero Stats:");
            Console.WriteLine("Lvl " + this.heroLevel);
            Console.WriteLine("Health " + this.health);
            Console.WriteLine("Stamina " + this.stamina);
            Console.WriteLine("Strength " + this.strength);
            Console.WriteLine("Agility " + this.agillity);
            Console.WriteLine("Defence " + this.defence);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public int superAttack()
        {
            int damage;
            if(this.stamina >= 5)
            {
                damage = this.strength * 2;
            }
            else
            {
                damage = this.strength;
            }
            return damage;
        }
    }

}
