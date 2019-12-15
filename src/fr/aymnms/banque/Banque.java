package fr.aymnms.banque;

//import fr.aymnms.banque.objet.Client;

public class Banque {

	public static void main(String[] args) {
		boolean reponse = false;
		
		
		
		while(reponse == false) {
			switch(Method.typeUtilisateur()) {
			case 1:
				System.out.println("Client");
				break;
			case 2:
				System.out.println("Administrateur");
				break;
			case 0:
				System.out.println("Sortie");
				reponse = true;
				break;
			default:
				break;
			}
		}		
	}
	
}
