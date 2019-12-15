import discord
import value
import sql

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

def existPseudoDiscord(pseudo_bdd, members):
	for member in members:
		if pseudo_bdd == str(member):
			return 1
	return 0

def user():
	members = value.getValue('message').server.members
	bdd = sql.Connection()
	bdd.cursor.execute("SELECT * FROM people")
	fetchall = bdd.cursor.fetchall()
	for row in fetchall:
		if existPseudoDiscord(row[1], members) == 0:
			try:
				bdd.cursor.execute("DELETE FROM people WHERE people.id_people = %s", (row[0],))
				bdd.bdd.commit()
			except:
				return "Sql Connection Error: Un ou plusieurs joueurs n'ont pas pu êter refresh..."
	for member in members:
		if isBot(member.roles) == 0:
			data = str(member)
			if existPseudo(fetchall, data) == 0:
				try:
					bdd.cursor.execute("INSERT INTO people (pseudo_discord) VALUES (%s)", (data,))
					bdd.bdd.commit()
				except:
					return "Sql Connection Error: Un ou plusieurs joueurs n'ont pas pu êter refresh..."
	#bdd.cursor.execute("SELECT * FROM people")
	#fetchall = bdd.cursor.fetchall()
	#for row in fetchall:
	#comparer row
	return "Tous les utilisateurs ont été refresh"
