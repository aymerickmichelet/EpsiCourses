#include "administrator.h"
#include <map>

void addDefaultUser(map <Client*, string> *map_client, map <Administrator*, string> *map_administrator, int id_incrementation);

int typeUser();

Client* identificationClient(map <Client*, string> *map_client);

Administrator* identificationAdministrator(map <Administrator*, string> *map_administrator);