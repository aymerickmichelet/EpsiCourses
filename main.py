import os
import config
import random
from datetime import datetime, timedelta
from farm import farm

def pause():
    os.system("pause")

def clear():
    os.system("clear")

def setDate():
    date_now = datetime.now()
    print("-=-=-= Farm =-=-=-")
    date = str(input("Give me a date (year-month-day):"))
    if date == "":
        return datetime(2025,1,1),date_now
    date = date.split('-')
    if not (len(date) == 3):
        return None,None
    for nomber in date:
        try:
            nomber = int(nomber)
        except TypeError:
            print("La date saisie ne correspond pas au format souhaité.")
            return None,None
    date[0] = int(date[0])
    date[1] = int(date[1])
    date[2] = int(date[2])
    if not date[1] >= 1 and date[1] <= 12:
        print("La date saisie ne correspond pas au format souhaité.")
        print("Veuillez vérifier le mois demandé.")
        return None,None
    if not date[2] >= 1 and date[2] <= 31:
        print("La date saisie ne correspond pas au format souhaité.")
        print("Veuillez vérifier le jour demandé.")
        return None,None
    if not date[0] >= date_now.year:
        print("La date saisie ne correspond pas au format souhaité.")
        print("Veuillez vérifier l'année demandé.")
        return None,None
    try:
        date = datetime(year=date[0], month=date[1], day=date[2])
    except (TypeError, ValueError):
        print("La date saisie ne correspond pas au format souhaité.")
        return None,None
    if not date > date_now:
        print("La date saisie ne correspond pas au format souhaité.")
        print("La date est inférieur à aujourd'hui")
        return None,None
    return date,date_now

def incrementDate(time):
    month_date_1 = time.month
    while month_date_1 == time.month:
        time += timedelta(days=1)
    return time

def reproduction(animal_repoductor):
    global farm_config
    global today
    global animalborn
    for animal in farm_config.animals:
        if not animal == animal_repoductor:
            if animal.type == animal_repoductor.type:
                if not animal.sex == animal_repoductor.sex:
                    if animal.isAdult(today) == True:
                        for i in range(int(random.randint(0, animal.litter) / 2)): # litter/2 car reproduction animal1 -> animal2 et animal2-> animal1
                            # if random.randint(0, 1) == 0: # si on souhaite modifier mortalité infantile
                            farm_config.animals.append(config.farm_factory(animal_repoductor.type, random.choice(["female","male"]), animal_repoductor.name+animal.name, today))
                            animalborn += 1

if __name__ == "__main__":
    clear()
    animalborn = 0
    animaldead = 0
    farm_config = config.getConfigFarm()
    
    stop = True
    while(stop):
        date, today = setDate()
        if type(date) is datetime:
            stop = False
        else:
            pause()
            clear()
    
    stop = True
    while(today < date):
        if config.getConfigDebug() == True:
            print("aujourd'hui: "+ str(today))
            print("       date: " + str(date))
        for animal in farm_config.animals:
            if animal.isAdult(today) == True:
                if today.month == 3: # reproduction tout les printemps (mars)
                    reproduction(animal) # ajoute animal dans farm + increment animalborn
                if animal.isRetirement(today) == True:
                    farm_config.animals.remove(animal)
                    animaldead += 1 # supprimer animal de farm + increment animaldeath
        if config.getConfigDebug() == True:
            # print(farm_config) # peut faire lagger
            print("farm count: "+str(len(farm_config.animals)))
            print("animalborn: "+str(animalborn))
            print("animaldead: "+str(animaldead))
            pause()
            clear()
        today = incrementDate(today) # ajoute +1mois à 'today'

    print("farm count: "+str(farm_config.animals.count))
    print("animalborn: "+str(animalborn))
    print("animaldead: "+str(animaldead))
    print(farm_config)