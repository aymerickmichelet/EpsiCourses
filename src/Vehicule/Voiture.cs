using System;
using System.Collections.Generic;
using System.Text;
using Cclm.src.Outils;

namespace Cclm.src.Vehicule
{
    public abstract class Voiture
    {
        private int vitesse;
        private String couleur;
        private float distance;
        private float temps;

        public int getVitesse()
        {
            return this.vitesse;
        }
        public void setVitesse(int vitesse)
        {
            this.vitesse = vitesse;
        }
        public String getCouleur()
        {
            return this.couleur;
        }
        public void setCouleur(string couleur)
        {
            this.couleur = couleur;
        }
        public float getDistance()
        {
            return this.distance;
        }
        public void setDistance(float distance)
        {
            this.distance = distance;
        }
        public float getTemps()
        {
            return this.temps;
        }
        public void setTemps(float temps)
        {
            this.temps = temps;
        }
        public void deplacement()
        {
            float delta_distance = getVitesse() / 60F;
            setDistance(getDistance() + delta_distance);
            if (getDistance() > 50)
                setDistance(50);
        }
        public abstract void capaciteSpecial();
    }
}
