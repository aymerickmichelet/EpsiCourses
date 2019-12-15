#include "../../header/user.h"
#include "../../header/utils.h"
#include "../../header/log.h"

using namespace std;

User::User(){
    addInfo("User created");
    // debug("User created");
}

User::~User(){
    addInfo("User "+lastname+" delete");
    // debug("User " +lastname+ " delete");
}