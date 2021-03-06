﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    [Serializable]
    class Game
    {
        string name;

        public Hero hero;


        public void mainMenu()
        {
            Play.gameDecision();
        }

        public void gameStart()
        {
            Welcome();
            hero = createHero(name);
            Monster.addMonsters();
            WepaonsInicialization.addWeaponsList();
            ArmorInicialization.addArmorList();
            PotionsInicialization.addPotionsList();
            while (true)
            {
                Menu.mainMenuDecision(hero);
            }
        }

        public void Welcome()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Tell me your name: ");
            name = Console.ReadLine();
        }

        public Hero createHero(string heroName)
        {
            Hero hero = new Hero(heroName,1,0,100,0,0,0,25,25,25,25,null,null);
            Console.WriteLine("Weclome to the true man's World! " + heroName);
            Console.ReadLine();
            hero.addStatsPoints(10);
            hero.showStats();
            return hero;
        }

        
    }
}
