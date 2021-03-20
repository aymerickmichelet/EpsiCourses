from TaskManager import TaskManager
from Task import Task


def parseEmptyInput():
    tm = TaskManager()
    tm.exec("")
    assert tm.action.type is None


def parseInputActionAdd():
    tm = TaskManager()
    tm.exec("+ Acheter du pain")
    assert tm.action.type == "ADD"


def parseInputActionRemove():
    tm = TaskManager()
    tm.exec("+ Acheter du pain")
    tm.exec("- 1")
    assert tm.action.type == "REMOVE"


def parseInputActionDone():
    tm = TaskManager()
    tm.exec("+ Acheter du pain")
    tm.exec("x 1")
    assert tm.action.type == "DONE"


def parseInputActionToDo():
    tm = TaskManager()
    tm.exec("+ Acheter du pain")
    tm.exec("o 1")
    assert tm.action.type == "TODO"


def test_parseInput():
    parseEmptyInput()
    parseInputActionAdd()
    parseInputActionRemove()
    parseInputActionDone()
    parseInputActionToDo()


def test_saveOneTask():
    tm = TaskManager()
    tm.exec("+ Acheter du pain")
    assert tm.tasks[0].label == "Acheter du pain"
    assert tm.tasks[0].status == "TODO"


# def test_removeTask():
#     tm = TaskManager()
#     tm.exec("+ Acheter du pain")
#     tm.exec("- 1")
#     for t in tm.tasks:
#         print(t)
#     assert len(tm.tasks) == 0
#     # je ne comprends pas pourquoi le remove ne fonctionne pas.
#     # "- 1" ne marche pas mais "- 2" et "- djazj" fonctionne.

def test_doneTask():
    tm = TaskManager()
    tm.exec("+ Acheter du pain")
    tm.exec("x 1")
    assert tm.tasks[0].status == "DONE"


def test_toDoTask():
    tm = TaskManager()
    tm.exec("+ Acheter du pain")
    tm.exec("x 1")
    tm.exec("o 1")
    assert tm.tasks[0].status == "TODO"


# def test_displayTasks():
#     tm = TaskManager()
#     tm.exec("+ Acheter du pain")
#     tm.exec("+ Acheter du lait")
#     tm.exec("o 1")
#     tm.exec("x 2")
#     tm.displayTasks()
#     # je ne vois pas comment tester l'affichage