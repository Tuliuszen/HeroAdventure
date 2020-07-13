using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Weapons:Items
    {
        
        public Weapons(string itemName, int itemStrength, int itemAgility, int itemCost)
        {
            this.itemName = itemName;
            this.itemStrength = itemStrength;
            this.itemAgility = itemAgility;
            this.itemCost = itemCost;
        }
    }
}
