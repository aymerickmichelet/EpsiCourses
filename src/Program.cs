using System;
using Cclm.src.Vehicule;
using Cclm.src.Outils;
using Cclm.src;

namespace Cclm.src
{
    class Program
    {
        static int Menu(Voiture voiture)
        {
            do
            {
                Console.Clear();
                Utilitaire.AffichageTableau("cclm");
                if (voiture != null)
                    Rendu.VoitureInfo(voiture);
                switch (Utilitaire.Questionnaire("Menu",
                        new System.Collections.Generic.List<string>() { "Course", "Choisir son modèle", "Chronomètre enregistrés", "Règles", "Crédits"},
                        new System.Collections.Generic.List<string>() { "Veuillez tout d'abord choisir votre modèle...", " ", "Arrive prochainement...", " ", "par aymerick michelet" },
                        false))
                {
                    case 0:
                        return 0; // Quitter
                    case 1: // course 
                        return 1;
                    case 2: // choisir modèle
                        return 2;
                    case 3: // chrono
                        return 3;
                    case 4: // regles
                        return 4;
                    case 5: // credits
                        return 5;
                    default:
                        Utilitaire.AffichageTableau("Réponse incorrecte.");
                        Utilitaire.AffichageTableau("---");
                        Utilitaire.attendre(2000);
                        break;
                }
            } while (true);
        }

        static void Main(string[] args)
        {
            Console.Title = "Course contre la montre";
            Console.WindowWidth = 55; // modifier taille fenetre
            Voiture voiture = null;
            do
            {
                switch (Menu(voiture))
                {
                    case 1: // Course
                        if (voiture != null)
                        {
                            Course.CourseContreLaMontre(voiture);
                        }
                        else
                        {
                            Utilitaire.pause();
                        }
                        break;
                    case 2: // ChoisirSonModèle
                        voiture = Modele.ChoisirSonModele();
                        break;
                    case 3: //ChronometreEnregistres - a faire mais pas obligatoire
                        Utilitaire.attendre(2000);
                        break;
                    case 4: // Règles
                        Rendu.Regles();
                        break;
                    case 5: // Credits
                        Utilitaire.pause("Tapes sur 'entrée' pour revenir au menu principal");
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }

            } while (true);
        }
    }
};