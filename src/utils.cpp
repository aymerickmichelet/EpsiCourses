#include <iostream>
#include <string>
#include <stdlib.h>
#include "../header/utils.h"

using namespace std;

void clear(){
    system("CLS");
}

void pause(){
    system("PAUSE");
}

void debug(string sentence){
    cout << sentence << endl;
}

// string to_lower(string s1){
//     string s2 = "";
//     for(int i = 0, imax = s1.length(); i < imax; i++){
//         if(s1[i] >= 'A' && s1[i] <= 'Z'){
//             s2.append(s1[i]+32);
//         }else{
//             s2.append(s1[i]);
//         }
//     }
//     return s2;
// }