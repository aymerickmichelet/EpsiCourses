#include <ctime>
#include <iostream>
#include <string>
#include <fstream>
#include "../header/log.h"

using namespace std;

string addCurrentTime(){
    string ctime = "";
    time_t t = time(0);
    tm* now = localtime(&t);

    ctime.append("[");
    ctime.append(to_string(now->tm_year + 1900));
    ctime.append("-");
    ctime.append(to_string(now->tm_mon + 1));
    ctime.append("-");
    ctime.append(to_string(now->tm_mday));
    ctime.append(" ");
    ctime.append(to_string(now->tm_hour));
    ctime.append(":");
    ctime.append(to_string(now->tm_min));
    ctime.append(":");
    ctime.append(to_string(now->tm_sec));
    ctime.append("] ");
    for (int i = ctime.length(), imax = 22; i < imax; i++){
        ctime.append(" ");
    }
    return ctime;
}

void addInfo(string debug){
    ofstream monFlux("log.txt", ios::app);
    if(monFlux){
        monFlux << addCurrentTime() << debug << endl;
        monFlux.close();
    }else{
        cout << "Erreur: Impossible d'ouvrir le fichier." << endl;
    }
}

void addWarning(string debug){
    ofstream monFlux("log.txt", ios::app);
    if(monFlux){
        monFlux << addCurrentTime() << "WARNING > " << debug << endl;
        monFlux.close();
    }else{
        cout << "Erreur: Impossible d'ouvrir le fichier." << endl;
    }
}

void addError(string debug){
    ofstream monFlux("log.txt", ios::app);
    if(monFlux){
        monFlux << addCurrentTime() << "ERROR > " << debug << endl;
        monFlux.close();
    }else{
        cout << "Erreur: Impossible d'ouvrir le fichier." << endl;
    }
}