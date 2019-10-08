# a l'avenir, le faire avec la bdd

list_wakeup = ("!blf", "!bottleflip", "!botleflip", "!bot", "!bottle", "!leflip", "!flip", "salut", "Salut")
list_getjoke = ("1")
list_addjoke = ("2")
list_experience = ("3")


def getAnswerWakeup(answer):
    for word in list_wakeup:
        if answer == word:
            return 1
    return 0


def getAnswerGetJoke(answer):
    for word in list_getjoke:
        if answer == word:
            return 1
    return 0


def getAnswerAddJoke(answer):
    for word in list_addjoke:
        if answer == word:
            return 1
    return 0


def getAnswerExperience(answer):
    for word in list_experience:
        if answer == word:
            return 1
    return 0