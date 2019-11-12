using System;
using System.Collections.Generic;
using System.Text;

namespace Cclm.src.Outils
{
    class Rendu
    {
        public static void Regles() // a modifier
        {
            Console.WriteLine("|-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= Course Contre la Monte =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-|");
            Utilitaire.attendre(1000);
            Console.WriteLine("| 'Course Contre La Montre' (CCLM) est un jeu de voiture en mode contre la montre            |");
            Utilitaire.attendre(750);
            Console.WriteLine("| Le but est de finir le parcourt de 50 km le plus rapidement possible !                     |");
            Utilitaire.attendre(750);
            Console.WriteLine("| Pour cela, vous aurez la possibilité de:                                                   |");
            Utilitaire.attendre(750);
            Console.WriteLine("|         choisir le modèle de voiture,                                                      |");
            Utilitaire.attendre(750);
            Console.WriteLine("|         la couleur,                                                                        |");
            Utilitaire.attendre(750);
            Console.WriteLine("|         ainsi que d'éventuelle bonus !                                                     |");
            Utilitaire.attendre(750);
            Console.WriteLine("| Mais prenez garde ! Si vous pouvez avoir des bonus, vous pouvez également avoir des malus !|");
            Utilitaire.attendre(750);
            Console.WriteLine("| A vos marques !                                                                            |");
            Utilitaire.attendre(750);
            Console.WriteLine("| Prêt ?                                                                                     |");
            Utilitaire.attendre(750);
            Console.WriteLine("| Partez !                                                                                   |");
            Utilitaire.attendre(750);
            Console.WriteLine("|-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-|");
            Utilitaire.pause();
            Console.Clear();
        }

        public static void Credits()
        {
            // a faire
        }

        public static void StartCclm()
        {
            Console.Clear();
            Console.WriteLine("Lancement de la partie dans...");
            Utilitaire.attendre(1000);
            Console.WriteLine("3");
            Utilitaire.attendre(1000);
            Console.WriteLine("2");
            Utilitaire.attendre(1000);
            Console.WriteLine("1");
            Utilitaire.attendre(1000);
            Console.WriteLine("Gooo !");
            Utilitaire.attendre(1000);
        }



        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("|-=-=-=-=-=-=-= Course Contre La Montre =-=-=-=-=-=-=-|");
            Console.WriteLine("|----------------------- Menu ------------------------|");
            Console.WriteLine("| 1 - Commencer                                       |");
            Console.WriteLine("| 2 - Choisir son modèle                              |");
            Console.WriteLine("| 3 - Chrono enregistrés                              |");
            Console.WriteLine("| 4 - Règles                                          |");
            Console.WriteLine("| 5 - Crédits                                         |");
            Console.WriteLine("| 6 - Quitter                                         |");
            Console.WriteLine("|-----------------------------------------------------|");

        }

    }



}
