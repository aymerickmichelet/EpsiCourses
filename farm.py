class farm :
    def __init__(self, name=None):
        self.name = name
        self.animals = []

    def __str__(self):
        name = str(self.name)
        animals = "animals[]: "+str(self.animals.count)
        list = ""
        for animal in self.animals:
            list += "\n\t"+str(animal)
        return "["+name+"]: "+animals+list