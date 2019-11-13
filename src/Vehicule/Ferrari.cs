using System;
using System.Collections.Generic;
using System.Text;
using Cclm.src;
using Cclm.src.Outils;

namespace Cclm.src.Vehicule
{
    class Ferrari : Voiture
    {
        private const int probabilite_panne = 60;
        private float temps_reparation = 0;
        private List<String> composants = new List<string>() {
            "moteur",
            "roue",
            "roue",
            "roue",
            "roue",
            "volant",
            "frein",
            "frein",
            "frein",
            "frein"
        };

        public float getProbabilitePanne()
        {
            return probabilite_panne;
        }
        public float getTempsReparation()
        {
            return this.temps_reparation;
        }
        public void setTempsReparation(float temps_reparation)
        {
            this.temps_reparation = temps_reparation;
        }
        public List<string> getComposants()
        {
            return this.composants;
        }
        public override void capaciteSpecial()
        {
            Random rand = new Random();
            if (rand.Next(0, 100) < probabilite_panne)
            {
                int index = rand.Next(0, getComposants().Count);
                String composant = getComposants()[index];
                
                DateTime start = DateTime.Now; // début du chronometre
                TimeSpan time;
                String reponse;
                do
                {
                    Console.Clear();
                    Utilitaire.AffichageTableau("cclm");
                    Utilitaire.AffichageTableau("[Course]");
                    Utilitaire.AffichageTableau("   ");
                    Utilitaire.AffichageTableau("-Reparation demandée !-");
                    Utilitaire.AffichageTableau("Dépèche toi, le temps est compté !");
                    Utilitaire.AffichageTableau("Composant cassé: " + composant);
                    Utilitaire.AffichageTableau("Pour le réparer, réécrit le !");
                    Utilitaire.AffichageTableau("|?");
                    reponse = Console.ReadLine();
                    Utilitaire.AffichageTableau(reponse + "?|");
                    Utilitaire.AffichageTableau("---");
                } while (reponse != composant);
                time = DateTime.Now - start; // fin du chronometre
                setTemps(getTemps() + time.Seconds / 60F);
            }
            Utilitaire.AffichageTableau("---");
        }

        public Ferrari()
        {
            setTempsReparation(0);
            setVitesse(120);
        }


    }
}
