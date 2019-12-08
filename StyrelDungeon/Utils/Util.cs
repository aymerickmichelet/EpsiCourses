using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonStyrel.Utils
{
    class Util
    {
        public static void Wait(int tempo) // sleep en ms
        {
            System.Threading.Thread.Sleep(tempo);
        }

        public static void Pause()
        {
            Display("Appuyez sur une entrée pour continuer...");
            Display("---");
            Console.ReadLine();
        } // pause (attente touche espace pressé)

        public static void Pause(string commentaire) // idem pause() + commentaire
        {
            Display(commentaire);
            Display("---");
            Console.ReadLine();
        }

        public static int Question(String question, List<String> reponse_choix, bool quitter)
        { // affichage question + reponse attendu + reponse (+forcer la reponse ou non)
            Display("-" + question + "-");
            for (int i = 0, imax = reponse_choix.Count; i < imax; i++)
            {
                String reste_ligne = "";
                if (i == 0) Wait(100);
                else Wait(100);
                for (int j = 0, jmax = (55 - 1) - 6 - reponse_choix[i].Length; j <= jmax; j++)
                {
                    reste_ligne += " ";
                    if (j == jmax)
                        reste_ligne += "|";
                }
                Display(i + 1 + " - " + reponse_choix[i]);
            }
            Wait(100);
            if (quitter)
                Display("0 - Quitter");
            Display("---");
            Display("?");
            String reponse_utilisateur = Console.ReadLine().ToLower();
            //Display(reponse_utilisateur + "?|");
            for (int i = 0, imax = reponse_choix.Count; i < imax; i++) // affiche la reponse correspondante
            {
                if (reponse_utilisateur == reponse_choix[i].ToLower() || reponse_utilisateur == (i + 1).ToString())
                {
                    return i + 1;
                }
            }
            if (quitter)
            {
                if (reponse_utilisateur == "quitter" || reponse_utilisateur == "sortie" || reponse_utilisateur == "0")
                {
                    return 0;
                }
            }
            return -1;
        }

        public static void Display(String message) // affichage console indenté
        {
            if (message == "DS")
            {
                message = "|-=-=-=-=-=-=-=-=-=- DungeonStyrel -=-=-=-=-=-=-=-=-=-|";
            }
            else if (message == "---")          // "|-----------------------------------------------------|"
            {
                message = "|-----------------------------------------------------|";
            }
            else if (message == "?")
            {
                message = " ";
                Display(message);
                Console.SetCursorPosition(2, Console.CursorTop - 1);
                return;
            }
            else if (message.StartsWith("[") && message.EndsWith("]")) // "|---- message ----|"
            {
                message = message.Insert(0, "|");
                message = message.Replace("[", " ");
                message = message.Replace("]", " ");
                for (int i = 0, imax = (55 - 2) - message.Length + 2; i <= imax; i++)
                {
                    if (i < imax / 2)
                        message = message.Insert(1, " ");
                    else if (i == imax)
                        message += "|";
                    else if (i > imax / 2)
                        message += " ";
                }
            }
            else if (message.StartsWith("-") && message.EndsWith("-")) // "|---- message ----|"
            {
                message = message.Insert(0, "|");
                message = message.Replace("-", " ");
                for (int i = 0, imax = (55 - 2) - message.Length + 2; i <= imax; i++)
                {
                    if (i < imax / 2)
                        message = message.Insert(1, "-");
                    else if (i == imax)
                        message += "|";
                    else if (i > imax / 2)
                        message += "-";
                }
            }
            else if (message.EndsWith(">")) // "| Console.Write |"
            {
                message = message.Remove(message.Length - 1);
                Console.Write("|");
                Console.SetCursorPosition(54 - 1 - message.Length, Console.CursorTop);
                Console.WriteLine(message + " |");
                return;
            }
            else                        // "| message                                             |"
            {
                message = "| " + message;
                for (int i = 0, imax = 55 - 2 - message.Length; i <= imax; i++)
                {
                    message += " ";
                    if (i == imax)
                        message += "|";
                }
            }
            Console.WriteLine(message);
        }
    }


}
