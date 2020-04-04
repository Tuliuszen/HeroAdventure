using System;
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

            hero = CreateHero(name);
            
            while (true)
            {
                mainmenu.MenuDecision();
            }
        }

        public void Welcome()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Tell me your name: ");
            name = Console.ReadLine();
        }

        public Hero CreateHero(string heroname)
        {
            Hero hero = new Hero(heroname,1,0,0,0,0,10,20,10,20);
            Console.WriteLine("Weclome to the true man's World! " + heroname);
            hero.show_stats(hero);
            Console.ReadLine();
            hero.Add_Stats_Points(10, hero);
            Console.Clear();
            hero.show_stats(hero);
            return hero;
        }

        
    }
}
