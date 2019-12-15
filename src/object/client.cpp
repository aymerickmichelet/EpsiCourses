#include "../../header/client.h"
#include "../../header/utils.h"
#include "../../header/log.h"

using namespace std;

Client::Client(int n_account_, string lastname_, string name_){
    n_account = n_account_;
    lastname = lastname_;
    name = name_;
    addInfo("Client n_" +to_string(n_account)+ " created");
    // debug("Client n_" +to_string(n_account)+ " created");
}

Client::Client(int n_account_, string lastname_){
    n_account = n_account_;
    lastname = lastname_;
    addInfo("Client n_" +to_string(n_account)+ " created");
    // debug("Client n_" +to_string(n_account)+ " created");
}

Client::~Client(){
    addInfo("Client n_" +to_string(n_account)+ " delete");
    // debug("Client n_" +to_string(n_account)+ ", " +lastname+ " delete");
}

void Client::depositBalance(float amount){
    if(amount > 0){
        addInfo(lastname+ " deposit "+to_string(amount)+ " euros in this account");
        debug("Vous venez de deposer " +to_string(amount)+ "euros a votre compte.");
        amount_credit += amount;
        balance += amount;
    }else{
        debug("Vous ne pouvez pas deposer cette somme.");
    }
}

void Client::withdrawBalance(float amount){
    if (getBalance() >= amount){
        addInfo(lastname+ " withdraw "+to_string(amount)+" euros in his account.");
        debug("Vous venez de retirer " +to_string(amount)+ "euros a votre compte.");
        amount_debit += amount;
        balance -= amount;
    }else{
        addWarning(name+ "can't withdraw " +to_string(amount)+ " euros because he has "+to_string(getBalance())+ " euros in his account.");
        debug("Vous n'avez pas assez d'argent.");
    }
}

float Client::getBalance(){
    return balance;
}