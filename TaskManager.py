from Task import Task
from Action import Action


class TaskManager:
    def __init__(self):
        self.tasks = []
        self.action = None

    def exec(self, command):
        print("exec: command = " + str(command))
        self.action = ""
        self.action = Action(command)

        print("exec: action = " + str(self.action))

        if self.action.type == "ADD":
            self.addTask(self.action.command)
        elif self.action.type == "REMOVE":
            self.removeTask(self.action.command)

    def addTask(self, labelTask):
        task = Task(self.getLastId()+1, labelTask)
        self.tasks.append(task)

    def removeTask(self, idTask):
        print("removeTask: idTask = " + str(idTask))
        idTask = int(idTask)
        for task in self.tasks:
            if task.id == idTask:
                self.tasks.remove(task)
                return True
        return False

    # def removeTask(self, idTask):
    #     index = -1
    #     for task in self.tasks:
    #         if task.id == idTask:
    #             self.tasks.remove(task)
    #             index = self.tasks.index(task)
    #     if index != -1:
    #         self.tasks.pop(index)
    #         return True
    #     else:
    #         return False

    def getLastId(self):
        lastId = 0
        for task in self.tasks:
            if task.id > lastId:
                lastId = task.id
        return lastId
