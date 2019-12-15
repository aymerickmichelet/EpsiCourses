#include "../header/identification.h"

void addDefaultUser(map <Client*, string> *map_client, map <Administrator*, string> *map_administrator, int id_incrementation){
    map_administrator->insert({new Administrator(id_incrementation++, "ADMIN", "admin"), "9999"});
}

int typeUser(){
    string rep;
    clear();
    cout << "-=-=-=- Banque -=-=-=-\n"
            << "| 1 - Client,        |\n"
            << "| 2 - Administrateur,|\n"
            << "| 0 - Quitter        |\n"
            << "| > ";
    cin >> rep;
    if(rep.length() > 1){
        cout << "Reponse incorrecte." << endl;
        pause();
        return -1;
    }
    switch(rep[0]){
        case '1':
            return 1; break;
        case '2':
            return 2; break;
        case '0':
            return 0; break;
        default:
            cout << "Reponse incorrecte." << endl;
            pause();
            return -1; break;
    }
}

Client* identificationClient(map <Client*, string> *map_client){
    
    map <Client*, string>::iterator it_client;
    string id = "";
    string mdp = "";
    
    cout << "-=-=-=- Client -=-=-=-\n";
    cout << "| identifiant:\n| > ";
    cin >> id;
    cout << "| mot de passe:\n| > ";
    cin >> mdp;

    for(it_client = map_client->begin(); it_client != map_client->end(); it_client++){
        if(id == it_client->first->lastname){
            if(mdp == it_client->second){
                return it_client->first;
            }
        }
    }
    return NULL;
}

Administrator* identificationAdministrator(map <Administrator*, string> *map_administrator){
    
    map <Administrator*, string>::iterator it_administrator;
    string id = "";
    string mdp = "";
   
    cout << "-=- Administrateur -=-\n";
    cout << "| identifiant:\n| > ";
    cin >> id;
    cout << "| mot de passe:\n| > ";
    cin >> mdp;

    for(it_administrator = map_administrator->begin(); it_administrator != map_administrator->end(); it_administrator++){
        if(id == it_administrator->first->lastname){
            if(mdp == it_administrator->second){
                return it_administrator->first;
            }
        }
    }
    return NULL;
}