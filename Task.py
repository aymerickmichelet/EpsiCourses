steps = ["TODO", "DONE"]


class Task:
    def __init__(self, idTask, label):
        self.id = idTask
        self.label = label
        self.status = steps[0]

    def toDo(self):
        if self.status == steps[1]:
            self.status = steps[0]

    def done(self):
        if self.status == steps[0]:
            self.status = steps[1]

    def __str__(self):
        return "id:"+str(self.id)+",label:"+str(self.label)+",status:"+str(self.status)
