from random import randrange


class Roulette:
    def __init__(self):
        self.number = 0

    def startRoulette(self):
        self.number = randrange(0, 49)
        return self.number

    def isSameNumber(self, number):
        return number == self.number

    def isSameColor(self, number):
        return number % 2 == self.number % 2