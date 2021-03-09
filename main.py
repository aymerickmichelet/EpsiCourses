from Casino import Casino
from time import sleep
from Utils import clear, pause, getStringFromUser, getNumberFromUser

casino = Casino()


def menuRegister():
    global casino
    clear()
    text = "1 - Connexion\n2 - Règle du jeu\n0 - Quitter\n"
    response = getNumberFromUser(text, 0, 2)
    if response == 1:
        clear()
        casino.registerPlayer(getStringFromUser("Identifiant: "))
        print("Bienvenue " + casino.player.name + " !")
        return 1
    elif response == 2:
        print("-=-= Casino =-=-")
        print("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")
        print("Le but du jeu est de faire banqueroute le casino.")
        print("Pour ce faire, vous devez gagner le plus possible.")
        print("A chaque fois que vous gagnez, la somme obtenue est")
        print("déduite du solde du casino.")
        print("A contrario si votre solde est nulle, vous perdez.\nBonne chance !")
        print("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n")
    else:
        return 0


def menuGame():
    global casino
    clear()
    infoUser = casino.player.name + " - solde: " + str(casino.player.sold) + "$"
    infoCasino = "Casino - solde: " + str(casino.sold) + "$"
    text = infoUser + "\n" + infoCasino + "\n1 - Miser sur un nombre\n0 - Deconnecter\n"
    if getNumberFromUser(text, 0, 1) == 1:
        clear()
        # demander quel nombre il veut parier
        number = getNumberFromUser("Nombre misé [0; 49]: ", 0, 49)
        # demander combien il veut miser
        price = getNumberFromUser("Montant de la mise (< " + str(casino.player.sold) + "): ", 0, casino.player.sold)
        casino.player.withdrawalSold(price)  # retire la somme parié
        casino.settleSold(price)  # crédite la somme parié
        clear()
        # aléatoire
        print("Lancement de la roulette...")
        sleep(2)
        casino.roulette.startRoulette()
        print("La boule s'est arrêté sur le '" + str(casino.roulette.number) + "' !")
        sleep(1)
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
        pause()
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
        clear()
        print("Votre solde est à 0$, le casino a gagné !")
        casino.resetPlayer()
        pause()

    elif casino.sold <= 0:
        clear()
        print("Le solde du casino est de 0$.\nFélicitation, vous avez gagné !")
        casino.resetPlayer()
        pause()

    # menu
    elif casino.player is not None:
        menuGame()
