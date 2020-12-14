import java.util.ArrayList;

public class Sport {
    private int identifiant;
    private String nom;
    private int nombreJoueurs;
    private ArrayList<Terrain> terrainCompatibles;

    public Sport(){
    }

    public Sport(String nom, int nombreJoueurs) {
        this.nom = nom;
        this.nombreJoueurs = nombreJoueurs;
    }

    public int getIdentifiant() {
        return identifiant;
    }

    public void setIdentifiant(int identifiant) {
        this.identifiant = identifiant;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public int getNombreJoueurs() {
        return nombreJoueurs;
    }

    public void setNombreJoueurs(int nombreJoueurs) {
        this.nombreJoueurs = nombreJoueurs;
    }

    public ArrayList<Terrain> getTerrainCompatibles() {
        return terrainCompatibles;
    }

    public void setTerrainCompatibles(ArrayList<Terrain> terrainCompatibles) {
        this.terrainCompatibles = terrainCompatibles;
    }
}
