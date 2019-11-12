using System;
using System.Collections.Generic;
using System.Text;

namespace Cclm.src.Outils
{
    class Utilitaire
    {
        // int max_char_tableau = 55;

        public static void attendre(int tempo)
        {
            System.Threading.Thread.Sleep(tempo);
        }

        public static void pause()
        {
            Console.WriteLine("Appuyez sur une entrée pour continuer...");
            Console.ReadLine();
        }

        public static void pause(string commentaire)
        {
            Console.WriteLine(commentaire);
            Console.ReadLine();
        }

        public static int Questionnaire(String question, List<String> reponse_choix, List<String> reponse_reponse, Boolean sortie_sans_echec)
        {
            do
            {
                AffichageTableau("-"+question+"-");
                for(int i = 0, imax = reponse_choix.Count; i < imax; i++)
                {
                    String reste_ligne = "";
                    if (i == 0) Utilitaire.attendre(1000);
                    else Utilitaire.attendre(500);
                    for(int j = 0, jmax = (55 - 1) - 6 - reponse_choix[i].Length; j <= jmax; j++)
                    {
                        reste_ligne += " ";
                        if (j == jmax)
                            reste_ligne += "|";
                    }
                    AffichageTableau(i + 1 + " - " + reponse_choix[i]);
                }
                Utilitaire.attendre(500);
                AffichageTableau("0 - Quitter");
                AffichageTableau("---");
                AffichageTableau("|?");
                String reponse_utilisateur = Console.ReadLine().ToLower();
                AffichageTableau(reponse_utilisateur + "?|");
                for (int i = 0, imax = reponse_choix.Count; i < imax; i++)
                {
                    if(reponse_utilisateur == reponse_choix[i].ToLower() || reponse_utilisateur == (i+1).ToString())
                    {
                        AffichageTableau(reponse_reponse[i]);
                        AffichageTableau("---");
                        return i+1;
                    }
                }
                if(reponse_utilisateur == "quitter" || reponse_utilisateur == "sortie" || reponse_utilisateur == "0")
                {
                    AffichageTableau("Dommage, à bien j'espère...");
                    AffichageTableau("---");
                    return 0;
                }
                else if (sortie_sans_echec)
                {
                    AffichageTableau("Je n'ai pas très bien compris...");
                    AffichageTableau("---");
                    Utilitaire.attendre(2000);
                    Console.Clear();
                }
                else
                {
                    return -1;
                }
            } while (true);
        }

        public static void AffichageTableau(String message)
        {
            if(message == "cclm")
            {
                message = "|-=-=-=-=-=-=-= Course Contre La Montre =-=-=-=-=-=-=-|";
            }
            else if(message == "---")          // "|-----------------------------------------------------|"
            {
                message = "|-----------------------------------------------------|";
            }
            else if (message == "|?")
            {
                message = "| ";
                Console.Write(message);
                return;
            }
            else if (message.StartsWith('[') && message.EndsWith(']')) // "|---- message ----|"
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
            else if (message.StartsWith('-') && message.EndsWith('-')) // "|---- message ----|"
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
            else if (message.EndsWith('|')) // "| Console.Write |"
            {
                int imax = 55 - 4 - message.Length;
                Console.SetCursorPosition(54, Console.CursorTop - 1);
                message = "|";
            }
            else                        // "| message                                             |"
            {
                message = "| " + message;
                for(int i = 0, imax = 55-2-message.Length; i <= imax; i++)
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
