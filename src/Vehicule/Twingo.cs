using System;
using System.Collections.Generic;
using System.Text;
using Cclm.src;
using Cclm.src.Outils;

namespace Cclm.src.Vehicule
{
    class Twingo : Voiture
    {
        private const int probabilitee_boost = 30;
        private int vitesse_boost;
        private int cycle_boost;

        public int getVitesseBoost()
        {
            return this.vitesse_boost;
        }
        public void setVitesseBoost(int vitesse_boost)
        {
            this.vitesse_boost = vitesse_boost;
        }
        public int getCycleBoost()
        {
            return this.cycle_boost;
        }
        public void setCycleBoost(int cycle_boost)
        {
            this.cycle_boost = cycle_boost;
        }
        public int getProbatiliteBoost()
        {
            return probabilitee_boost;
        }
        public override void capaciteSpecial()
        {
            if (getCycleBoost() > 0)
                setCycleBoost(getCycleBoost() - 1);
            else
            {
                if (getVitesse() != 50)
                    setVitesse(50);
                Random rand = new Random();
                if (rand.Next(0, 100) < getProbatiliteBoost())
                {
                    DateTime start;
                    start = DateTime.Now; // début du chronometre
                    String reponse = "", mot = "vitesse";
                    do
                    {
                        Console.Clear();
                        Utilitaire.AffichageTableau("cclm");
                        Utilitaire.AffichageTableau("[Course]");
                        Utilitaire.AffichageTableau("   ");
                        Utilitaire.AffichageTableau("-Boost Disponible !-");
                        Utilitaire.AffichageTableau("Ecrivez vite le mot 'VITESSE' en moins de 3sec.");
                        Utilitaire.AffichageTableau("pour bénificier du boost !");
                        Utilitaire.AffichageTableau("---");
                        Utilitaire.AffichageTableau("|?");
                        reponse = Console.ReadLine().ToLower();
                        Utilitaire.AffichageTableau(reponse + "?|");
                        Utilitaire.AffichageTableau("---");
                    } while (reponse != mot);
                    if ((DateTime.Now - start).Seconds <= 3)
                    {
                        this.setCycleBoost(1);
                        this.setVitesse(this.getVitesseBoost());
                        Utilitaire.AffichageTableau("Boost Activé !");
                    }
                    else
                    {
                        Utilitaire.AffichageTableau("Le boost n'a pas été activé :(");
                    }
                    Utilitaire.AffichageTableau("---");
                }
            }
        }

        public Twingo()
        {
            setVitesseBoost(120);
            setVitesse(50);
            setCycleBoost(0);
        }

    }
}
