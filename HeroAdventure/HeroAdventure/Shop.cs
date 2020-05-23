using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Shop
    {
        static public int index = 0;
        static public void whichEquipmentCategory(Hero hero)
        {
            Console.WriteLine("Welcome to the Shop!");
            Console.WriteLine("What items do you want to look at?");
            Shop.shopMenuDecision(hero);
        }

        static public void shopMenuDecision(Hero hero)
        {
            List<string> menuItems = new List<string>() {
                "Weapons",
                "Armor",
                "Potions",
                "Exit"
            };

            Console.CursorVisible = false;
            while (true)
            {
                string selectedMenuItem = Shop.drawMenu(menuItems);
                if (selectedMenuItem == "Weapons")
                {
                    Console.Clear();
                    Console.WriteLine("Weapons");
                    Items.showWeaponsList();
                }
                else if (selectedMenuItem == "Armor")
                {
                    Console.Clear();
                    Console.WriteLine("Armor");
                    Items.showArmorList();
                }
                else if (selectedMenuItem == "Potions")
                {
                    Console.Clear();
                    Console.WriteLine("Potions");
                    Items.showPotionsList();
                    Console.ReadKey();
                }
                else if (selectedMenuItem == "Exit")
                {
                    Menu.mainMenuDecision(hero);
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
