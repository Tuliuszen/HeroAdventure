using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace HeroAdventure
{
    class SaveLoad
    {
        public static jsonObject saveCharacter = new jsonObject();



        public static void Save(Hero hero)
        {
            SaveLoad.saveHeroStats(saveCharacter, hero);
            string jsonString;
            string jsonFile = AppDomain.CurrentDomain.BaseDirectory + @"\" + "HeroAdvJson.txt";
            jsonString = JsonConvert.SerializeObject(saveCharacter);
            File.WriteAllText(jsonFile, jsonString);
        }

        public static void Load(Hero hero)
        {
            string jsonString;
            string jsonFile = AppDomain.CurrentDomain.BaseDirectory + @"\" + "HeroAdvJson.txt";
            jsonString = File.ReadAllText(jsonFile);
            saveCharacter = JsonConvert.DeserializeObject<jsonObject>(jsonString);
            SaveLoad.loadHeroStats(saveCharacter, hero);

            Monster.addMonsters();
            WepaonsInicialization.addWeaponsList();
            ArmorInicialization.addArmorList();
            PotionsInicialization.addPotionsList();
            while (true)
            {
                Menu.mainMenuDecision(hero);
            }
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

