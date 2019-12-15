#include "../header/menu.h"

Client* chooseClient(map <Client*, string> *map_client){
    map <Client*, string>::iterator it_client;
    int rep;
    cout << "| Num | Nom | Prenom |" << endl;
    for(it_client = map_client->begin(); it_client != map_client->end(); it_client++){
        cout << "| " +to_string(it_client->first->n_account)+ " | "
                    << it_client->first->lastname+ " | "
                    << it_client->first->name + " |" << endl;
    }
    cout << "Souhaitez-vous choisir ? (veuillez ecrire son numero)" << endl;
    cin >> rep;
    for(it_client = map_client->begin(); it_client != map_client->end(); it_client++){
        if(it_client->first->n_account == rep){
            return it_client->first;
        }
    }
    return NULL;
}

void menuClient(Client *client){
    string rep;
    float somme;
    bool quitter = false;
    while(quitter == false){
        clear();
        cout << "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-" << endl;
        cout << "| Bienvenue " +client->lastname+ ", "
        << "que souhaitez-vous faire ?" << endl;
        cout << "| Solde: " +to_string(client->getBalance())+ " euros" << endl;
        cout << "| 1 - Deposer,\n"
            << "| 2 - Retirer,\n"
            << "| 0 - Quitter\n| >";
        cin.clear();
        cin >> rep;
        if(rep.length() > 1){
            cout << "Reponse incorrecte." << endl;
            pause();
            continue;
        }
        switch(rep[0]){
            case '1':
                clear();
                cout << "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-" << endl;
                cout << "| Quelle somme souhaitez-vous deposer ?\n| > ";
                cin >> somme;
                client->depositBalance(somme);
                pause();
                break;
            case '2':
                clear();
                cout << "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-" << endl;
                cout << "Quelle somme souhaitez-vous retirer ?\n| > ";
                cin >> somme;
                client->withdrawBalance(somme);
                pause();
                break;
            case '0':
                cout << "QUITTER" << endl;
                quitter = true;
                break;
            default:
                cout << "Reponse incorrecte." << endl;
                pause();
                break;
        }
    }
}

// il faut:
//      map_client
//      it_client
//      -> pour trouver client
// il faut:
//      methode pour lister les clients existants
void menuAdministrator(Administrator *admin, map <Client*, string> *map_client){
    map <Client*, string>::iterator it_client;
    string rep, lastname_, name_, password_;
    Client *client;
    bool quitter = false;
    while(quitter == false){
        clear();
        cout << "Bienvenue " +admin->lastname+ ", "
        << "que souhaitez-vous faire ?" << endl;
        cout << "1 - Creer un nouveau client,\n"
             << "2 - Supprimer un client,\n"
             << "3 - Modifier le nom d'un client,\n"
             << "4 - Modifier le prenom d'un client,\n"
             << "0 - Quitter" << endl;
        cin >> rep;
        if(rep.length() > 1){
            cout << "Reponse incorrecte." << endl;
            pause();
            continue;
        }
        switch(rep[0]){
            case '1':
                clear();
                cout << "Nouveau client:\n"
                        << "nom: ";
                cin >> lastname_;
                cout << "password: ";
                cin >> password_;
                admin->addClient(map_client, lastname_, password_);
                cout << "Client ajoutee" << endl;
                pause();
                break;
            case '2':
                clear();
                cout << "Supprimer client:" << endl;
                client = chooseClient(map_client);
                if(client != NULL){
                    cout << "Etes-vous sur de vouloir supprimer ce compte ? (Oui - 1/ Non - 0)" << endl;
                    cin >> lastname_;
                    if(lastname_[0] == '1' && lastname_.length() < 2){
                        admin->removeClient(map_client, client);
                    }
                // }else{
                //     cout << "Reponse Incorrecte." << endl;
                }
                // pause();
                break;
            case '3':
                clear();
                client = chooseClient(map_client);
                if(client != NULL){
                    cout << "Par quel nom souhaitez-vous modifier le nom existant ?" << endl;
                    cin >> lastname_;
                    admin->setClientLastname(client, lastname_);
                }else{
                    cout << "Reponse Incorrecte." << endl;
                }
                pause();
                break;
            case '4':
                clear();
                client = chooseClient(map_client);
                if(client != NULL){
                    cout << "Par quel prenom souhaitez-vous modifier le prenom existant ?" << endl;
                    cin >> name_;
                    admin->setClientLastname(client, name_);
                    pause();
                }else{
                    cout << "Reponse Incorrecte." << endl;
                }
                pause();
                break;
            case '0':
                cout << "QUITTER" << endl;
                quitter = true;
                break;
            default:
                cout << "Reponse incorrecte." << endl;
                pause();
                break;
        }
    }
}

