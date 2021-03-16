from TaskManager import TaskManager
from Task import Task


def test_parseEmptyInput():
    tm = TaskManager("")
    assert tm.action.type is None
