import java.util.ArrayList;

enum Structure{
    BETON,
    SABLE,
    GRAVIER,
    TERRE,
    SYNTHETIQUE,
    ADAPTATEUR
}

public class Terrain {
    private String codeTerrain;
    private Structure structure;
    private ArrayList<Sport> sportsAutorises = new ArrayList<>();

    public Terrain(String codeTerrain, Structure structure) {
        this.codeTerrain = codeTerrain;
        this.structure = structure;
    }

    public String getCodeTerrain() {
        return codeTerrain;
    }

    public void setCodeTerrain(String codeTerrain) {
        this.codeTerrain = codeTerrain;
    }

    public Structure getStructure() {
        return structure;
    }

    public void setStructure(Structure structure) {
        this.structure = structure;
    }

    public ArrayList<Sport> getSportsAutorises() {
        return sportsAutorises;
    }

    public void setSportsAutorises(ArrayList<Sport> sportsAutorises) {
        this.sportsAutorises = sportsAutorises;
    }
}
