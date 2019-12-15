import mysql.connector

#
# LIKE
# INSERT
# SELECT
# 
#

# attributs:
#	bdd
#	cursor
#	
# fonctions:
# 	__init__(self)
# 	

class Connection:
	
	def __init__(self):
		try:
			self.bdd = mysql.connector.connect(
				       user="aymerick",
				       password="holaquetal",
				       host="localhost",
				       database="pronote")
			self.cursor = self.bdd.cursor()
		except:
			print('[Sql Connection Error] > mysql.connector.connect')