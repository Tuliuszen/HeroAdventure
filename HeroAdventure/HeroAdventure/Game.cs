﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Game
    {
        string name;

        public Hero hero;

        Menu mainmenu = new Menu();
        public Game()
        { 
            
        }
        public void Play()
        {
            Welcome();

            hero = createHero(name);
            
            while (true)
            {
                Menu.menuDecision();
            }
        }

        public void Welcome()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Tell me your name: ");
            name = Console.ReadLine();
            Console.Clear();
        }

        public Hero createHero(string heroName)
        {
            Hero hero = new Hero(heroName,1,0,0,0,0,10,20,10,20);
            Console.WriteLine("Weclome to the true man's World! " + heroName);
            hero.showStats();
            Console.ReadLine();
            hero.addStatsPoints(10);
            Console.Clear();
            hero.showStats();
            return hero;
        }

        
    }
}