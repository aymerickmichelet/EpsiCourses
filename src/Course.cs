using System;
using System.Collections.Generic;
using System.Text;
using Cclm.src.Vehicule;
using Cclm.src.Outils;

namespace Cclm.src
{
    class Course
    {
        public static void CourseContreLaMontre(Voiture voiture)
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
                //Rendu.VoitureInfo(voiture);
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
    }
}
