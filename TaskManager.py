from Task import Task
from Action import Action


class TaskManager:
    def __init__(self):
        self.tasks = []
        self.action = None

    def exec(self, command):
        self.action = Action(command)
        if self.action.type == "ADD":
            self.addTask(self.action.command)

    def addTask(self, labelTask):
        task = Task(self.getLastId()+1, labelTask)
        self.tasks.append(task)

    def getLastId(self):
        lastId = 1
        for task in self.tasks:
            if task.id > lastId:
                lastId = task.id
        return lastId
