import discord
import mysql.connector
from random import randint
import datetime
import bdd
import embed
import joke

def getJoke(client): # a factoriser
    joker = joke.Joke()
    rows = bdd.request("SELECT * FROM joke WHERE joke_vote = 1", 1)
    rand = randint(1, len(rows)) - 1
    joker.id = int(rows[rand][4])
    joker.joke = rows[rand][1]
    joker.joke_date = rows[rand][3]
    date = str(joker.joke_date.day) + "/" + str(joker.joke_date.month) +"/"+ str(joker.joke_date.year)
    time = str(joker.joke_date.hour) + ":" + str(joker.joke_date.minute) +":"+ str(joker.joke_date.second)
    info = "le " + date + " à " + time
    query = "SELECT user_pseudo FROM user WHERE user_id = " + str(joker.id)
    joker.pseudo = bdd.request(query, 3)[0]
    joker.nickname, joker.avatar = getNicknameAndAvatar(client.guilds, joker.pseudo)
    return embed.sendEmbed(joker.avatar, joker.nickname, joker.joke, info)



def addJoke(joker): # insert != select pour methode ???
    request = 'SELECT user_id FROM user WHERE user_pseudo = "' + str(joker.pseudo) + '"'
    joker.id = bdd.request(request, 3)
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
    request = 'INSERT INTO `joke` (`joke`, `joke_vote`, `joke_date`, `user_id`) VALUES ("' + str(joker.joke) + '", "0", "' + str(joker.joke_date) + '", "' + str(joker.id) + '");'
    bdd.request_insert(request)
    return 0


def getJokeTest(client): # a factoriser
    joker = joke.Joke()
    rows = bdd.request("SELECT * FROM joke WHERE joke_vote = 0", 1)
    rand = randint(1, len(rows)) - 1
    joker.id = int(rows[rand][4])
    joker.joke = rows[rand][1]
    joker.joke_date = rows[rand][3]
    date = str(joker.joke_date.day) + "/" + str(joker.joke_date.month) +"/"+ str(joker.joke_date.year)
    time = str(joker.joke_date.hour) + ":" + str(joker.joke_date.minute) +":"+ str(joker.joke_date.second)
    info = "le " + date + " à " + time
    query = "SELECT user_pseudo FROM user WHERE user_id = " + str(joker.id)
    joker.pseudo = bdd.request(query, 3)[0]
    joker.nickname, joker.avatar = getNicknameAndAvatar(client.guilds, joker.pseudo)
    return embed.sendEmbed(joker.avatar, joker.nickname, joker.joke, info)

def getNicknameAndAvatar(guilds, pseudo):
    for guild in guilds:
        for member in guild.members:
            p = str(member.name) + "#" + str(member.discriminator)
            if pseudo == p:
                return member.display_name, member.avatar_url