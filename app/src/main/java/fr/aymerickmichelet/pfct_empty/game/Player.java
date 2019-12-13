package fr.aymerickmichelet.pfct_empty.game;

public class Player {
    private int id; // id du joueur
    private int userrole; //quelle place j'occupe dans la game (j1 ou 2)
    private int gameid; // l'ip de le game
    private int request; //qu'est ce que je veux faire (jouer ou vérifier si l'autre joueur a joué)
    private int move; // je joue quel move (1, 2 ou 3 selon shi fou ou mi)
    private String name; // nom du joueur
    private int victory; // nombre de victoire
    private int defeat; // nombre de defaite




    public Player(){
    }

    public int getDefeat() {
        return defeat;
    }
    public void setDefeat(int defeat) {
        this.defeat = defeat;
    }

    public int getVictory() {
        return victory;
    }
    public void setVictory(int victory) {
        this.victory = victory;
    }

    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }

    public int getMove() {
        return move;
    }
    public void setMove(int move) {
        this.move = move;
    }

    public int getRequest() {
        return request;
    }
    public void setRequest(int request) {
        this.request = request;
    }

    public int getGameid() {
        return gameid;
    }
    public void setGameid(int gameid) {
        this.gameid = gameid;
    }

    public int getUserrole() {
        return userrole;
    }
    public void setUserrole(int userrole) {
        this.userrole = userrole;
    }

    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }
}
