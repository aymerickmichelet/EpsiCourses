package fr.aymnms.banque;

import java.io.IOException;
import java.util.HashMap;
import java.util.Scanner;

import fr.aymnms.banque.objet.Administrateur;
import fr.aymnms.banque.objet.Client;

public class Method {
	
	private static int id_incrementation = 0;
	private static HashMap <Administrateur, String> admin;
	private static HashMap<Client, String> client;
	
	public static void clear() {
		try {
			final String os = System.getProperty("os.name");
			if(os.contains("Windows")) {
				Runtime.getRuntime().exec("cls");
			}else {
				Runtime.getRuntime().exec("clear");				
			}
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	
	public static void utilisateurDefaut() {
		admin.put(new Administrateur(id_incrementation++, "ADMIN", "admin"), "9999");
		client.put(new Client(id_incrementation++, "MICHELET", "Aymerick"), "1234");
	}
	
	public static int typeUtilisateur() {
		@SuppressWarnings("resource")
		Scanner scan = new Scanner(System.in);
		String nb;
		
//		clear();
		System.out.println("Banque");
		System.out.println("1 - Client");
		System.out.println("2 - Administrateur");
		System.out.println("0 - Quitter");
		nb = scan.nextLine();
		if(nb.length() > 1)
			nb = "a";
		switch(nb.charAt(0)) {
			case '1':
				return 1;
			case '2':
				return 2;
			case '0':
				return 0;
			default:
				return -1;
		}
	}
	
	
	public static Client trouverClient() {
		Scanner scan = new Scanner(System.in);
		
		System.out.print("nom: ");
		String nom = scan.nextLine();
		System.out.print("mot de passe: ");
		String mdp = scan.nextLine();
		
		for(int i = 0, imax = client.size(); i < imax; i++) {
			
		}
		
		return null;
	}
}
