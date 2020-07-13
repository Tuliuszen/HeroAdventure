using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Potions:Items
    {
        public Potions(string itemName, int itemHealth, int itemStamina, int itemCost)
        {
            this.itemName = itemName;
            this.itemHealth = itemHealth;
            this.itemStamina = itemStamina;
            this.itemCost = itemCost;
        }
    }
}
