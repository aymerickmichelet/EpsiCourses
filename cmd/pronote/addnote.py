import discord
import value
import sql

def existPseudo(fetchall, pseudo):
	for row in fetchall:
		if row[1] == pseudo:
			return row
	return None

def pseudoCompetence(pseudo, competence, note=None):
	bdd = sql.Connection()
	bdd.cursor.execute("SELECT * FROM people")
	fetchall = bdd.cursor.fetchall()
	user = existPseudo(fetchall, pseudo)
	me = existPseudo(fetchall, value.getValue('message').author)
	if user != None: #si pseudo msg sont dans bdd
		if value.findClass(user[4]) == 1:
			if note == None:
				return ">pronote add note pseudo competence <note>\nexemple syntaxe note: 10/20"
			else:
				try:
					discriminant = note.split("/")[1]
					note = note.split("/")[0]
					bdd.cursor.execute("INSERT INTO note (studient, professor, skill, nominator, denominator) VALUES (%s, %s, %s, %s, %s)", (user[0], me[0], competence, note, discriminant,))
					bdd.bdd.commit()
				except:
					return "Une erreur est survenu lors de l'envoie de la note...\n"
		else:
			return "L'utilisateur n'a pas de classe enregistré...\ndemander à l'administration pour régler le problème..."
	else:
		return "Vous ou l'utilisateur énoncé n'est soit, pas correct, soit pas enregistré dans la base de donnée"