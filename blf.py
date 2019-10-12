import discord
import mysql.connector
from random import randint
import datetime
import bdd
import embed
import joke

def getJoke(): # a factoriser
    joker = joke.Joke()
    rows = bdd.request("SELECT * FROM joke", 1)
    if rows == -1:
        print("[Error] Sql connection: fetch what ?")
        return "Oups j'arrive plus à m'en souvenir..."
    rand = randint(1, len(rows)) - 1
    joker.id = int(rows[rand][3])
    query = "SELECT user_pseudo FROM user WHERE user_id = " + str(joker.id)
    joker.pseudo = bdd.request(query, 3)[0]
    joker.joke = rows[rand][1]
    joker.joke_date = rows[rand][2]
    date = str(joker.joke_date.day) + "/" + str(joker.joke_date.month) +"/"+ str(joker.joke_date.year)
    time = str(joker.joke_date.hour) + ":" + str(joker.joke_date.minute) +":"+ str(joker.joke_date.second)
    info = "le " + date + " à " + time
    
    return embed.sendEmbed(joker.pseudo, joker.joke, info)



def addJoke(joker): # insert != select pour methode ???
    request = 'SELECT user_id FROM user WHERE user_pseudo = "' + str(joker.pseudo) + '"'
    joker.id = bdd.request(request, 3)
    print("type(joker.id): ", type(joker.id))
    print("joker.id: ", joker.id)
    if type(joker.id) == type(None): # si user n'existe pas
        request = "INSERT INTO `user` (`user_pseudo`, `user_experience`) VALUES ('" + str(joker.pseudo) + "', '" + str(joker.experience) + "');"
        bdd.request_insert(request)
        request = 'SELECT user_id FROM user WHERE user_pseudo = "' + str(joker.pseudo) + '"'
        joker.id = bdd.request(request, 3)[0]
    else: # si user existe
        joker.id = joker.id[0]
        request = "SELECT user_experience FROM user WHERE user_id = '" + str(joker.id) + "'"
        joker.experience = bdd.request(request, 1)
    joker.joke_date = datetime.datetime.now()
    print("joke: ",joker.joke)
    print("date: ",joker.joke_date)
    print("user_id: ",joker.id)
    print("type(user_id): ",type(joker.id))
    request = "INSERT INTO `joke` (`joke`, `joke_date`, `user_id`) VALUES ('" + str(joker.joke) + "', '" + str(joker.joke_date) + "', '" + str(joker.id) + "');"
    bdd.request_insert(request)
    return 0
