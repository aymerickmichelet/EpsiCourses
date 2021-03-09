import math


class Player:
    # On force l'entrée à 50$
    def __init__(self, name):
        self.sold = 50
        self.name = name

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
