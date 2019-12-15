import discord
from package import setPath
setPath()
from pronote import pronote
import value
import help 
import sql

client = value.getValue('client')

#Event Join
@client.event
async def on_ready():
	print("[", client.user.name,"] Enable")

#Event Commande
@client.event
async def on_message(message):

	if message.author == client.user:
		return

	if message.channel.name == "espace-bot":
		await client.delete_message(message)
		setter(message)
		if message.content.startswith('>pronote'):
			result = pronote()
			await client.send_message(message.channel, embed=setEmbed(result))
		elif message.content.startswith('>clear'):
			await client.purge_from(value.getValue('message').channel)
			print(">clear")
		elif message.content.startswith('>help'):
			result = help.help('-1')
			await client.send_message(message.channel, embed=setEmbed(result))


def setEmbed(liste):
	if type(liste) == str:
		embed=discord.Embed(title=value.getValue('message').content, description=liste)
		return embed
	elif type(liste) == tuple:
		embed=discord.Embed(title=value.getValue('message').content, description=liste[0])
		for x in range(0,len(liste[1])):
			embed.add_field(name=liste[1][x][0], value=liste[1][x][1], inline=False)
		return embed

def setter(message):
	value.setValue('message', message)
	args = message.content.split()
	length = len(args)
	value.setValue('args', args)
	value.setValue('length', length)

client.run("NTQ0ODg1NTY5MDA0NzY1MjE0.D3PpRw.CAnhp-xcoSEKpFMnGF8y8uiyYdg")