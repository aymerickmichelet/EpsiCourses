package fr.aymnms.banque.objet;

public class Client extends Utilisateur{
	
	public float somme_deposee = 0, somme_retiree = 0, solde = 0;
	
	public Client(int numero, String nom_, String prenom_){
		numero_account = numero;
		nom = nom_;
		prenom = prenom_;
	}
	
	public Client(int numero, String nom_){
		numero_account = numero;
		nom = nom_;
		prenom = "";
	}
	
	public void depositBalance(float somme) {
		System.out.println("Vous venez de deposer " +somme+ " euros sur votre compte.");
		somme_deposee += somme;
		solde += somme;
	}
	
    public void withdrawBalance(float somme) {
    	if(somme <= solde) {
    		System.out.println("Vous venez de retirer " +somme+ " euros de votre compte.");
    		somme_retiree += somme;
    		solde -= somme;
    	}else {
    		System.out.println("Vous n'avez pas assez d'argent sur votre compte.");
    	}
    }
    
    public float getBalance() {
    	return solde;
    }
}
