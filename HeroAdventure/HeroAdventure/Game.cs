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
        Menu mainmenu = new Menu();
        public Game()
        { 
            
        }
        public void Play()
        {
            Welcome();
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
    }
}
