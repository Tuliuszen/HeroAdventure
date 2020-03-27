using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Menu:Game
    {
        public int index = 0;

        public Menu()
        {
            
        }
        public void MenuDecision(string[] args)
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
                if (selectedMenuItem == "one")
                {
                    Console.Clear();
                    Console.WriteLine("HELLO one!"); Console.Read();
                }
                else if (selectedMenuItem == "two")
                {
                    Console.Clear();
                    Console.WriteLine("HELLO one!"); Console.Read();
                }
                else if (selectedMenuItem == "Exit")
                {
                    Environment.Exit(0);
                }
            }
        }

        internal void MenuDecision()
        {
            throw new NotImplementedException();
        }

        public string drawMenu(List<string> items)
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
                    //index = 0; //Remove the comment to return to the topmost item in the list
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    //index = menuItem.Count - 1; //Remove the comment to return to the item in the bottom of the list
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
