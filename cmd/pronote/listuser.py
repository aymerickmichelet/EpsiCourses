import discord
import value
import sql

# 3.1.1 - >pronote list user all
# 3.1.2 - >pronote list user class


def all():
	liste = []
	order = ["B1","B2","B3","I4","I5","Professeur","Administration",None]
	
	bdd = sql.Connection()
	bdd.cursor.execute("SELECT * FROM people")
	fetchall = bdd.cursor.fetchall()
	for x in range(0,len(order)):
		liste2 = [order[x], ""]
		for line in fetchall:
			if order[x] == line[4]:
				liste2[1] += str(line[1]) + " | " + str(line[2]) + " | " + str(line[3]) + " | " + str(line[5]) + "\n"
		if liste2[1]:
			liste.append(liste2)
	if liste:
		description = "Voici la liste de tous les membres de l'EPSI Paris:"
		return description,liste
	else:
		description = "Il n'y a pas de membre pour l'instant à l'EPSI Paris..."
		return description

def classe(classe):
	liste = []

	bdd = sql.Connection()
	bdd.cursor.execute("SELECT * FROM people")
	fetchall = bdd.cursor.fetchall()
	
	liste2 = [classe, ""]
	for line in fetchall:
		if classe == line[4]:
			liste2[1] += str(line[1]) + " | " + str(line[2]) + " | " + str(line[3]) + " | " + str(line[5]) + "\n"
	if liste2[1]:
		liste.append(liste2)
		description = "Voici la liste de tous les membres de '"+str(classe)+"' de l'EPSI Paris:"
		return description,liste
	else:
		description = "Il n'y a pas de membre dans '"+str(classe)+"' de l'EPSI Paris..."
		return description