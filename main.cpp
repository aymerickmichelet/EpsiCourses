#include "header/menu.h"

using namespace std;

// idée d'amélioration
// sauvegarder les clients à la fin du programme sur un serveur pour ensuite les rechargers lors de l'execution du programme.
// décoration -=-=-=-=- des menus

int main(){
    int id_incrementation = 0;
    map <Client*, string> map_client;
    map <Client*, string>::iterator it_client;
    map <Administrator*, string> map_administrator;
    map <Administrator*, string>::iterator it_administrator; 

    Client* client = NULL;
    Administrator* admin = NULL;

    addInfo("Opening 'Banque' version 0.0.5");

    // creaction cpt admin + passwd
    addDefaultUser(&map_client, &map_administrator, id_incrementation);
    
    //connection
    bool sortie = false;
    while(sortie == false){
        switch(typeUser()){
            case 1:
                client = identificationClient(&map_client);
                if(client != NULL){
                    menuClient(client); // lancement menu client
                }else{
                    cout << "L'identification a echoue..." << endl;
                    pause();
                }
                break;
            case 2:
                admin = identificationAdministrator(&map_administrator);
                if(admin != NULL){
                    // lancement menu admin

                    menuAdministrator(admin, &map_client);
                }else{
                    cout << "L'identification a echoue..." << endl;
                    pause();
                }
                break;
            case 0:
                sortie = true;
                break;
            default:
                break;
        }
    }


    




    //Suppression *Administrator
    for(it_administrator = map_administrator.begin(); it_administrator != map_administrator.end(); it_administrator++){
        delete it_administrator->first;
    }
    //Suppression map_administrator
    map_administrator.clear();
    //Suppression *Client
    for(it_client = map_client.begin(); it_client != map_client.end(); it_client++){
        delete it_client->first;
    }
    //Suppression map_client
    map_client.clear();
    pause();

    return 0;
}