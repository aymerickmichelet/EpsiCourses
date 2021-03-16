from Action import Action


class TaskManager:
    def __init__(self):
        self.tasks = []
        self.action = None

    def exec(self, command):
        self.action = Action(command)
