from animal import animal
from datetime import datetime
import config

class chicken(animal) :

    date = datetime.now()

    def __init__(self, sex=None, name="chicken", birthdate=date):
        self.type = "chicken"
        self.sex = sex
        self.name = name
        self.birthdate = birthdate
        self.adult_age = int(config.getConfigStat('chicken')['adult_age']) # 5/12 # 5 mois
        self.retirement_age = int(config.getConfigStat('chicken')['retirement_age']) # 3 # normalement 12
        self.litter = int(config.getConfigStat('chicken')['litter']) # 2 # normalement 300