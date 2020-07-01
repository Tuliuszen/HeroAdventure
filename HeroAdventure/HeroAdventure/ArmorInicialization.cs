using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class ArmorInicialization
    {
        static public void addArmorList()
        {
            Armor shirt = new Armor("shirt", 1, 0, 10);
            Armor leatherArmor = new Armor("leatherArmor", 1, 1, 15);
            Armor cloak = new Armor("cloak", 3, 1, 30);
            Armor plateArmor = new Armor("plateArmor", 1, 4, 40);
            Armor ironArmor = new Armor("ironArmor", 1, 6, 50);
            Armor captainArmor = new Armor("captainArmor", 3, 6, 60);
            Armor royalArmor = new Armor("royalArmor", 4, 8, 80);
            Armor darkArmor = new Armor("darkArmor", 10, 10, 100);
            Armor strawHat = new Armor("strawHat", 15, 15, 150);

            ShopLists.armorList.Add(shirt);
            ShopLists.armorList.Add(leatherArmor);
            ShopLists.armorList.Add(cloak);
            ShopLists.armorList.Add(plateArmor);
            ShopLists.armorList.Add(ironArmor);
            ShopLists.armorList.Add(captainArmor);
            ShopLists.armorList.Add(royalArmor);
            ShopLists.armorList.Add(darkArmor);
            ShopLists.armorList.Add(strawHat);
        }

        static public void showArmorList()
        {
            int positionNumber = 0;
            foreach (Armor item in ShopLists.armorList)
            {
                Console.WriteLine(positionNumber + " " + item.itemName + " " + item.itemCost);
                positionNumber++;
            }
        }
    }
}
