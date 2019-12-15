#include "user.h"

class Client: public User {
    public:
        Client(int n_account_, string lastname_, string name_);
        Client(int n_account_, string lastname_);
        ~Client();

        void depositBalance(float amount);
        void withdrawBalance(float amount);
        float getBalance();

        float amount_credit = 0;
        float amount_debit = 0;
        float balance = 0;
};