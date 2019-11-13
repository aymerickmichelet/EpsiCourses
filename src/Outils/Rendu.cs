using System;
using System.Collections.Generic;
using Cclm.src.Vehicule;
using System.Text;

namespace Cclm.src.Outils
{
    class Rendu
    {
        public static void Regles() // a modifier
        {
            Console.Clear();
            Utilitaire.AffichageTableau("cclm");
            Utilitaire.attendre(300);
            Utilitaire.AffichageTableau(" ");
            Utilitaire.AffichageTableau("'Course Contre La Montre' (CCLM) est un jeu de");
            Utilitaire.attendre(100);
            Utilitaire.AffichageTableau("voiture en mode contre la montre.");
            Utilitaire.attendre(100);
            Utilitaire.AffichageTableau(" ");
            Utilitaire.AffichageTableau("Le but est de finir le parcourt de 50 km");
            Utilitaire.attendre(100);
            Utilitaire.AffichageTableau("le plus rapidement possible !");
            Utilitaire.attendre(100);
            Utilitaire.AffichageTableau(" ");
            Utilitaire.AffichageTableau("Pour cela, vous aurez la possibilité de:");
            Utilitaire.attendre(100);
            Utilitaire.AffichageTableau("          choisir le modèle de voiture,");
            Utilitaire.attendre(100);
            Utilitaire.AffichageTableau("          ainsi que sa couleur !");
            Utilitaire.attendre(100);
            Utilitaire.AffichageTableau(" ");
            Utilitaire.AffichageTableau("Mais prenez garde !");
            Utilitaire.attendre(100);
            Utilitaire.AffichageTableau("En fonction du choix du modèle, vous vous verez");
            Utilitaire.attendre(100);
            Utilitaire.AffichageTableau("attribuer pendant la partie, des bonus ou des malus !");
            Utilitaire.attendre(100);
            Utilitaire.AffichageTableau(" ");
            Utilitaire.AffichageTableau("Bonne chance !");
            Utilitaire.attendre(100);
            Utilitaire.AffichageTableau("---");
            Utilitaire.pause("Tapes sur 'entrée' pour revenir au menu principal");
        }

        public static void StartCclm()
        {
            List<String> trois = new List<string>{"[  ____   ]",
                                                  "[ |___ \\ ]",
                                                  "[   __) | ]",
                                                  "[  |__<   ]",
                                                  "[  ___) | ]",
                                                  "[ |____/  ]"};

            List<String> deux = new List<string>{"[   ___    ]",
                                                 "[  |__ \\  ]",
                                                 "[     ) |  ]",
                                                 "[    / /   ]",
                                                 "[   / /_   ]",
                                                 "[  |____|  ]"};

            List<String> un = new List<string> {"[    __   ]",
                                                "[   /_ |  ]",
                                                "[    | |  ]",
                                                "[    | |  ]",
                                                "[    | |  ]",
                                                "[    |_|  ]"};

            List<String> go = new List<string>{"[   _____ ____    ]",
                                               "[  / ____|/ __ \\  ]",
                                               "[ | |  __| |  | | ]",
                                               "[ | | |_ | |  | | ]",
                                               "[ | |__| | |__| | ]",
                                               "[  \\_____|\\____/   ]"};
            List<List<String>> list = new List<List<string>> { trois, deux, un, go};

            foreach (List<String> rebour_char in list)
            {
                Console.Clear();
                Utilitaire.AffichageTableau("cclm");
                Utilitaire.AffichageTableau("Lancement de la partie dans...");
                foreach (String ligne in rebour_char)
                {
                    Utilitaire.AffichageTableau(ligne);
                }
                Utilitaire.AffichageTableau("---");
                Utilitaire.attendre(1000);
            }
        }


        public static void VoitureInfo(Voiture voiture)
        {
            String modele;
            String couleur;
            String vitesse;
            if (voiture.GetType() == typeof(Twingo))
            {
                modele = "Twingo";
            }
            else if (voiture.GetType() == typeof(Ferrari))
                modele = "Ferrari";
            else
                modele = "---";
            couleur = voiture.getCouleur();
            vitesse = voiture.getVitesse().ToString();

            Utilitaire.AffichageTableau("Voiture: " + modele);
            Utilitaire.AffichageTableau("Couleur: " + couleur);
            Utilitaire.AffichageTableau("Vitesse: " + vitesse);
        }
    }
}
