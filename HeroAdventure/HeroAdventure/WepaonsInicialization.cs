using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class WepaonsInicialization
    {
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

            ShopLists.weaponsList.Add(ironKnife);
            ShopLists.weaponsList.Add(ironSword);
            ShopLists.weaponsList.Add(ironAxe);
            ShopLists.weaponsList.Add(silverKnife);
            ShopLists.weaponsList.Add(silverSword);
            ShopLists.weaponsList.Add(bigMace);
            ShopLists.weaponsList.Add(captainSword);
            ShopLists.weaponsList.Add(katana);
            ShopLists.weaponsList.Add(darkDaggers);
            ShopLists.weaponsList.Add(kingSword);

        }

        static public void showWeaponsList()
        {
            int positionNumber = 0;
            foreach (Weapons item in ShopLists.weaponsList)
            {
                Console.WriteLine(positionNumber + item.itemName + " " + item.itemCost);
                positionNumber++;
            }
        }
    }
}
