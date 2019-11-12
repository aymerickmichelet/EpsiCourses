using System;
using Cclm.src.Vehicule;
using Cclm.src.Outils;
using Cclm.src;

namespace Cclm.src
{
    class Modele
    {
        static Voiture TypeVoiture()
        {
            do
            {
                Console.Clear();
                Utilitaire.AffichageTableau("cclm");
                Utilitaire.AffichageTableau("[Choisir son modèle]");
                switch (Utilitaire.Questionnaire("Que souhaites-tu avoir comme voiture ?",
                    new System.Collections.Generic.List<string>() { "Ferrari", "Twingo" },
                    new System.Collections.Generic.List<string>() { "Bah tiens, comme c'est prévisible !", "Bon, pourquoi pas ^^" },
                    false))
                {
                    case 0:
                        return null; // Quitter
                    case 1:
                        return new Ferrari();
                    case 2:
                        return new Twingo();
                    default:
                        Utilitaire.AffichageTableau("Réponse incorrecte.");
                        Utilitaire.AffichageTableau("---");
                        Utilitaire.attendre(2000);
                        break;
                }
            } while (true);
        }

        static String CouleurVoiture()
        {
            do
            {
                Console.Clear();
                Utilitaire.AffichageTableau("cclm");
                Utilitaire.AffichageTableau("[Choisir son modèle]");
                switch (
                    Outils.Utilitaire.Questionnaire("Quelle couleur désires-tu ?",
                    new System.Collections.Generic.List<string>() { "Rouge", "Bleu", "Jaune", "Vert", "Cyan", "Orange", "Noire", "Blanche" },
                    new System.Collections.Generic.List<string>() { "Du classique toujours aussi efficace !", "pourquoi pas ^^", "Original !",
                                                            "Peu commun...", "A tester !", "Flashy !", "Beau et ténébreux !", "La puretée !" },
                    false)
                    )
                {
                    case 0:
                        return null; // Quitter
                    case 1:
                        return "Rouge";
                    case 2:
                        return "Bleu";
                    case 3:
                        return "Jaune";
                    case 4:
                        return "Vert";
                    case 5:
                        return "Cyan";
                    case 6:
                        return "Orange";
                    case 7:
                        return "Noire";
                    case 8:
                        return "Blanche";
                    default:
                        Utilitaire.AffichageTableau("Réponse incorrecte.");
                        Utilitaire.AffichageTableau("---");
                        Utilitaire.attendre(2000);
                        break;
                }
            } while (true);
        }

        static int ValiderVoiture(ref Voiture voiture)
        {
            do
            {
                Console.Clear();
                Utilitaire.AffichageTableau("cclm");
                Utilitaire.AffichageTableau("[Choisir son modèle]");
                Utilitaire.AffichageTableau("Voiture: " + (voiture.GetType() is Twingo ? "Twingo" : voiture.GetType() is Ferrari ? "Ferrari" : "---"));
                Utilitaire.AffichageTableau("Couleur: " + (voiture.getCouleur() != null ? voiture.getCouleur() : "---"));
                Utilitaire.AffichageTableau("Vitesse: " + (voiture.getVitesse() != null ? voiture.getVitesse().ToString() + " km/h" : "---"));
                switch (Utilitaire.Questionnaire("Es-tu sûr de bien vouloir cette voiture ?",
                    new System.Collections.Generic.List<string>() { "Oui", "Non" },
                    new System.Collections.Generic.List<string>() { "Ca marche !", "Bon très bien je repète..." },
                    true))
                {
                    case 0:
                        return 0; // Quitter
                    case 1:
                        return 1; // oui
                    case 2:
                        return 2; // non
                    default:
                        break;
                }
            } while (true);
        }

        public static Voiture ChoisirSonModele()
        {
            Voiture voiture = null;
            do
            {
                voiture = TypeVoiture();
                if(voiture != null)
                {
                    Utilitaire.attendre(2000);
                    voiture.setCouleur(CouleurVoiture()); // Définition de la couleur
                    if(voiture.getCouleur() != null)
                    {
                        Utilitaire.attendre(2000);
                        int valider = ValiderVoiture(ref voiture);
                        if(valider == 1)
                            return voiture;
                        else if(valider == 0)
                            return voiture = null; // Choix non fini, return voiture = null
                    }
                    else
                    {
                        return voiture = null; // Choix non fini, return voiture = null
                    }
                }
                else
                {
                    return voiture;
                }
            } while (true);
        }
    }
}
