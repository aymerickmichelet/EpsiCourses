from TaskManager import TaskManager
from os import system, name


def clear():
    # for windows
    if name == 'nt':
        _ = system('cls')
        # for mac and linux(here, os.name is 'posix')
    else:
        _ = system('clear')


tm = TaskManager()

while True:
    clear()
    print("Listes:")
    tm.displayTasks()
    tm.exec(input("commande: "))
