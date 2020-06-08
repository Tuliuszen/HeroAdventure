using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Items
    {
        public string itemName;
        public int itemStrength, itemAgility, itemDefence;
        public int itemHealth, itemStamina;
        public int itemCost;

        static public List<Weapons> weaponsList = new List<Weapons>();
        static public List<Armor> armorList = new List<Armor>();
        static public List<Potions> potionsList = new List<Potions>();

        static public void addWeaponsList()
        {
            Weapons ironKnife = new Weapons("ironKnife", 1, 0, 10);
            Weapons ironSword = new Weapons("ironKnife", 1, 1, 15);
            Weapons ironAxe = new Weapons("ironAxe", 2, 0, 15);
            Weapons silverKnife = new Weapons("silverKnife", 1, 3, 30);
            Weapons silverSword = new Weapons("silverSword", 3, 2, 40);
            Weapons bigMace = new Weapons("bigMace", 6, 0, 50);
            Weapons captainSword = new Weapons("captainSword", 6, 3, 60);
            Weapons katana = new Weapons("katana", 6, 6, 80);
            Weapons darkDaggers = new Weapons("darkDaggers", 8, 12, 100);
            Weapons kingSword = new Weapons("kingSword", 15, 15, 150);

            weaponsList.Add(ironKnife);
            weaponsList.Add(ironSword);
            weaponsList.Add(ironAxe);
            weaponsList.Add(silverKnife);
            weaponsList.Add(silverSword);
            weaponsList.Add(bigMace);
            weaponsList.Add(captainSword);
            weaponsList.Add(katana);
            weaponsList.Add(darkDaggers);
            weaponsList.Add(kingSword);

        }

        static public void addArmorList()
        {
            Armor shirt = new Armor("shirt",1,0,10);
            Armor leatherArmor = new Armor("leatherArmor",1,1,15);
            Armor cloak = new Armor("cloak",3,1,30);
            Armor plateArmor = new Armor("plateArmor", 1, 4, 40);
            Armor ironArmor = new Armor("ironArmor",1,6,50);
            Armor captainArmor = new Armor("captainArmor", 3, 6, 60);
            Armor royalArmor = new Armor("royalArmor", 4,8,80);
            Armor darkArmor = new Armor("darkArmor", 10, 10, 100);
            Armor strawHat = new Armor("strawHat", 15, 15, 150);

            armorList.Add(shirt);
            armorList.Add(leatherArmor);
            armorList.Add(cloak);
            armorList.Add(plateArmor);
            armorList.Add(ironArmor);
            armorList.Add(captainArmor);
            armorList.Add(royalArmor);
            armorList.Add(darkArmor);
            armorList.Add(strawHat);
        }

        static public void addPotionsList()
        {
            Potions miniHealthPotion = new Potions("miniHealthPotion",5,0,15);
            Potions healthPotion = new Potions("healthPotion", 10, 0, 25);
            Potions largeHealthPotion = new Potions("largeHealthPotion", 20, 0, 45);
            Potions miniStaminaPotion = new Potions("miniStaminaPotion", 0, 5, 15);
            Potions staminaPotion = new Potions("staminaPotion", 0, 10, 25);
            Potions largestaminaPotion = new Potions("largeStaminaPotion", 0, 20, 45);
            Potions greatPotion = new Potions("greatPotion", 15, 15, 70);
            Potions maxPotion = new Potions("max Potion", 25, 25, 100);

            potionsList.Add(miniHealthPotion);
            potionsList.Add(healthPotion);
            potionsList.Add(largeHealthPotion);
            potionsList.Add(miniStaminaPotion);
            potionsList.Add(staminaPotion);
            potionsList.Add(largestaminaPotion);
            potionsList.Add(greatPotion);
            potionsList.Add(maxPotion);
        }
        
        static public void showWeaponsList()
        {
            int positionNumber = 0;
            foreach (Weapons item in weaponsList)
            {
                Console.WriteLine(positionNumber + item.itemName + " " + item.itemCost);
                positionNumber++;
            }
        }
        static public void showArmorList()
        {
            int positionNumber = 0;
            foreach (Armor item in armorList)
            {
                Console.WriteLine(positionNumber + item.itemName + " " + item.itemCost);
            }
        }

        static public void showPotionsList()
        {
            int positionNumber = 0;
            foreach (Potions item in potionsList)
            {
                Console.WriteLine(positionNumber + item.itemName + " " + item.itemCost);
            }
        }

    }
}
