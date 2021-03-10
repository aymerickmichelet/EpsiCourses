package fr.thejulienm.blablacar.entity;

public enum Sex {

    MALE("Homme", "H"),
    FEMININE("Femme", "F"),
    OTHER("Autre", "∅");

    private final String name;
    private final String matricule;

    Sex(String name, String matricule){
        this.name = name;
        this.matricule = matricule;
    }

    public String getMatricule() {
        return matricule;
    }

    public String getName() {
        return name;
    }
}
