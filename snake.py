from animal import animal
from datetime import datetime
import config

class snake(animal) :

    date = datetime.now()

    def __init__(self, sex=None, name="snake", birthdate=date):
        self.type = "snake"
        self.sex = sex
        self.name = name
        self.birthdate = birthdate
        self.adult_age = int(config.getConfigStat('snake')['adult_age']) # 1 # normalement 4
        self.retirement_age = int(config.getConfigStat('snake')['retirement_age']) # 3 # normalement 15
        self.litter = int(config.getConfigStat('snake')['litter']) # 2 # normalement de 4 à 15