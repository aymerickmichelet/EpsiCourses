import json
from farm import farm
import random
from datetime import datetime
from farm import farm
from animal import animal
from chicken import chicken
from fox import fox
from koala import koala
from snake import snake

def farm_factory(name_of_class, sex, name, birthdate=None, litter=None):
    if birthdate == None:
        birthdate = datetime.now()
    if litter == None:
        litter = 1
    if(name_of_class == "animal"):
        return animal(None, sex, name, birthdate, litter)
    elif(name_of_class == "chicken"):
        return chicken(sex, name, birthdate)   
    elif (name_of_class == "fox"):
        return fox(sex, name, birthdate)
    elif (name_of_class == "koala"):
        return koala(sex, name, birthdate)
    elif (name_of_class == "snake"):
        return snake(sex, name, birthdate)
    else :
        print("this class doesn’t exist > " + str(name_of_class))

def getConfigFarm():
    list = json.load(open('config.json'))
    if 'farm' in list:
        if 'name' in list['farm']:
            f = farm(str(list['farm']['name']))
        if 'animals' in list['farm']:
            i = 1
            while str(i) in list['farm']['animals']:
                if 'type' in list['farm']['animals'][str(i)]:
                    type_ = list['farm']['animals'][str(i)]['type']
                else:
                    type_ = "animal"
                if 'sex' in list['farm']['animals'][str(i)]:
                    sex = list['farm']['animals'][str(i)]['sex']
                else:
                    sex = random.choice(["female","male"])
                if 'name' in list['farm']['animals'][str(i)]:
                    name = list['farm']['animals'][str(i)]['name']
                else:
                    name = "Jean-Eude" # faire aléa des prénoms (en fonction du sexe)
                if 'birthdate' in list['farm']['animals'][str(i)]:
                    try:
                        birthdate = list['farm']['animals'][str(i)]['birthdate'].split('-')
                        birthdate = datetime(int(birthdate[0]), int(birthdate[1]), int(birthdate[2]))
                    except:
                        print("farm.animals."+str(i)+".birthdate > error")
                        birthdate = datetime.now()
                else:
                    birthdate = datetime.now()
                f.animals.append(farm_factory(type_, sex, name, birthdate))
                i+=1
            return f
        return None
    return None

def getConfigStat(type_):
    config = json.load(open('config.json'))
    if type_ == "animal" or type_ == "chicken" or type_ == "fox" or type_ == "koala" or type_ == "snake":
        if 'stats' in config:
            if type_ in config['stats']:
                list = {}
                if 'adult_age' in config['stats'][type_]:
                    list['adult_age'] = config['stats'][type_]['adult_age']
                if 'retirement_age' in config['stats'][type_]:
                    list['retirement_age'] = config['stats'][type_]['retirement_age']
                if 'litter' in config['stats'][type_]:
                    list['litter'] = config['stats'][type_]['litter']
                return list
            return None
        return None
    return None

def getConfigDebug():
    config = json.load(open('config.json'))
    if 'debug' in config:
        return config['debug']
    return None