# Courses_Casino
Python homework

## Pourquoi ce programme ?

Ce programme est un devoir de cour en python. Le sujet se trouve [ici](https://github.com/aymerickmichelet/Courses_Casino/blob/master/etudeCasCasinoAlpha.pdf)

## But du jeu

Le but du jeu est de faire banqueroute le casino.
Pour ce faire, vous devez gagner le plus possible. A chaque fois que vous gagnez, la somme obtenue est déduite du solde du casino.
A contrario si votre solde est nulle, vous perdez.
Bonne chance !

## Comment se déroule le jeu ?

Vous avez dans un premier temps choisir un nom pour jouer:

En selectionnant "Connexion" | Vous pouvez écrire votre nom
--- | ---
![image](https://user-images.githubusercontent.com/32719398/110536761-21bf7a00-8122-11eb-8ca1-752aade4ec11.png) | ![image](https://user-images.githubusercontent.com/32719398/110535279-59c5bd80-8120-11eb-9209-83b633f13324.png)

Ensuite à chaque roulette, vous avez la possibilité de visualiser votre solde ainsi que celui du casino.<br>
De plus, vous pouvez miser sur un nombre ou de vous déconnecter.

![image](https://user-images.githubusercontent.com/32719398/110537127-91ce0000-8122-11eb-8c64-3d3c78325e4d.png)

Il vous suffit de suivre les consignes et vous aurez le résultat de la roulette.
3 résultats sont possibles:

Nombre | Possibilité | Concéquense
--- | --- | ---
1 | Tomber sur le bon nombre | mise + 3x de la mise
2 | Tomber sur la bonne couleur (nombre pair ou nombre impair) | mise + 50% de la mise
3 | Ne rien gagner | perdre sa mise

## Comment lancer le programme ?

Lancer un terminal:

`git clone git@github.com:aymerickmichelet/Courses_Casino.git`

`cd Courses_Casino/`

`python3 main.py`
