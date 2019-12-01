from animal import animal
from datetime import datetime
import config

class koala(animal) :

    date = datetime.now()

    def __init__(self, sex=None, name="koala", birthdate=date):
        self.type = "koala"
        self.sex = sex
        self.name = name
        self.birthdate = birthdate
        self.adult_age = int(config.getConfigStat('koala')['adult_age']) #1 # normalement 2
        self.retirement_age = int(config.getConfigStat('koala')['retirement_age']) #3 # normalement 20
        self.litter = int(config.getConfigStat('koala')['litter']) #2 # normalement 1