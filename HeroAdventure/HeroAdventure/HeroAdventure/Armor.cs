using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Armor:Items
    {
        public Armor(string itemName,int itemAgility, int itemDefence, int itemCost)
        {
            this.itemName = itemName;
            this.itemAgility = itemAgility;
            this.itemDefence = itemDefence;
            this.itemCost = itemCost;
        }
    }
}
