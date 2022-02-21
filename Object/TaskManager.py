# constructor: init les tasks
# stop()
# ...
import datetime
import time

from State import State

class TaskManager:
    def __init__(self, tasks: list):
        self.tasks = tasks
        self.start_time = None
        # self.storage =

    def start(self):
        self.start_time = datetime.datetime.now()
        self.loop()

    def getWaitingTasks(self):
        list = []
        for task in self.tasks:
            if task.getState() is State.WAITING:
                list.append(task)
        return list

    def getPrioritedTasks(self, tasks):
        task_priority = 0
        for task in tasks:
            if task.priority > task_priority:
                task_priority = task.priority
        return task_priority

    def updateTask(self, task_toupdate):
        for task in self.tasks:
            if task.name == task_toupdate.name:
                task = task_toupdate

    def loop(self):
        # For each loop OK
        # get tasks in state = waiting OK
        # get task > priority OK
        # run it OK
        # wait execution time OK
        # write start perido (cooldown) -> change state of the task OK

        while datetime.datetime.now() < self.start_time:
            tasks = self.getWaitingTasks()
            task = self.getPrioritedTasks(tasks)
            print(task)
            time.sleep(task.exploid.execution_time)
            task.time = datetime.datetime.now()
            task.state = State.BLOCKED
            print(task)
            self.updateTask(task)
