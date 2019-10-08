# bot.py
import discord
import joke
import embed
import vocabulary
import blf

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

    joker.pseudo = message.author

    # transformer message.content par variable (toLower)

    if message.author != client.user: # si le message vient d'un user
        if message.channel.id == channel_id: # et si il est dans le channel BotLeflip.espace-bot
            await message.delete() # le message de l'user est supprimé
        elif message.channel != message.author.dm_channel: # si le message n'est pas en mp
            return
    else: #si il vient du bot
        return # on ne poursuit pas le code

    if step == 0: # etape des commandes
        if vocabulary.getAnswerWakeup(message.content) == 1: # si message.content est accepté
            await message.author.send("Salut, moi c'est le Bot LeFlip ^^\n1 - Tu veux que je te raconte une blague ?\n2 - Tu veux me raconter une blague ?\n3 - Où tu veux rentrer/sortir du registre des cobailles de mes blagues ?")
            step = 1
        elif message.content.find("!info") == 0:
            await message.channel.send("Si toi aussi tu veux me parler, tape ```!blf```") # on peut developper (/help)
        else:
            return
    elif step == 1:
        step = False
        if vocabulary.getAnswerGetJoke(message.content) == 1:
            await message.channel.send("C'est partie !")
            joker.joke = blf.getJoke()
            await message.channel.send(embed=joker.joke)
            joker.joke = ""
        elif vocabulary.getAnswerAddJoke(message.content) == 1:
            await message.channel.send("Je vois... Fais moi rêver !")
            step = 1.2
        elif vocabulary.getAnswerExperience(message.content) == 1:
            await message.channel.send("Pour le moment, je n'engage personne... mais je reviendrais vers toi dans quelques temps.")
            # await message.channel.send("Super c'est noté ! tu vas voir elles sont géniales.")
            # await message.channel.send("Dommage... Tu vas me manquer")
            step = 0
        else:
            await message.channel.send("Si tu le prends comme ça...")
    elif step == 1.2: # si joke ne contient rien (a dev)
        if joker.joke != "": # si joke contient la blague
            if message.content.find("oui") == 0:
                if blf.addJoke(joker) == 0:
                    await message.channel.send("Très bien, c'est noté !")
                else:
                    await message.channel.send("Humm, je n'arrive pas à mémoriser ta blague...")
                joker.step = 0
                #envoyer message nouveau joke au cobaye
            elif message.content.find("non") == 0:
                await message.channel.send("Bon d'accord, repète moi tout ça.")
            else:
                await message.channel.send("Bon, tu reviendras quand tu ne seras plus indécis...")
                step = 0
            joker.joke = ""
        else: # si joke est vide
            joker.joke = message.content
            await message.channel.send("C'est bien ça ?")
            await message.channel.send(embed=embed.sendEmbed(joker.joke))
            # récupérer l'heure et l'user
            # faire un objet


client.run(token)


#--------------------------------#