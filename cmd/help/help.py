import discord
import value
#import asyncio

client = value.getValue('client')
message = value.getValue('message')

def help(v):
	description = ""
	if v == "-1": #cas générale
		description = "Listes de l'ensemble des commandes du bot pronote:"
		liste = []

		liste2 = []
		liste2.append(">pronote add user all")
		liste2.append("Ajoute tout les joueurs à la base de donnée")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote add user pseudo")
		liste2.append("Ajoute un joueur (pseudo#9999) à la base de donnée")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote add note class competence")
		liste2.append("Ajoute les notes d'une classe sur une competence")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote add note pseudo competence")
		liste2.append("Ajoute une note d'un eleve sur une competence")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote remove user all")
		liste2.append("Supprime toutes les utilisateurs")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote remove user pseudo")
		liste2.append("Supprime un utilisateur")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote remove user class")
		liste2.append("Supprime les utilisateurs d'une classe")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote remove note all")
		liste2.append("Supprime toutes les notes")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote remove note pseudo all")
		liste2.append("Supprime toutes les notes d'un eleve")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote remove note pseudo competence")
		liste2.append("Supprime un note d'un etudiant")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote remove note class all")
		liste2.append("Supprime les notes de toutes un classe")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote remove note class competence")
		liste2.append("Supprime toutes les notes d'une compétence")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote list user all")
		liste2.append("Liste tout les utilisateurs du serveur enregistrés")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote list user class")
		liste2.append("Liste tout les utilisateurs d'une classe")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote list note all")
		liste2.append("Liste toutes les notes")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote list note class all")
		liste2.append("Liste toutes les notes d'une classe")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote list note class competence")
		liste2.append("Liste toutes les notes d'une comperence")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote list competence all")
		liste2.append("Liste toutes les competences")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote list competence class")
		liste2.append("Liste toutes les competences d'une classe")
		liste.append(liste2)

		liste2 = []
		liste2.append(">pronote refresh user")
		liste2.append("Refresh toutes les informations en rapport avec les utilisateurs")
		liste.append(liste2)

		return description,liste
	elif v == "0":
		description = ">pronote <add/remove/list/refresh>"
	elif v == "1":
		description = ">pronote add <user/note>"
	elif v == "1.1":
		description = ">pronote add user <all/pseudo>"
	elif v == "1.2":
		description = ">pronote add note <all/pseudo>"
	elif v == "1.2.1":
		description = ">pronote add note all <class> <competence>"
	elif v == "1.2.1.1":
		description = ">pronote add note all class <competence>"
	elif v == "1.2.2":
		description = ">pronote add note pseudo <competence>"
	elif v == "2":
		description = ">pronote remove <user/note>"
	elif v == "2.1":
		description = ">pronote remove user <all/pseudo/class>"
	elif v == "2.2":
		description = ">pronote remove note <all/pseudo/class>"
	elif v == "2.2.2":
		description = ">pronote remove note pseudo <all/competence>"
	elif v == "2.2.3":
		description = ">pronote remove note class <all/competence>"
	elif v == "3":
		description = ">pronote list <user/note/competence>"
	elif v == "3.1":
		description = ">pronote list user <all/class>"
	elif v == "3.2":
		description = ">pronote list note <all/class>"
	elif v == "3.2.2":
		description = ">pronote list note class <all/competence>"
	elif v == "3.3":
		description = ">pronote list competence <all/class>"
	elif v == "4":
		description = ">pronote refresh <user>"
	return description