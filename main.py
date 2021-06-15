from anonymisation import anony
from offuscation import offusc
from rsa import create_save_key

def init():
    continue_program = True

    print("---------Menu---------")
    print("1. Anonymisation du fichier")
    print("2. Offuscation du fichier")
    print("3. ")
    print("4. ")
    print("5. ")


    command = input("Veuillez selectionnez votre action : ")
    actionUser(command)


def actionUser(action):

    if action == "1":
        anony()
        print("Anonymsation effectué dans le fichier : Liste_des_gagnants_du_Loto_ano.txt")
    elif action == "2":
        offusc()
        print("Offuscation effectué dans le fichier : Liste_des_gagnants_du_Loto_ano.txt")
    elif action == "3":
        print("3")
    elif action == "4":
        print("4")
    elif action == "5":
        print("5")
    else:
        print("L'action n'est pas reconnu")


if __name__ == "__main__":
    create_save_key()





