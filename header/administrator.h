#include "client.h"

using namespace std;

class Administrator: public User {
    public:
        Administrator(int n_account_, string lastname_, string name_);
        Administrator(int n_account_, string lastname_);
        ~Administrator();

        void setClientLastname(Client *client, string lastname);
        string getClientLastname(Client *client);
        void setClientName(Client *client, string name);
        string getClientName(Client *client);
        int getClientNumeroCompte(Client *client);
        void addClient(map <Client*, string> *map_client, string lastname_, string password);
        void addClient(map <Client*, string> *map_client, string lastname_, string name_, string password);
        void removeClient(map <Client*, string> *map_client, Client *client);
};