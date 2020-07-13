using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class PotionsInicialization
    {
        static public void addPotionsList()
        {
            Potions miniHealthPotion = new Potions("miniHealthPotion", 5, 0, 15);
            Potions healthPotion = new Potions("healthPotion", 10, 0, 25);
            Potions largeHealthPotion = new Potions("largeHealthPotion", 20, 0, 45);
            Potions miniStaminaPotion = new Potions("miniStaminaPotion", 0, 5, 15);
            Potions staminaPotion = new Potions("staminaPotion", 0, 10, 25);
            Potions largestaminaPotion = new Potions("largeStaminaPotion", 0, 20, 45);
            Potions greatPotion = new Potions("greatPotion", 15, 15, 70);
            Potions maxPotion = new Potions("max Potion", 25, 25, 100);

            ShopLists.potionsList.Add(miniHealthPotion);
            ShopLists.potionsList.Add(healthPotion);
            ShopLists.potionsList.Add(largeHealthPotion);
            ShopLists.potionsList.Add(miniStaminaPotion);
            ShopLists.potionsList.Add(staminaPotion);
            ShopLists.potionsList.Add(largestaminaPotion);
            ShopLists.potionsList.Add(greatPotion);
            ShopLists.potionsList.Add(maxPotion);
        }

        static public void showPotionsList()
        {
            int positionNumber = 0;
            foreach (Potions item in ShopLists.potionsList)
            {
                Console.WriteLine(positionNumber + " " + item.itemName + " " + item.itemCost);
                positionNumber++;
            }
        }
    }
}
