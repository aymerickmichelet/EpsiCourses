import math
from Player import Player
from Roulette import Roulette


class Casino:
    # player -> normalement list ou sets
    def __init__(self):
        self.player = None
        self.sold = 1000
        self.roulette = Roulette()

    def registerPlayer(self, name):
        player = Player(name)
        if self.player is None:
            self.player = player
        return player

    def resetPlayer(self):
        if self.player is not None:
            self.player = None
            return True
        else:
            return False

    # retrait
    def withdrawalSold(self, price):
        price = math.ceil(price)
        if self.sold - price >= 0:
            self.sold -= price
        return self.sold

    # ajout sur le compte
    def settleSold(self, price):
        self.sold += math.ceil(price)
        return self.sold
