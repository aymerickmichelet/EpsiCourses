#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define CLEAR system("cls"); //divers raccourcis
#define PAUSE system("pause");
#define FLUSH fflush(stdin);
#define NB_SKIEUR_MAX 20 //nombre de skieur maximum
#define NB_CHAR_NOM_MAX 20 //nombre de caractère maximum pour le identite.nom


struct identite{
  int dossard;
  char nom[NB_CHAR_NOM_MAX];
  char nationnalite[3];
  int minutes;
  int secondes;
  int centiemes;
};
typedef struct identite identite;


void parisXGames(){
  printf("==================================================================\n");
  printf("                            BIENVENUE                           \n");
  printf("  _____        _____  _____  _____  __   __  ___   ___  __  ___  \n");
  printf(" |  __ \\ /\\   |  __ \\|_   _|/ ____| \\ \\ / / |__ \\ / _ \\/_ |/ _ \\  \n");
  printf(" | |__) /  \\  | |__) | | | | (___    \\ V /     ) | | | || | (_) | \n");
  printf(" |  ___/ /\\ \\ |  _  /  | |  \\___ \\    > <     / /| | | || |\\__, | \n");
  printf(" | |  / ____ \\| | \\ \\ _| |_ ____) |  / . \\   / /_| |_| || |  / /  \n");
  printf(" |_| /_/    \\_\\_|  \\_\\_____|_____/  /_/ \\_\\ |____|\\___/ |_| /_/   \n");
  printf("                                                                  \n");
  printf("==================================================================\n");
}
void affichageEnteteTableau(){ //j'ai fait plusieurs fonction d'affichage de tableau pour eviter les trop nombreuses répétitions
  printf("|Pl|Nd|          Nom          |Nat |  Temps   |\n");
  printf("|--|--|-----------------------|----|----------|\n");
}
void affichagePlTableau(int place){
  printf("|%2d", place);
}
void affichageNdTableau(int numero_dossard){
  printf("|%2d| ", numero_dossard);
}
void affichageNomTableau(int id_nom, identite identite[]){
  int taille_nom;
  taille_nom = 20 - strlen(identite[id_nom].nom);
  for (int k = 0, kmax = taille_nom; k < kmax; k++) printf(" ");
  printf(" %s ", identite[id_nom].nom);
}
void affichageNatTableau(char nat[3]){
  printf("| %s | ", nat);
}
void affichageTempsTableau(int id_temps, identite identite[]){
  if(identite[id_temps].secondes == -1) printf("Forf.    |\n");
  else if(identite[id_temps].secondes == 0) printf("Disq.    |\n");
  else if(identite[id_temps].secondes > 0){
      printf("%2d:%2d:%2d |\n", identite[id_temps].minutes, identite[id_temps].secondes, identite[id_temps].centiemes);
  }
}
void affichageFinTableau(){
  printf("|--|--|-----------------------|----|----------|\n");
  printf("/Pl: Place - Nd: Numero Dossard - Nat: Nationnalite/\n");
}
identite inscription(int dossard){ //fonction qui lance un formulaire à l'utilisateur, et qui retrourne le struct.
      identite skieur;

      do { //formulaire nom
        CLEAR;
        FLUSH;
        printf("-=-=-=-=Nom=-=-=-=-\n");
        gets(skieur.nom);
      } while(strlen(skieur.nom) < 1 || strlen(skieur.nom) > NB_CHAR_NOM_MAX);

      do { //formulaire nationnalite
        CLEAR;
        FLUSH;
        printf("-=-=-=Nationnalite=-=-=-\n");
        printf("FR - Francais\nIT - Italien\nGE - Allemand\nNO - Norvegien\n");
        gets(skieur.nationnalite);
        if (strcmp(skieur.nationnalite, "FR\0") == 0 || strcmp(skieur.nationnalite, "IT\0") == 0 || //si les caractères écrient sont corrects, rien ne se passe.
            strcmp(skieur.nationnalite, "GE\0") == 0 || strcmp(skieur.nationnalite, "NO\0") == 0) {
        }else{ //Sinn erreur + reboucle
          printf("Reponse incorrect\n");
          skieur.nationnalite[0] = '0'; skieur.nationnalite[1] = '\0';
          PAUSE;
        }
    } while(strcmp(skieur.nationnalite, "0\0") == 0);

    skieur.dossard = dossard; //attribution du numero de dossard

    return skieur;
}
int structCompare(int skieurmax, identite identite[]){//permet de savoir si deux structs dans le tableau de struct sont identiques (retrourne 1) ou pas (retrourne 0)
  for (int i = 0, imax = skieurmax; i <= imax; i++) {
    for (int j = 0, jmax = skieurmax; j <= jmax; j++) {
      if(i == j) continue;
      if (strcmp(identite[i].nom, identite[j].nom) == 0) { //nom identique
        if (strcmp(identite[i].nationnalite, identite[j].nationnalite) == 0) { //nationnalite identique
          return 1; //erreur
        }
      }
    }
  }
  return 0;
}
void recapInscriptionDos(int nbskieur, identite identite[]) { //affichage
    affichageEnteteTableau();
    for (int i = 0, imax = nbskieur; i < nbskieur; i++){
      affichagePlTableau(0);
      affichageNdTableau(i);
      affichageNomTableau(i, identite);
      affichageNatTableau(identite[i].nationnalite);
      printf("         |\n");
    }
    affichageFinTableau();}
void modifInscription(int nbskieur, identite identite[]){
  int rep;
  char nom[NB_CHAR_NOM_MAX], nat[3];

  do {
    CLEAR; FLUSH;
    printf("Quel inscription voulez-vous modifier ?\n");
    recapInscriptionDos(nbskieur, identite);
    scanf("%d", &rep);
  } while(rep < 0 || rep > nbskieur);

  //copie de l'inscription modifiée
  strcpy(nom, identite[rep].nom);
  strcpy(nat, identite[rep].nationnalite);

  //modification
  identite[rep] = inscription(rep);
  //vérification
  if(structCompare(nbskieur, identite) == 1) { //si identifiant et nat déjà utilisé, recopie ancienne inscription
    strcpy(identite[rep].nom, nom);
    strcpy(identite[rep].nationnalite, nat);
    printf("Cet utilisateur est deja utilise\n");
  }
}
int conversionTemps(float temps, identite identite[], int dossard){
  int minutes = 0, secondes = 0, centiemes = 0;

  secondes = temps; //arrondit le temps avec centieme à l'unité
  centiemes = (temps - secondes)*100; //obtention centiemes de secondes par soustraction
  if(secondes >= 60){
    minutes = secondes / 60;
    secondes %= 60;
  }
  identite[dossard].minutes = minutes;
  identite[dossard].secondes = secondes;
  identite[dossard].centiemes = centiemes;
  return 1;
}
void recapInscriptionNat(int nbskieur, identite identite[]) {
  char rep[3];
  do {
    CLEAR; FLUSH;
    printf("-=-=-=Nationnalite=-=-=-\n");
    printf("FR - Francais\nIT - Italien\nGE - Allemand\nNO - Norvegien\n");
    gets(rep);

    if (strcmp(rep, "FR\0") == 0 || strcmp(rep, "IT\0") == 0 ||
        strcmp(rep, "GE\0") == 0 || strcmp(rep, "NO\0") == 0) {
    }else{
      printf("Reponse incorrect\n");
      rep[0] = '0'; rep[1] = '\0';
      PAUSE;
    }
  } while(strcmp(rep, "0\0") == 0);

  affichageEnteteTableau();
  for (int i = 0, imax = nbskieur; i < nbskieur; i++){
      if(strcmp(identite[i].nationnalite, rep) == 0){ //Affiche tout les français
        affichagePlTableau(0);
        affichageNdTableau(i);
        affichageNomTableau(i, identite);
        printf("| %s |\n", identite[i].nationnalite);
      }
  }
  affichageFinTableau();
}
void affichageConversionTemps(int dossard, identite identite[]){
  printf("Etape 3 - Saisies des temps\n");
  printf("- Ecrit le temps du skieur /Discalifie = 0 - Forfait = (par defaut si aucune valeur n est entree) ou -1/\n", dossard, identite[dossard].nom, identite[dossard].nationnalite);
  affichageEnteteTableau();
  affichagePlTableau(0);
  affichageNdTableau(dossard);
  affichageNomTableau(dossard, identite);
  affichageNatTableau(identite[dossard].nationnalite);
}
int valeurMin(int tableau[], int tailleTableau){
	int result, tempo = 0;
  do { //attribution valeur result
    result = tableau[tempo];
    tempo++;
  } while(result == 0);
	for(int i = 0; i < tailleTableau; i++){
		if(tableau[i] <= result && tableau[i] != 0){
			result = tableau[i];
		}
	}
	return result;
}
int valeurId(int tableau[], int tailleTableau, int valeur){
  for(int i = 0, imax = tailleTableau; i < imax; i++) if(valeur == tableau[i]) return i;
}
void resultatFinalDos(identite identite[], int tailleTableau){
  int listeTemps[tailleTableau], tempo, taille_nom;
  CLEAR; FLUSH;
  printf("Etape 4 - Resultat final\n\n");
  affichageEnteteTableau();

  for (int i = 0, imax = tailleTableau; i < imax; i++) listeTemps[i] = identite[i].minutes*60 + identite[i].secondes + identite[i].centiemes/100;

  for (int i = 1, imax = tailleTableau; i <= imax; i++) {
    tempo = valeurId(listeTemps, tailleTableau, valeurMin(listeTemps, tailleTableau));
    listeTemps[tempo] = 0;
    affichagePlTableau(i);
    affichageNdTableau(tempo);
    affichageNomTableau(tempo, identite);
    affichageNatTableau(identite[tempo].nationnalite);
    affichageTempsTableau(tempo, identite);
  }
  affichageFinTableau();
}
void resultatFinalNat(identite identite[], int tailleTableau){
  int listeTemps[tailleTableau], tempo, taille_nom;
  char nat[3];

  do {
    CLEAR; FLUSH;
    printf("Etape 4 - Resultat final\n\n");
    printf("Nationnalite:\n");
    printf("FR - Francais\nIT - Italien\nGE - Allemand\nNO - Norvegien\n");
    gets(nat);
    if (strcmp(nat, "FR\0") == 0 || strcmp(nat, "IT\0") == 0 ||
        strcmp(nat, "GE\0") == 0 || strcmp(nat, "NO\0") == 0) {
    }else{
      printf("Reponse incorrect\n");
      nat[0] = '0'; nat[1] = '\0';
      PAUSE;
    }
} while(strcmp(nat, "0\0") == 0);

  affichageEnteteTableau();
  for (int i = 0, imax = tailleTableau; i < imax; i++) listeTemps[i] = identite[i].minutes*60 + identite[i].secondes + identite[i].centiemes/100;
  for (int i = 1, imax = tailleTableau; i <= imax; i++) {
    tempo = valeurId(listeTemps, tailleTableau, valeurMin(listeTemps, tailleTableau));
    listeTemps[tempo] = 0;
    if(strcmp(identite[tempo].nationnalite, nat) == 0){
      affichagePlTableau(i);
      affichageNdTableau(tempo);
      affichageNomTableau(tempo, identite);
      affichageNatTableau(identite[tempo].nationnalite);
      affichageTempsTableau(tempo, identite);
    }else continue;
  }
  affichageFinTableau();
}
void resultatFinalFor(identite identite[], int tailleTableau){
  int listeTemps[tailleTableau], tempo, taille_nom;

  printf("Etape 4 - Resultat final\n\n");
  affichageEnteteTableau();
  for (int i = 0, imax = tailleTableau; i < imax; i++) listeTemps[i] = identite[i].minutes*60 + identite[i].secondes + identite[i].centiemes/100;
  for (int i = 1, imax = tailleTableau; i <= imax; i++) {
    tempo = valeurId(listeTemps, tailleTableau, valeurMin(listeTemps, tailleTableau));
    listeTemps[tempo] = 0;
    if(identite[tempo].secondes == -1){
      affichagePlTableau(i); affichageNdTableau(tempo);
      affichageNomTableau(tempo, identite);
      affichageNatTableau(identite[tempo].nationnalite);
      printf("Forf.    |\n");
    }else continue;
  }
  affichageFinTableau();
}
void resultatFinalDis(identite identite[], int tailleTableau){
  int listeTemps[tailleTableau], tempo, taille_nom;

  printf("Etape 4 - Resultat final\n\n");
  affichageEnteteTableau();
  for (int i = 0, imax = tailleTableau; i < imax; i++) listeTemps[i] = identite[i].minutes*60 + identite[i].secondes + identite[i].centiemes/100;
  for (int i = 1, imax = tailleTableau; i <= imax; i++) {
    tempo = valeurId(listeTemps, tailleTableau, valeurMin(listeTemps, tailleTableau));
    listeTemps[tempo] = 0;
    if(identite[tempo].secondes == 0){
      affichagePlTableau(i);
      affichageNdTableau(tempo);
      affichageNomTableau(tempo, identite);
      affichageNatTableau(identite[tempo].nationnalite);
      printf("Disc.    |\n");
    }else continue;
  }
  affichageFinTableau();
}

//--------------------------------------------//

int etape1Menu(identite identite[]){ //OK
    char rep; int nbskieur = 0;
    do {
      CLEAR; FLUSH;
      parisXGames();
      printf("Etape 1:\n1 - Inscriptions\n* - Etape suivante\n");
      scanf("%c", &rep);
      switch(rep){
        case '1': //si utilisateur selectionne '1'
          if(nbskieur < NB_SKIEUR_MAX){ //si le nombre de participants < 20
            identite[nbskieur] = inscription(nbskieur);
            if(structCompare(nbskieur, identite) == 1){ //si inscription existe deja, on la "supprime"
                strcpy(identite[nbskieur].nom, "");
                strcpy(identite[nbskieur].nationnalite, "");
                identite[nbskieur].dossard = 0;
                printf("Cet utilisateur est deja utilise\n");
            }else nbskieur++; //sinon on increment nbskieur
          }else printf("Impossible de rajouter de nouveau skieur.\n");
          PAUSE;
        break;

        case '*': //si utilisateur selectionne '0'
          if (nbskieur > 1){} //et si le nombre de participants > 1 -> OK
          else{printf("Le nombre de skieur n'est pas suffisant...\n"); rep = '1'; PAUSE;} //sinon message erreur + boucle
        break;
      }
    } while(rep != '*');

    return nbskieur;
}
void etape2Menu(int nbskieur, identite identite[]){//OK
    char rep;

    do{
      CLEAR;
      printf("Etape 2 - Recapitulatif\n1 - Par ordre d'inscription,\n2 - Par nationnalite,\n3 - Modifier une inscription,\n* - Etape suivante.\n");
      scanf("%c", &rep); printf("\n");
      switch(rep){
        case '1': recapInscriptionDos(nbskieur, identite); PAUSE; break; //si '1', affichage skieur inscrit par dossard
        case '2': recapInscriptionNat(nbskieur, identite); PAUSE; break; //si '2', affichage skieur d'une nationnalite par dossard
        case '3': modifInscription(nbskieur, identite); PAUSE; break; //si '3', modificationInscription (Inscriptions + test si inscription deja utilise)
        case '*': break; //suite
      }
    } while(rep != '*');
}
void etape3Menu(int nbskieur, identite identite[]){//OK
  int rep, liste[nbskieur];
  float temps = -1;

  do {
    do {//Saisies du numero de dossier
      CLEAR; FLUSH;
      printf("Etape 3 - Saisies des temps\n");
      printf("A quel skieur souhaitez-vous ajouter le temps ?\n");
      recapInscriptionDos(nbskieur, identite); //affiche liste inscrit en tableau
      scanf("%d", &rep); //demande a quel utilisateur ont rajoute le temps
    } while(rep < -1 || nbskieur <= rep);

    liste[rep] = 1; //on défini à 1 la liste à l'index du skieur pour signifier qu'un temps a été rentré
    CLEAR; FLUSH; //Saisie du temps en secondes + Conversion
    affichageConversionTemps(rep, identite);
    scanf("%f", &temps);
    CLEAR;
    affichageConversionTemps(rep, identite);
    if(temps == -1){
      printf("Forf.    |\n");
      identite[rep].secondes = -1;
    }
    else if(temps == 0){
      printf("Disq.    |\n");
      identite[rep].secondes = 0;
    }
    else if(temps > 0){
        conversionTemps(temps, identite, rep); //conversion du temps de sec/centiemes - minutes/sec/cen.
        printf("%2d:%2d:%2d |\n", identite[rep].minutes, identite[rep].secondes, identite[rep].centiemes);
    }
    affichageFinTableau();
    PAUSE;

    do { //Demande nouvelle saisie ?
      CLEAR; FLUSH;
      printf("Etape 3 - Saisies des temps\n");
      printf("Voulez-vous continuer a entrer des temps ?\n- Oui: 0\n- Non: 1\n");
      scanf("%d", &rep);
    } while(rep < 0 || rep > 1);

  } while(rep == 0);

  for (int i = 0; i < nbskieur; i++) if(liste[i] != 1) identite[i].secondes = -1;
}
void etape4Menu(int nbskieur, identite identite[]){
  char rep;
  do{
    CLEAR;
    printf("Etape 4 - Resultats\n1 - Classement final,\n2 - Resultat par nationalite,\n3 - Liste des skieurs disqualifies,\n4 - Liste des skieurs forfaits,\n* - Etape suivante.\n");
    scanf("%c", &rep);
    switch(rep){
      case '1': resultatFinalDos(identite, nbskieur); PAUSE; break; //Affiche classement en fonction du temps
      case '2': resultatFinalNat(identite, nbskieur); PAUSE; break; //affiche classement d'une nationnalite en fonction du temps
      case '3': resultatFinalFor(identite, nbskieur); PAUSE; break; //affiche liste des forfaits
      case '4': resultatFinalDis(identite, nbskieur); PAUSE; break; //affiche liste des discalifies
      case '*': printf("Fin du programme...\n");break; //suite et fin
    }
  } while(rep != '*');
}

//--------------------------------------------//

int main(int argc, char const *argv[]) {
  int nbskieur; //nombre de skieur en competition
  identite identite[NB_SKIEUR_MAX] = {0, "", "", 0, -1, 0}; //initialisation du tableau de struct | sorte de base de donnée des participants

  nbskieur = etape1Menu(identite);
  etape2Menu(nbskieur, identite);
  etape3Menu(nbskieur, identite);
  etape4Menu(nbskieur, identite);

  return 0;
}
