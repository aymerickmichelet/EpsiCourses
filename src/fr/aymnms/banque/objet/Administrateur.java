package fr.aymnms.banque.objet;

public class Administrateur extends Utilisateur{

	public Administrateur(int numero, String nom_, String prenom_){
		numero_account = numero;
		nom = nom_;
		prenom = prenom_;
	}
	
	public Administrateur(int numero, String nom_){
		numero_account = numero;
		nom = nom_;
		prenom = "";
	}
	
	public void setClientLastname(Client client, String nom_){
	    client.nom = nom_;
	}

	public String getClientLastname(Client client){
	    return client.nom;
	}

	public void setClientName(Client client, String nom_){
	    client.nom = nom_;
	}

	public String getClientName(Client client){
	    return client.nom;
	}

	public int getClientNumeroCompte(Client client){
	    return client.numero_account;
	}

	
//	void addClient(map <Client*, string> *map_client, string lastname_, string password_){
//	    map <Client*, string>::iterator it_client;
//	    it_client = --map_client->end();
//	    map_client->insert({new Client(it_client->first->n_account+1, lastname_), password_});
//	    cout << "Le client " +lastname_+ " a ete correctement cree." << endl;
//	}
//
//	void addClient(map <Client*, string> *map_client, string lastname_, string name_, string password){
//	    map <Client*, string>::iterator it_client;
//	    it_client = --map_client->end();
//	    map_client->insert({new Client(it_client->first->n_account+1, lastname_, name_), password});
//	    cout << "Le client " +lastname_+ " a ete correctement cree." << endl;
//	}
//
//	void removeClient(map <Client*, string> *map_client, Client *client){
//	    map <Client*, string>::iterator it_client;
//	    it_client = map_client->find(client);
//	    delete client;
//	    map_client->erase(it_client);
//	}
	
}
