using System;
using Cclm.src.Vehicule;
using Cclm.src.Outils;
using Cclm.src;

namespace Cclm.src
{
    class Modele
    {
        static Voiture TypeVoiture() // definition de modele de voiture
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
                        Utilitaire.pause();
                        break;
                }
            } while (true);
        }

        static String CouleurVoiture() // definition de couleur de voiture
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
                        Utilitaire.pause();
                        break;
                }
            } while (true);
        }

        static int ValiderVoiture(ref Voiture voiture) // confirmer choix
        {
            do
            {
                Console.Clear();
                Utilitaire.AffichageTableau("cclm");
                Utilitaire.AffichageTableau("[Choisir son modèle]");
                Rendu.VoitureInfo(voiture);
                switch (Utilitaire.Questionnaire("Es-tu sûr de bien vouloir cette voiture ?",
                    new System.Collections.Generic.List<string>() { "Oui", "Non" },
                    new System.Collections.Generic.List<string>() { "Ca marche !", "Bon très bien je repète..." },
                    false))
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

        public static Voiture ChoisirSonModele() // main de choisirsonmodele
        {
            Voiture voiture = null;
            do
            {
                voiture = TypeVoiture(); // definition du modele de voiture
                if(voiture != null)
                {
                    Utilitaire.attendre(750);
                    voiture.setCouleur(CouleurVoiture()); // Définition de la couleur
                    if(voiture.getCouleur() != null)
                    {
                        Utilitaire.attendre(750);
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
