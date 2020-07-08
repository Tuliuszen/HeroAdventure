using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class jsonObject
    {
        public string heroName;
        public int strength, agillity, defence, stamina, health, maxStamina, maxHealth;
        public int heroLevel, experience, gold;
        public Items weapon, armor;

        public jsonObject(string heroName, int heroLevel, int experience, int gold, int strength, int agillity, int defence, int stamina, int health, int maxStamina, int maxHealth, Items weapon, Items armor)
        {
            this.heroName = heroName;
            this.heroLevel = heroLevel;
            this.experience = experience;
            this.gold = gold;
            this.strength = strength;
            this.agillity = agillity;
            this.defence = defence;
            this.stamina = stamina;
            this.health = health;
            this.maxStamina = maxStamina;
            this.maxHealth = maxHealth;
            this.weapon = weapon;
            this.armor = armor;
        }

        public static void saveHeroStats(jsonObject saved, Hero hero)
        {
            saved.heroName = hero.heroName;
            saved.heroLevel = hero.heroLevel;
            saved.experience = hero.experience;
            saved.gold = hero.gold;
            saved.strength = hero.strength;
            saved.agillity = hero.agillity;
            saved.defence = hero.defence;
            saved.stamina = hero.stamina;
            saved.health = hero.health;
            saved.maxStamina = hero.maxStamina;
            saved.maxHealth = hero.maxHealth;
            saved.weapon = hero.weapon;
            saved.armor = hero.armor;
        }

        public static void loadHeroStats(jsonObject saved, Hero hero)
        {
            hero.heroName = saved.heroName;
            hero.heroLevel = saved.heroLevel;
            hero.experience = saved.experience;
            hero.gold = saved.gold;
            hero.strength = saved.strength;
            hero.agillity = saved.agillity;
            hero.defence = saved.defence;
            hero.stamina = saved.stamina;
            hero.health = saved.health;
            hero.maxStamina = saved.maxStamina;
            hero.maxHealth = saved.maxHealth;
            hero.weapon = saved.weapon;
            hero.armor = saved.armor;
        }
    }
}
