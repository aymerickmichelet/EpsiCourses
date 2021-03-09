from os import system, name
from Casino import Casino
from math import ceil

casino = Casino()


def clear():
    if name == 'it':
        _ = system('cls')
    else:
        _ = system('clear')


def getStringFromUser(inputText):
    return str(input(inputText))


def getNumberFromUser(inputText, min, max):
    while True:
        try:
            number = ceil(int(input(inputText)))
            if min <= number <= max:
                return number
            else:
                print("La valeur n'est pas correcte...")
        except ValueError:
            print("Le type de valeur n'est pas correcte...")


def menuRegister():
    global casino
    clear()
    print("-=-= Casino =-=-")
    text = "1 - Connexion\n2 - Règle du jeu\n0 - Quitter\n"
    response = getNumberFromUser(text, 0, 2)
    if response == 1:
        casino.registerPlayer(getStringFromUser("Identifiant: "))
        print("Bienvenue " + casino.player.name + " !")
        return 1
    elif response == 2:
        print("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")
        print("Le but du jeu est de faire banqueroute le casino.")
        print("Pour ce faire, vous devez gagner le plus possible. A chaque fois que vous gagnez,")
        print("la somme gagnée est déduit du solde du casino.")
        print("A contrario, vous perdez si votre solde est nulle.\nBonne chance !")
        print("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n")
    else:
        return 0


def menuGame():
    global casino
    print("-=-= Casino =-=-")
    infoUser = casino.player.name + " - solde: " + str(casino.player.sold) + "$"
    infoCasino = "Casino - solde: " + str(casino.sold) + "$"
    text = infoUser + "\n" + infoCasino + "\n1 - Miser sur un nombre\n0 - Deconnecter\n"
    if getNumberFromUser(text, 0, 1) == 1:
        # demander quel nombre il veut parier
        number = getNumberFromUser("Nombre misé [0; 49]: ", 0, 49)
        # demander combien il veut miser
        price = getNumberFromUser("Montant de la mise (< " + str(casino.player.sold) + "): ", 0, casino.player.sold)
        casino.player.withdrawalSold(price)  # retire la somme parié
        casino.settleSold(price)  # crédite la somme parié
        # aléatoire
        print("Lancement de la roulette...")
        casino.roulette.startRoulette()
        print("La boule s'est arrêté sur le '" + str(casino.roulette.number) + "' !")
        print("Calcule des gains...")
        if casino.roulette.isSameNumber(number):
            print("Vous avez obtenu le bon nombre !\nFélicitation, vous avez gagné " + str(price * 4) + "$ !")
            casino.player.settleSold(price * 4)
            casino.withdrawalSold(price * 4)
        elif casino.roulette.isSameColor(number):
            print("Vous avez obtenu la bonne couleur !\nFélicitation, vous avez gagné " + str(price * 1.5) + "$ !")
            casino.player.settleSold(price * 1.5)
            casino.withdrawalSold(price * 1.5)
        else:
            print("Vous n'avez malheuresement pas gagné...")
    else:
        casino.resetPlayer()


while True:
    # regarde si player exist pas
    if casino.player is None:
        # register player
        if menuRegister() == 0:
            break

    # regarde si player a un sold = 0
    elif casino.player.sold == 0:
        # le joueur a un sold a 0 -> perdu
        print("Votre solde est à 0$, le casino a gagné !")
        casino.resetPlayer()

    elif casino.sold <= 0:
        print("Le solde du casino est de 0$.\nFélicitation, vous avez gagné !")
        casino.resetPlayer()

    # menu
    elif casino.player is not None:
        menuGame()
