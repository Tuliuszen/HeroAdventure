using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    abstract class Items
    {
        public string itemName;
        public int itemStrength, itemAgility, itemDefence;
        public int itemHealth, itemStamina;
        public int itemCost;
    }
}
