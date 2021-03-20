from Task import Task
from Action import Action


class TaskManager:
    def __init__(self):
        self.tasks = []
        self.action = None

    def exec(self, command):
        self.action = ""
        self.action = Action(command)

        if self.action.type == "ADD":
            self.addTask(self.action.command)
        elif self.action.type == "REMOVE":
            self.removeTask(self.action.command)
        elif self.action.type == "DONE":
            self.doneTask(self.action.command)
        elif self.action.type == "TODO":
            self.toDoTask(self.action.command)

    def addTask(self, labelTask):
        task = Task(self.getLastId()+1, labelTask)
        self.tasks.append(task)

    def removeTask(self, idTask):
        idTask = int(idTask)
        for task in self.tasks:
            if task.id == int(idTask):
                self.tasks.remove(task)

    def doneTask(self, idTask):
        for task in self.tasks:
            if task.id == int(idTask):
                task.done()

    def toDoTask(self, idTask):
        for task in self.tasks:
            if task.id == int(idTask):
                task.toDo()

    def getLastId(self):
        lastId = 0
        for task in self.tasks:
            if task.id > lastId:
                lastId = task.id
        return lastId
