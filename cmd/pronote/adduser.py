import discord
import sql
import value

# 1.1.1     - >pronote add user all
# 1.1.2     - >pronote add user pseudo

def isBot(roles):
	for role in roles:
		if str(role) == "Bot":
			return 1
	return 0

def existPseudo(fetchall, pseudo):
	for row in fetchall:
		if row[1] == pseudo:
			return 1
	return 0

def existPseudoDiscord(pseudo):
	members = value.getValue('message').server.members
	for member in members:
		if str(member).lower() == str(pseudo).lower():
			return member
	return None

def all():
	members = value.getValue('message').server.members
	bdd = sql.Connection()
	bdd.cursor.execute("SELECT * FROM people")
	fetchall = bdd.cursor.fetchall()
	for member in members:
		if isBot(member.roles) == 0:
			data = str(member)
			if existPseudo(fetchall, data) == 0:
				try:
					bdd.cursor.execute("INSERT INTO people (pseudo_discord) VALUES (%s)", (data,))
					bdd.bdd.commit()
				except:
					return "Un ou plusieurs joueurs n'ont pas pu être ajouté à la base de donnée."
	return "Les joueurs ont été ajouté à la base de donnée."

def pseudo(pseudo):
	bdd = sql.Connection()
	bdd.cursor.execute("SELECT * FROM people")
	fetchall = bdd.cursor.fetchall()
	if isBot(pseudo.roles) == 0:
		data = str(pseudo)
		if existPseudo(fetchall, data) == 0:
			try:
				bdd.cursor.execute("INSERT INTO people (pseudo_discord) VALUES (%s)", (data,))
				bdd.bdd.commit()
			except:
				return "Le joueur n'a pas pu être ajouté à la base de donnée."
		else:
			return "Le joueur est déjà present à la base de donnée."

	return "Le joueur a été ajouté à la base de donnée."