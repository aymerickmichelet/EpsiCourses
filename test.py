from TaskManager import TaskManager
from Task import Task


def test_parseEmptyInput():
    tm = TaskManager("")
    assert tm.action.type is None


def test_parseInputActionAdd():
    tm = TaskManager("+ Acheter du pain")
    assert tm.action.type == "ADD"
