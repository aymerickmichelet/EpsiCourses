#include "../../header/administrator.h"
#include "../../header/utils.h"
#include "../../header/log.h"

using namespace std;

Administrator::Administrator(int n_account_, string lastname_, string name_){
    n_account = n_account_;
    lastname = lastname_;
    name = name_;
    addInfo("Administrator n_" +to_string(n_account)+ " created");
}

Administrator::Administrator(int n_account_, string lastname_){
    n_account = n_account;
    lastname = lastname_;
    addInfo("Administrator n_" +to_string(n_account)+ " created");
}

Administrator::~Administrator(){
    addInfo("Administrator Delete");
}

void Administrator::setClientLastname(Client *client, string lastname_){
    client->lastname = lastname_;
}

string Administrator::getClientLastname(Client *client){
    return client->lastname;
}

void Administrator::setClientName(Client *client, string name_){
    client->name = name_;
}

string Administrator::getClientName(Client *client){
    return client->name;
}

int Administrator::getClientNumeroCompte(Client *client){
    return client->n_account;
}

void Administrator::addClient(map <Client*, string> *map_client, string lastname_, string password_){
    map <Client*, string>::iterator it_client;
    it_client = --map_client->end();
    map_client->insert({new Client(it_client->first->n_account+1, lastname_), password_});
    cout << "Le client " +lastname_+ " a ete correctement cree." << endl;
}

void Administrator::addClient(map <Client*, string> *map_client, string lastname_, string name_, string password){
    map <Client*, string>::iterator it_client;
    it_client = --map_client->end();
    map_client->insert({new Client(it_client->first->n_account+1, lastname_, name_), password});
    cout << "Le client " +lastname_+ " a ete correctement cree." << endl;
}

void Administrator::removeClient(map <Client*, string> *map_client, Client *client){
    map <Client*, string>::iterator it_client;
    it_client = map_client->find(client);
    delete client;
    map_client->erase(it_client);
}