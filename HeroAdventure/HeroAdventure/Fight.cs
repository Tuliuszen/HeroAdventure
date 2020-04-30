using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAdventure
{
    class Fight
    {
        static int damageTaken;
        static int enemyMaxHp;
        static string decision;
        static int monsterDecision;

        static Random rnd = new Random();
        static public void fightMonster(Hero hero, Monster currentEnemy)
        {
            Console.WriteLine("Your Enemy will be " + currentEnemy.monsterName);
            Console.WriteLine("Lvl " + currentEnemy.monsterLvl);
            Console.WriteLine("Health " + currentEnemy.monsterHealth);
            Console.WriteLine("Stamina " + currentEnemy.monsterStamina);
            Console.WriteLine("Strength " + currentEnemy.monsterStrength);
            Console.WriteLine("Agility " + currentEnemy.monsterAgility);
            Console.WriteLine("Defence " + currentEnemy.monsterDefence);
            Console.WriteLine("Gold " + currentEnemy.monsterGold);
            Console.WriteLine("Exp " + currentEnemy.monsterExp);
            Console.WriteLine("VS Player:");
            Console.WriteLine("Hero Stats:");
            Console.WriteLine("Lvl " + hero.heroLevel);
            Console.WriteLine("Health " + hero.health);
            Console.WriteLine("Stamina " + hero.stamina);
            Console.WriteLine("Strength " + hero.strength);
            Console.WriteLine("Agility " + hero.agillity);
            Console.WriteLine("Defence " + hero.defence);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();

            enemyMaxHp = currentEnemy.monsterHealth;
            
            while(hero.health > 0 && currentEnemy.monsterHealth > 0)
            {
                
                if (hero.agillity >= currentEnemy.monsterAgility + 5)
                {
                    for(int i = 0; i < 2; i++)
                    {
                        heroAttack(hero, currentEnemy);
                    }
                    monsterAttack(hero, currentEnemy);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(hero.agillity+5 <= currentEnemy.monsterAgility )
                {
                    for (int i = 0; i < 2; i++)
                    {
                        monsterAttack(hero, currentEnemy);
                    }
                    heroAttack(hero, currentEnemy);
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    heroAttack(hero, currentEnemy);
                    monsterAttack(hero, currentEnemy);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            
            
            if(hero.health > 0)
            {
                Console.WriteLine("You win!");
                currentEnemy.monsterHealth = enemyMaxHp;
                hero.experience += currentEnemy.monsterExp;
                hero.gold += currentEnemy.monsterGold;
                Console.WriteLine("Hero exp: " + hero.experience + " Hero gold: " + hero.gold);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You lose");
                Console.WriteLine("Press any key to leave the game");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        static public void heroAttack(Hero hero, Monster currentEnemy)
        {
            Console.WriteLine("How do you want to attack enemy?");
            Console.WriteLine("1.Normal attack");
            Console.WriteLine("2.Super Attack (2xstrength but -5 stamina)");
            Console.WriteLine("Type 1 or 2");
            decision = Console.ReadLine(); 
            if (decision == "1")
            {
                damageTaken = hero.strength - currentEnemy.monsterDefence;
                currentEnemy.monsterHealth -= damageTaken;
                Console.WriteLine("Hero attack  " + damageTaken);
                Console.WriteLine("Monster hp left: " + currentEnemy.monsterHealth);
                Console.WriteLine("Hero stamina: " + hero.stamina);

            }
            else
            {
                if (hero.stamina >= 5)
                {
                    damageTaken = 2 * (hero.strength - currentEnemy.monsterDefence);
                    currentEnemy.monsterHealth -= damageTaken;
                    hero.stamina -= 5;
                    Console.WriteLine("Hero attack  " + damageTaken);
                    Console.WriteLine("Monster hp left: " + currentEnemy.monsterHealth);
                    Console.WriteLine("Hero stamina: " + hero.stamina);
                }
                else
                {
                    Console.WriteLine("Not enough stamina so normal attack");
                    damageTaken = hero.strength - currentEnemy.monsterDefence;
                    currentEnemy.monsterHealth -= damageTaken;
                    Console.WriteLine("Hero attack  " + damageTaken);
                    Console.WriteLine("Monster hp left: " + currentEnemy.monsterHealth);
                    Console.WriteLine("Hero stamina: " + hero.stamina);
                }
            }
            
            
        }

        static public void monsterAttack(Hero hero, Monster currentEnemy)
        {
            monsterDecision = rnd.Next(1);
            if(monsterDecision == 1)
            {
                if(currentEnemy.monsterStamina >= 5)
                {
                    Console.WriteLine("Super Attack incoming");
                    damageTaken = 2 * (currentEnemy.monsterStrength - hero.defence);
                    hero.health -= damageTaken;
                    currentEnemy.monsterStamina -= 5;
                    Console.WriteLine("Hero took  " + damageTaken);
                    Console.WriteLine("Hero hp left: " + hero.health);
                    Console.WriteLine("Monster stamina: " + currentEnemy.monsterStamina);
                }
                else
                {
                    damageTaken = currentEnemy.monsterStrength - hero.defence;
                    hero.health -= damageTaken;
                    Console.WriteLine("Hero took  " + damageTaken);
                    Console.WriteLine("Hero hp left: " + hero.health);
                    Console.WriteLine("Monster stamina: " + currentEnemy.monsterStamina);
                }
                
            }
            else
            {
                damageTaken = currentEnemy.monsterStrength - hero.defence;
                hero.health -= damageTaken;
                Console.WriteLine("Hero took  " + damageTaken);
                Console.WriteLine("Hero hp left: " + hero.health);
                Console.WriteLine("Monster stamina: " + currentEnemy.monsterStamina);
            }
        }
    }
}
