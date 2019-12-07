
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

        public static void Games()
        {
            
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
    }
}
