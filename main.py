# bot.py
import discord
import joke
import embed
import vocabulary
import blf
import datetime

token = "NTY1NDE5ODIzODU3OTI2MTU3.XYj4hA.eVuudHCjwY5ZkIyx3SeShJWt2rc"
client = discord.Client()
channel_id = 625737003383914516
joker = joke.Joke()
step = 0


@client.event
async def on_ready():
    print(f'{client.user} has connected to Discord!')
    print(client.user.id)
    print('------')


@client.event
async def on_message(message):
    global step, channel_id, joker

    # transformer message.content par variable (toLower)

    if message.author != client.user: # si le message vient d'un user
        joker.pseudo = str(message.author)
        joker.nickname, joker.avatar = blf.getNicknameAndAvatar(client.guilds, joker.pseudo)
        if message.channel.id == channel_id: # et si il est dans le channel BotLeflip.espace-bot
            await message.delete() # le message de l'user est supprimé
        elif message.channel != message.author.dm_channel: # si le message n'est pas en mp
            return
    else: #si il vient du bot
        return # on ne poursuit pas le code

    if step == 0: # etape des commandes
        if vocabulary.getAnswerWakeup(message.content) == 1: # si message.content est accepté
            await message.author.send("Salut, moi c'est le Bot LeFlip ^^\n1 - Tu veux que je te raconte une blague ?\n2 - Tu veux me raconter une blague ?\n3 - Où tu veux tester mes blagues en préparation ?")
            step = 1
        elif message.content.find("!info") == 0:
            await message.channel.send("Si toi aussi tu veux me parler, tape ```!blf```") # on peut developper (/help)
        else:
            return
    elif step == 1:
        step = False
        if vocabulary.getAnswerGetJoke(message.content) == 1:
            await message.channel.send("Une blague ? j'en ai une excellente !")
            joker.joke = blf.getJoke(client)
            await message.channel.send(embed=joker.joke)
            await message.channel.send("En veux-tu une autre ?")
            step = 1.1
        elif vocabulary.getAnswerAddJoke(message.content) == 1:
            await message.channel.send("Je vois... Fais moi rêver !")
            step = 1.2
        elif vocabulary.getAnswerExperience(message.content) == 1:
            await message.channel.send("Okay mais soit indulgeant... hein !")
            joker.joke = blf.getJokeTest(client)
            await message.channel.send(embed=joker.joke)
            await message.channel.send("En veux-tu une autre ?")
            step = 1.3
        else:
            await message.channel.send("Si tu le prends comme ça...")
    elif step == 1.1:
        if message.content.find("oui") == 0:
            await message.channel.send("une autre blague ? j'en ai une excellente !")
            joker.joke = blf.getJoke(client)
            await message.channel.send(embed=joker.joke)
            await message.channel.send("En veux-tu une autre ?")
        else:
            await message.channel.send("Très bien ca marche ^^")
            joker.joke = ""
            step = 0
    elif step == 1.2:
        if joker.joke != "": # si joke contient la blague
            if message.content.find("oui") == 0:
                if blf.addJoke(joker) == 0:
                    await message.channel.send("Très bien, c'est noté !")
                else:
                    await message.channel.send("Humm, je n'arrive pas à mémoriser ta blague...")
                step = 0
                #envoyer message nouveau joke au cobaye
            elif message.content.find("non") == 0:
                await message.channel.send("Tu abandonnes déjà ?")
                step = 1.23
            else:
                await message.channel.send("Bon, tu reviendras quand tu ne seras plus indécis...")
                step = 0
            joker.joke = ""
        else: # si joke est vide
            joker.joke = message.content
            await message.channel.send("C'est bien ça ?")
            joker.joke_date = datetime.datetime.now()
            date = str(joker.joke_date.day) + "/" + str(joker.joke_date.month) +"/"+ str(joker.joke_date.year)
            time = str(joker.joke_date.hour) + ":" + str(joker.joke_date.minute) +":"+ str(joker.joke_date.second)
            info = "le " + date + " à " + time
            await message.channel.send(embed=embed.sendEmbed(joker.avatar, joker.pseudo, joker.joke, info))
    elif step == 1.23:
        if message.content.find("non") == 0:
            step = 1.2
            await message.channel.send("Ah tu m'as fait peur ! répète moi ça alors:")
        else:
            step = 0
            await message.channel.send("Moi qui croyait en toi...")
    elif step == 1.3:
        if message.content.find("oui") == 0:
            await message.channel.send("ca marche, dit moi ce que tu penses de celle là !")
            joker.joke = blf.getJokeTest(client)
            await message.channel.send(embed=joker.joke)
            await message.channel.send("En veux-tu une autre ?")
        else:
            step = 0
            joker.joke = ""
            await message.channel.send("Merci de m'avoir écouté !")


client.run(token)


#--------------------------------#