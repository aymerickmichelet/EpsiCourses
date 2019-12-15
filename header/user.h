#include <iostream>
#include <string>
#include <map>
#include "utils.h"
#include "log.h"

using namespace std;

class User {
    public:
        User();
        ~User();

        int n_account;
        string lastname;
        string name;
};