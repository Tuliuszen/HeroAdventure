using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.IO;


namespace HeroAdventure
{
    class SaveLoad
    {
        public static List<Game> savedGames = new List<Game>();

        public static void Save()
        {
            SaveLoad.savedGames.Add(Game.current);
            BinaryFormatter bf = new BinaryFormatter();
            //Application.persistentDataPath is a string, so if you wanted you can put that into debug.log if you want to know where save games are located
            FileStream file = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MyAppFolder"); //you can call it anything you want
            bf.Serialize(file, SaveLoad.savedGames);
            file.Close();
        }

        public static void Load()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MyAppFolder"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MyAppFolder", FileMode.Open);
                SaveLoad.savedGames = (List<Game>)bf.Deserialize(file);
                file.Close();
            }
        }
    }
}
