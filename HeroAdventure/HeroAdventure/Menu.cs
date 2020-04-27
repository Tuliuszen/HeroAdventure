using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Menu
    {
        static public int index = 0;
        static Monster monster;
        static public void menuDecision(Hero hero)
        {
            List<string> menuItems = new List<string>() {
                "Fight Monster",
                "Go shopping",
                "Exit"
            };

            Console.CursorVisible = false;
            while (true)
            {
                string selectedMenuItem = drawMenu(menuItems);
                if (selectedMenuItem == "Fight Monster")
                {
                    Console.Clear();
                    monster = Monster.pickCurrentEnemy(hero);
                    Fight.fightMonster(hero, monster);
                    Console.Read();
                    Console.Clear();
                }
                else if (selectedMenuItem == "Go shopping")
                {
                    Console.Clear();
                    Console.WriteLine("Shop!"); Console.Read();
                    Console.Clear();
                }
                else if (selectedMenuItem == "Exit")
                {
                    Environment.Exit(0);
                }
            }
        }


        static public string drawMenu(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == items.Count - 1)
                {
                    index = 0; 
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index == 0)
                {
                    index = 2;
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[index];
            }
            else
            {
                return "";
            }

            Console.Clear();
            return "";
        }
    }
}
