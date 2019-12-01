from animal import animal
from datetime import datetime
import config

class fox(animal) :

    date = datetime.now()

    def __init__(self, sex=None, name="fox", birthdate=date):
        self.type = "fox"
        self.sex = sex
        self.name = name
        self.birthdate = birthdate
        self.adult_age = int(config.getConfigStat('fox')['adult_age']) #1
        self.retirement_age = int(config.getConfigStat('fox')['retirement_age']) #3 # normalement 3
        self.litter = int(config.getConfigStat('fox')['litter']) #2 # normalement 5