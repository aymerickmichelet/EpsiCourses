import discord
import sql

def classeAll(classe):




def classeCompetence(classe, competence):


	
	bdd = sql.Connection()
	bdd.cursor.execute("SELECT * FROM note")
	fetchall = bdd.cursor.fetchall()