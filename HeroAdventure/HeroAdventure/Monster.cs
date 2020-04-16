using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Monster
    {
        public string monsterName;
        public int monsterStrength, monsterAgility, monsterDefence, monsterHealth, monsterStamina;
        public int monsterLvl, monsterExp, monsterGold;

        Monster zombiee;
        public Monster(string monsterName, int monsterLvl, int monsterStrength, int monsterAgility, int monsterDefence, int monsterHealth, int monsterStamina, int monsterExp, int monsterGold)
        {
            this.monsterName = monsterName;
            this.monsterLvl = monsterLvl;
            this.monsterStrength = monsterStrength;
            this.monsterAgility = monsterAgility;
            this.monsterDefence = monsterDefence;
            this.monsterHealth = monsterHealth;
            this.monsterStamina = monsterStamina;
            this.monsterExp = monsterExp;
            this.monsterGold = monsterGold;
        }

        public List<Monster> allMonsters = new List<Monster>();

        public void addMonsters()
        {
            Monster Zombie = new Monster("zombie", 1, 3, 3, 3, 15, 5, 5, 3);
            Monster Skeleton = new Monster("Skeleton", 2, 6, 4, 2, 15, 10, 8, 5);
            Monster Spider = new Monster("Spider", 3, 7, 6, 4, 20, 15, 12, 10);
            Monster Orc = new Monster("Orc", 4, 10, 7, 6, 25, 20, 16, 15);
            Monster Golem = new Monster("Golem",5,12,4,10,35,5,24,20);
            Monster Cyclops = new Monster("Cyclops",6,20,2,10,30,15,30,30);
            Monster Ghost = new Monster("Ghost",7,12,30,9,25,40,55,25);
            Monster Giant = new Monster("Giant",8,30,5,25,50,30,30,100);
            Monster Undead = new Monster("Undead",9,40,30,20,50,30,70,200);
            Monster Dragon = new Monster("Dragon",10,50,50,50,100,100,100,500);
            allMonsters.Add(Zombie);
            allMonsters.Add(Skeleton);
            allMonsters.Add(Spider);
            allMonsters.Add(Orc);
            allMonsters.Add(Golem);
            allMonsters.Add(Cyclops);
            allMonsters.Add(Ghost);
            allMonsters.Add(Giant);
            allMonsters.Add(Undead);
            allMonsters.Add(Dragon);
        }


    }
}
