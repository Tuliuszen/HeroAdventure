using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Shop
    {
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
                string selectedMenuItem = Menu.drawMenu(menuItems);
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
                    Menu.drawMenu(menuItems);
                    Menu.mainMenuDecision(hero);
                }
            }
        }

    }
}
