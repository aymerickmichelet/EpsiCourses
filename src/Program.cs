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
                if(voiture != null)
                {
                    Utilitaire.AffichageTableau("Voiture: " + voiture.GetType() is Twingo ? "Twingo" : voiture.GetType() is Ferrari ? "Ferrari" : "---");
                    Utilitaire.AffichageTableau("Couleur: " + voiture.getCouleur() != null ? voiture.getCouleur() : "---");
                    Utilitaire.AffichageTableau("Vitesse: " + voiture.getVitesse() != null ? voiture.getVitesse().ToString() + "hm/h" : "---");
                }
                switch (Utilitaire.Questionnaire("Menu",
                        new System.Collections.Generic.List<string>() { "Course", "Choisir son modèle", "Chronomètre enregistrés", "Règles", "Crédits"},
                        new System.Collections.Generic.List<string>() { " ", " ", " ", " ", " " },
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

        static void Course(Voiture voiture)
        {
            voiture.setTemps(0); // temps en minutes

            Rendu.StartCclm(); // display cooldown
            do
            {
                // test victoire
                // si oui STOP
                // display info (temps, distance, vitesse, modele, couleur)
                // attente 2s
                // incrementation temps
                // test capacitespecial (ajoute du temps pour ferrari - modifie vitesse pour twingo)
                // deplacement (distance += 1/60 * vitesse |  calcule distance)
                Console.Clear();
                Utilitaire.AffichageTableau("cclm");
                Utilitaire.AffichageTableau("[Course]");
                if (voiture.getDistance() >= 50)                                                  // test victoire
                {
                    Utilitaire.AffichageTableau("-Fin de la course !-");
                    Utilitaire.AffichageTableau("Temps: " + voiture.getTemps().ToString() + " min");
                    Utilitaire.AffichageTableau("---");
                    Utilitaire.pause("Tapes sur 'entrée' pour revenir au menu principal");
                    // demander pseudo
                    // enregistrer si temps > dernier temps enregistré
                    return;
                }
                Utilitaire.AffichageTableau("Temps: " + voiture.getTemps().ToString() + " min");            // affichage info      
                Utilitaire.AffichageTableau("Distance: " + voiture.getDistance().ToString() + " / 50 km");
                Utilitaire.AffichageTableau("Vitesse: " + voiture.getVitesse().ToString() + " km / h");
                Utilitaire.AffichageTableau("---");
                Utilitaire.attendre(2000);                                                        // attente 2s
                voiture.setTemps(voiture.getTemps() + 1F);                                        // incrementation temps
                voiture.capaciteSpecial();                                                        // capaciteSpecial
                voiture.deplacement();                                                            // deplacement
            } while (true);
        }




        static void Main(string[] args)
        {

            Console.Title = "Course contre la montre";
            Voiture voiture = null;
            do
            {
                switch (Menu(voiture))
                {
                    case 1: // Course
                        if (voiture != null)
                        {
                            Course(voiture);
                        }
                        else
                        {
                            Utilitaire.AffichageTableau("Merci de bien vouloir choisir votre véhicule dans:");
                            Utilitaire.AffichageTableau("'Choisir son modèle'");
                            Utilitaire.AffichageTableau("---");
                            Utilitaire.attendre(2000);
                        }
                        break;
                    case 2: // ChoisirSonModèle
                        voiture = Modele.ChoisirSonModele();
                        break;
                    case 3: //ChronometreEnregistres - a faire mais pas obligatoire
                        Utilitaire.AffichageTableau("Arrive prochainement...");
                        Utilitaire.attendre(2000);
                        break;
                    case 4: // Règles - a modifier
                        Rendu.Regles();
                        break;
                    case 5: // Credits - a faire mais pas obligatoire
                        Rendu.Credits();
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