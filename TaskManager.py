from Action import Action


class TaskManager:
    def __init__(self, command):
        self.tasks = []
        self.action = Action(command)
