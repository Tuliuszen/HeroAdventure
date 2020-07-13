using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Shop
    {
        static Items choosenItem;
        

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
                "Stats",
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
                    WepaonsInicialization.showWeaponsList();
                    Shop.chooseItemToBuy("Weapons", hero);
                    Shop.buy(choosenItem, hero);
                }
                else if (selectedMenuItem == "Armor")
                {
                    Console.Clear();
                    Console.WriteLine("Armor");
                    ArmorInicialization.showArmorList();
                    Shop.chooseItemToBuy("Armor", hero);
                    Shop.buy(choosenItem, hero);
                }
                else if (selectedMenuItem == "Potions")
                {
                    Console.Clear();
                    Console.WriteLine("Potions");
                    PotionsInicialization.showPotionsList();
                    Shop.chooseItemToBuy("Potions", hero);
                    Shop.buy(choosenItem, hero);
                }
                else if (selectedMenuItem == "Stats")
                {
                    hero.showStats();
                }
                else if (selectedMenuItem == "Exit")
                {
                    Menu.drawMenu(menuItems);
                    Menu.mainMenuDecision(hero);
                }
            }
        }
        
        static public void chooseItemToBuy(string itemList, Hero hero)
        {
            int itemNumber;
            string answer;
            Console.WriteLine("Hero Gold: " + hero.gold);
            Console.WriteLine("Wanna buy something? yes or no");
            answer = Console.ReadLine();
            if (answer == "no")
            {
                Shop.whichEquipmentCategory(hero);
            }
            else if(answer == "yes")
            Console.WriteLine("Pick item number");           
            itemNumber = int.Parse(Console.ReadLine());
            

            if (itemList == "Weapons")
            {
                choosenItem = ShopLists.weaponsList[itemNumber];
            }
            else if (itemList == "Armor")
            {
                choosenItem = ShopLists.armorList[itemNumber];
            }
            else 
            {
                choosenItem = ShopLists.potionsList[itemNumber];
            }
        }

        static public void buy(Items item, Hero hero)
        {
            Items previousWeapon = hero.weapon;
            Items previousArmor = hero.armor;

            if (hero.gold >= item.itemCost)     
            {
                if (item.GetType() == typeof(Weapons))
                {
                    buyItem(hero, item,previousWeapon);
                    hero.weapon = item;
                    hero.gold -= item.itemCost;
                    Shop.whichEquipmentCategory(hero);
                }
                else if (item.GetType() == typeof(Armor))
                {
                    buyItem(hero, item, previousArmor);
                    hero.armor = item;
                    hero.gold -= item.itemCost;
                    Shop.whichEquipmentCategory(hero);
                }
                else if (item.GetType() == typeof(Potions))     
                {
                    addPotionsStats(hero, item);
                    hero.gold -= item.itemCost;
                    Shop.whichEquipmentCategory(hero);
                }
            }
            else 
            {
                Console.WriteLine("Not enough money try again later!");
                Shop.whichEquipmentCategory(hero);
            }

        }

        static void addPotionsStats(Hero hero, Items potion)
        {
            hero.health += potion.itemHealth;
            hero.stamina += potion.itemStamina;

            if (hero.health > hero.maxHealth)       //if added health exceedes max hp or max stamina make it equal to max
            {
                hero.health = hero.maxHealth;
            }
            else if (hero.stamina > hero.maxStamina)
            {
                hero.stamina = hero.maxStamina;
            }
        }

        static void addItemStats(Hero hero, Items item)
        {
            hero.strength += item.itemStrength;
            hero.agillity += item.itemAgility;
            hero.defence += item.itemDefence;
        }

        static void buyItem(Hero hero, Items item,Items previousItem)
        {
            if (item.GetType() == typeof(Weapons))
            {
                addItemStats(hero, item);

                if (previousItem != null)
                {
                    hero.strength -= previousItem.itemStrength;
                    hero.agillity -= previousItem.itemAgility;
                }
                previousItem = item;
            }
            else if (item.GetType() == typeof(Armor))
            {
                addItemStats(hero, item);

                if (previousItem != null)
                {
                    hero.strength -= previousItem.itemStrength;
                    hero.defence -= previousItem.itemDefence;
                }
                previousItem = item;
            }
        }
    }
}
