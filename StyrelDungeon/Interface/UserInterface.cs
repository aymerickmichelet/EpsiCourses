
using StyrelDungeon.Characters;
using System;
using System.Collections.Generic;
using System.Drawing;
using DungeonStyrel.Utils;

namespace StyrelDungeon
{
    public class UserInterface
    {
        public static int MainMenu()
        {
            do
            {
                Console.Clear();
                Util.Display("DS");
                switch (Util.Question("Menu Principal", new System.Collections.Generic.List<string>() { "Jouer", "Règles du jeu", "Crédits" }, true))
                {
                    case 1:
                        return 1;
                    case 2:
                        Rules();
                        Util.Pause();
                        break;
                    case 3:
                        Credits();
                        Util.Pause();
                        break;
                    case 0:
                        return 0;
                    default:
                        break;
                }
            } while (true);
        }

        public static String GamesName()
        {
            do
            {
                Console.Clear();
                Util.Display("DS");
                Util.Display("Vous incarnez un heros du nom de...");
                Util.Display("?");
                String name = Console.ReadLine();
                if(Util.Question("Est-ce bien cela ? " + name, new List<string>() { "Oui", "Non" }, false) == 1)
                {
                    return name;
                }
                Util.Display("---");
            } while (true);
        }

        public static void GamesIntro(String name)
        {
            Console.Clear();
            Util.Display("DS");
            Util.Wait(100);
            Util.Display("Vous incarnez un heros du nom de " + name + " !");
            Util.Wait(100);
            Util.Display("Vous êtes au sein d'un donjon dans lequel se trouve");
            Util.Wait(100);
            Util.Display("5 salles. Dans chacun d'entre elle, se trouve");
            Util.Wait(100);
            Util.Display("un ennemi avec un coffre.");
            Util.Wait(100);
            Util.Display("Battez les, recupérez le contenu de chaque coffre");
            Util.Wait(100);
            Util.Display("et allez secourir la princesse !");
            Util.Wait(100);
            Util.Display("Bonne chance !");
            Util.Wait(100);
            Util.Display("---");
            Util.Wait(100);
            Util.Pause();
        }

        public static void Rules()
        {
            Console.Clear();
            Util.Display("-RulesMenu-");
            Util.Wait(100);
            Util.Display("Dans ce jeu, vous incarnez un heros et cherchez");
            Util.Wait(100);
            Util.Display("par tout les moyens de sauver la princesse.");
            Util.Wait(100);
            Util.Display("Pour cela, vous devrez battre tout les obstracles");
            Util.Wait(100);
            Util.Display("et ennemies que vous trouverez sur votre passage...");
            Util.Wait(100);
            Util.Display("---");
        }

        public static void Credits()
        {
            Console.Clear();
            Util.Display("-Credits-");
            Util.Wait(100);
            Util.Display("Aymerick MICHELET - github.com/aymerick-michelet");
            Util.Wait(100); 
            Util.Display("Basile LEQUEUX - github.com/Basile-Lequeux");
            Util.Wait(100); 
            Util.Display("---");
        }
    
        private static String Health(Character character, int health_max)
        {
            String health = "";
            for (int i = 0, imax = character.LifePoint / 5; i < imax; i++)
            {
                health += "|";
            }
            for (int i = 0, imax = health_max - health.Length; i < imax; i++)
            {
                health += "¤";
            }
            return health;
        }

        /*private static void Log(List<String> list)
        {
            String msg;
            for(int i = 3, imin = 0; i > imin; i--)
            {
                if (list.Count > i + 1)
                {
                    msg = list[list.Count - 1 - i];
                }
                else
                {
                    msg = " ";
                }
                Util.Display(msg);
            }
        }*/

        public static void Fight(Heros heros, Monster monster)
        {
            List<String> log = new List<string>();
            int health_max_monster = monster.LifePoint / 5;
            int health_max_heros = 20;
            do
            {
                Console.Clear();
                Util.Display("DS");
                Util.Display("-Salle "+(heros.IndexRoom + 1).ToString()+"-");
                Util.Display(monster.Name);
                Util.Display("Vie: "+Health(monster, health_max_monster)+">");
                Util.Display(heros.Name);
                Util.Display("Vie: "+Health(heros, health_max_heros)+">");
                if (heros.LifePoint <= 0)
                {
                    heros.IsDead = true;
                    Util.Display(heros.Name + " est mort !");
                    Util.Pause("Appuyer sur entrée pour retourner au menu.");
                    return;
                }else if (monster.LifePoint <= 0)
                {
                    Util.Display(monster.Name + " est mort !");
                    Util.Pause("Appuyer sur entrée pour continuer.");
                    return;
                }
                switch (Util.Question("Attaque:", new List<string>() { "Point: ||" }, false))
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        heros.Attack(monster);
                        log.Add(heros.Name + " attaque " + monster.Name);
                        break;
                    default:
                        break;   
                }
                // Pas eu le temps
                // monster.Attack(heros);
                // log.Add(monster.Name + " attaque " + heros.Name);

            } while (true);
        }
    }
}
