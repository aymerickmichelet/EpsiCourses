from datetime import datetime
import config

class animal :
    def __init__(self, type=None, sex=None, name=None, birthdate=datetime.now(), adult_age=None, retirement_age=None, litter=None):
        self.type = type
        self.sex = sex
        self.name = name
        self.birthdate = birthdate
        self.adult_age = int(config.getConfigStat('animal')['adult_age'])
        self.retirement_age = int(config.getConfigStat('animal')['retirement_age'])
        self.litter = int(config.getConfigStat('animal')['litter'])

    def __str__(self):
        type_ = str(self.type)
        sex = str(self.sex)
        name = str(self.name)
        birthdate = str(self.birthdate)
        adult_age = str(self.adult_age)
        retirement_age = str(self.retirement_age)
        litter = str(self.litter)
        return "["+type_+"]:  \t"+sex+"\t"+name+"\t"+birthdate+"\t"+adult_age+"\t"+retirement_age+"\t"+litter
        # return "-----\n"+type_+"\n"+sex+"\n"+name+"\n"+birthdate+"\n"+adult_age+"\n"+retirement_age+"\n"+litter+"\n-----"

    def isAdult(self, today): # tester si adult, et si retirement
        adult = False
        if (today - self.birthdate).days / 365 >= self.adult_age:
            adult = True
        return adult

    def isRetirement(self, today):
        retirement = False
        if (today - self.birthdate).days / 365 >= self.retirement_age:
            retirement = True
        return retirement