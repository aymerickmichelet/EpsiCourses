
using StyrelDungeon.Characters;
using System;
using System.Collections.Generic;
using System.Drawing;
using DungeonStyrel.Utils;

namespace StyrelDungeon
{
    public class UserInterface
    {
        public static void MainMenu()
        {
            do
            {
                Console.Clear();
                Util.Display("DS");
                switch (Util.Question("Menu Principal", new System.Collections.Generic.List<string>() { "Jouer", "Règles du jeu", "Crédits" }, true))
                {
                    case 1:
                        // redirection
                        break;
                    case 2:
                        RulesMenu();
                        Util.Pause();
                        break;
                    case 3:
                        CreditsMenu();
                        Util.Pause();
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            } while (true);
        }

        public static void RulesMenu()
        {
            Console.Clear();
            Util.Display("-RulesMenu-");
            Util.Display("Dans ce jeu, vous incarnez un heros et cherchez");
            Util.Display("par tout les moyens de sauver la princesse.");
            Util.Display("Pour cela, vous devrez battre tout les obstracles");
            Util.Display("et ennemies que vous trouverez sur votre passage...");
            Util.Display("---");
        }

        public static void CreditsMenu()
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

        public void GivePlayerFeedBack(Heros heros, string p_sMessageToPlayer)
        {
           
        }
    }
}
