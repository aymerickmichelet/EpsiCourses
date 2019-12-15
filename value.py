import discord

client = discord.Client()   #obj discord
message = ""                #message obj discord
args = ""                   #message split
length = ""                 #length args

list_class = ["B1","B2","B3","I4","I5","Professeur","Administration"]
bloc_competence = ["1.1","1.2","1.3","2.1","2.2","2.3","3.1","3.2","3.3","3.4","3.5","3.6","4.1","4.2","5.1","5.2"]

def getValue(variable):
	global client
	global message
	global args
	global length
	if variable == "client":
		return client
	if variable == "message":
		return message
	elif variable == "args":
		return args
	elif variable == "length":
		return length

def setValue(variable, value):
	global client
	global message
	global args
	global length
	if variable == "client":
		client = value
	if variable == "message":
		message = value
	elif variable == "args":
		args = value
	elif variable == "length":
		length = value	
	

def compareChannelList(message):
	for name in channel_list:
		if message.channel.name == name:
			return 1

def findClass(value): #si return 1, value est dans list. sinn return 0
	global list_class
	for classe in list_class:
		if value == classe:
			return 1
	return 0

def findCompetence(value): #si return 1, value est dans list. sinn return 0
	global bloc_competence
	for competence in bloc_competence:
		if value == competence:
			return 1
	return 0