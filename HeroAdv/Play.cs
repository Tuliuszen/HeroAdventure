using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    public class Play
    {
        static Game start = new Game();
        
        static public void gameDecision()
        {
            List<string> menuItems = new List<string>() {
                "New Game",
                "Load"
            };

            Console.CursorVisible = false;
            while (true)
            {
                string selectedMenuItem = Menu.drawMenu(menuItems);
                if (selectedMenuItem == "New Game")
                {
                    start.gameStart();
                }
                else if (selectedMenuItem == "Load")
                {
                    Hero hero = new Hero(null,0,0,0,0,0,0,0,0,0,0,null,null);
                    SaveLoad.Load(hero);
                }
                
            }
        }
    }
}
