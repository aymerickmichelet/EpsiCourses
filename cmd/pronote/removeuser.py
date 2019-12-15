import discord
import value
import sql

def existPseudo(fetchall, pseudo):
	for row in fetchall:
		if row[1] == pseudo:
			return row
	return None

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
	for row in fetchall:
		try:
			bdd.cursor.execute("DELETE FROM people WHERE people.id_people = %s", (row[0],))
			bdd.bdd.commit()
		except:
			return "Un ou plusieurs joueurs n'ont pas pu être supprimé de la base de donnée\npour plus de detail, '>pronote list user all'"
	return "Tous les joueurs ont été supprimé de la base de donnée."

def pseudo(pseudo):
	bdd = sql.Connection()
	bdd.cursor.execute("SELECT * FROM people")
	fetchall = bdd.cursor.fetchall()
	data = existPseudo(fetchall, str(pseudo))
	if data != None:
		try:
			bdd.cursor.execute("DELETE FROM people WHERE people.id_people = %s", (data[0],))
			bdd.bdd.commit()
		except:
			return "Le joueur n'a pas pu être supprimé de la base de donnée."
	else:
		return "Le joueur n'est pas présent de la base de donnée"
	return "Le joueur est supprimé de la base de donnée."

def classe(classe):
	bdd = sql.Connection()
	bdd.cursor.execute("SELECT * FROM people")
	fetchall = bdd.cursor.fetchall()
	for line in fetchall:
		if classe == line[4]:
			try:
				bdd.cursor.execute("DELETE FROM people WHERE people.id_people = %s", (line[0],))
				bdd.bdd.commit()
			except:
				return "Le joueur n'a pas pu être supprimé de la base de donnée."
	return "La classe "+str(classe)+" ne possède à présent plus de membre."