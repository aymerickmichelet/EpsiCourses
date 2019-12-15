import discord
from help import help
import value
import adduser
import addnote
import removeuser
import refreshuser
import listuser
import listcompetence

#----------------------------------------------------------------------------------------------------------------#
# >pronote(0)   add(1)       user(1.1)         all(1.1.1)                                                        #
#                                              pseudo(1.1.2)                                                     #
#                            note(1.2)         all(1.2.1)      class(1.2.1.1)          competence(1.2.1.1.1)     #
#                                              pseudo(1.2.2)   competence(1.2.2.1)                               #
#               remove(2)    user(2.1)         all(2.1.1)                                                        #
#                                              pseudo(2.1.2)                                                     #
#                                              class(2.1.3)                                                      #
#                            note(2.2)         all(2.2.1)                                                        #
#                                              pseudo(2.2.2)   all(2.2.2.1)                                      #
#                                                              (competence)(2.2.2.2)                             #
#                                              class(2.2.3)    all(2.2.3.1)                                      #
#                                                              competence(2.2.3.2)                               #
#               list(3)      user(3.1)         all(3.1.1)                                                        #
#                                              class(3.1.2)                                                      #
#                            note(3.2)         all(3.2.1)                                                        #
#                                              class(3.2.2)    all(3.2.2.1)                                      #
#                                                              competence(3.2.2.2)                               #
#                            competence(3.3)   all(3.3.1)                                                        #
#                                              class(3.3.2)                                                      #
#               refresh(4)   user(4.1)                                                                           #
#----------------------------------------------------------------------------------------------------------------#

client = value.getValue('client')
message = value.getValue('message')

def pronote():
	args = value.getValue('args')
	length = value.getValue('length')

	#await client.send_message(message.channel, "WESH ALORS")

	if length > 1: #si args = 1 existe
		if args[1] == "add":                               # add
			return add()
		elif args[1] == "remove":                          # remove
			return remove()
		elif args[1] == "list":                            # list
			return liste()
		elif args[1] == "refresh":                         # refresh
			return refresh()
		else:
			return help('0')
	else:
		return help('0')

#--------------------------------------------------------------------------------------------# add
def add():                                                                                   #
	args = value.getValue('args')                                                            #
	length = value.getValue('length')                                                        #
	                                                                                         #
	if length > 2: #si args = 2                                                              #
        #------------------------------------------------------------------------------------# add user <all/pseudo>
		if args[2] == "user":                                                                #
			if length > 3: #si args = 3                                                      #
				if args[3] == "all":                                                         #
					return adduser.all()                                                     #
				elif adduser.existPseudoDiscord(args[3]) != None:                            #
					return adduser.pseudo(adduser.existPseudoDiscord(args[3]))               #
				else:                                                                        #
					return help('1.1')                                                       #
			else:                                                                            #
				return help('1.1')                                                           #
		#------------------------------------------------------------------------------------# add note <all/pseudo>
		elif args[2] == "note":                                                              #
			if length > 3:                                                                   #
			    #----------------------------------------------------------------------------# add note all <class> <competence>
				if args[3] == "all":                                                         #
					if length > 4:                                                           #
						if value.findClass(args[4]) == 1:                                    #
							if length > 5:                                                   #
								if value.findCompetence(args[5]) == 1:                       #
									return ">pronote add note all class competence" # add note all class competence
								else:                                                        #
									return help('1.2.1.1')                                   #
							else:                                                            #
								return help('1.2.1.1')                                       #
						else:                                                                #
							return help('1.2.1')                                             #
					else:                                                                    #
						return help('1.2.1')                                                 #
				#----------------------------------------------------------------------------# add note pseudo <competence>
				elif "#" in args[3]:                                                         #
					if length > 4:                                                           #
						if value.findCompetence(args[4]) == 1: # add note pseudo class competence
							if length > 5:                                                   #
								return addnote.pseudoCompetence(args[3], args[4], args[5])   #
							else:                                                            #
								return addnote.pseudoCompetence(args[3], args[4])            #
						else:                                                                #
							return help('1.2.2')                                             #
					else:                                                                    #
						return help('1.2.2')                                                 #
				#----------------------------------------------------------------------------#
				else:                                                                        #
					return help('1.2')                                                       #
			else:                                                                            #
				return help('1.2')                                                           #
		#------------------------------------------------------------------------------------#
		else:                                                                                #
			return help('1')                                                                 #
	else:                                                                                    #
		return help('1')                                                                     #
                                                                                             #
#--------------------------------------------------------------------------------------------# remove
def remove():                                                                                #
	args = value.getValue('args')                                                            #
	length = value.getValue('length')                                                        #
                                                                                             #
	if length > 2:                                                                           #
        #------------------------------------------------------------------------------------# remove user <all/pseudo/class>
		if args[2] == "user":                                                                #
			if length > 3:                                                                   #
				if args[3] == "all":                                                         #
					return removeuser.all() # remove user all                                #
				elif value.findClass(args[3]) == 1:                                          #
					return removeuser.classe(args[3]) #remove user class                     #
				elif "#" in args[3]:                                                         #
					return removeuser.pseudo(args[3]) # remove user pseudo                   #
				else:                                                                        #
					return help('2.1')                                                       #
			else:                                                                            #
				return help('2.1')                                                           #
        #------------------------------------------------------------------------------------# remove note <all/pseudo/class>
		elif args[2] == "note":                                                              #
			if length > 3:                                                                   #				
				if args[3] == "all":                                                         #
					print(">pronote remove note all") # remove user note all                 #
				#----------------------------------------------------------------------------# remove note pseudo <all/competence>
				elif "#" in args[3]:                                                         #
					if length > 4:                                                           #
						if args[4] == "all":                                                 #
							return ">pronote remove note pseudo all" # remove note pseudo all#
						elif value.findCompetence(args[4]) == 1:                             #
							return ">pronote remove note pseudo competence" # remove user note pseudo competence
						else:                                                                #
							return help('2.2.2')                                             #
					else:                                                                    #
						return help('2.2.2')                                                 #
				#----------------------------------------------------------------------------# remove note class <all/competence>
				elif value.findClass(args[3]) == 1:                                          #
					if length > 4:                                                           #
						if args[4] == "all":                                                 #
							return ">pronote remove note class all" #remove note class all   #
						elif value.findCompetence(args[4]) == 1:                             #
							return ">pronote remove note class competence" # remove note class competence
						else:                                                                #
							return help('2.2.3')                                             #
					else:                                                                    #
						return help('2.2.3')                                                 #
				else:                                                                        #
					return help('2.2')                                                       #
			else:                                                                            #
				return help('2.2')                                                           #
		else:                                                                                #
			return help('2')                                                                 #
	else:                                                                                    #
		return help('2')                                                                     #
#--------------------------------------------------------------------------------------------# list
def liste():                                                                                 #
	args = value.getValue('args')                                                            #
	length = value.getValue('length')                                                        #
                                                                                             #
	if length > 2: #si args = 2                                                              #
		#------------------------------------------------------------------------------------# list user <_/all/class>
		if args[2] == "user":                                                                #
			if length > 3:                                                                   #
				if args[3] == "all":                                                         #
					return listuser.all() # list user all                                    #
				elif value.findClass(args[3]) == 1:                                          #
					return listuser.classe(args[3]) #list user class                         #
				else:                                                                        #
					return help('3.1')                                                       #
			else:                                                                            #
				return help('3.1')                                                           #
		#------------------------------------------------------------------------------------# list note <all/class>
		elif args[2] == "note":                                                              #
			if length > 3:                                                                   #
				if args[3] == "all":                                                         #
					return ">pronote list note all" #list note all                           #
				#----------------------------------------------------------------------------# list note class <all/competence>
				elif value.findClass(args[3]) == 1:                                          #
					if length > 4:                                                           #
						if args[4] == "all":                                                 #
							return ">pronote list note class all" #list note class all       #
						elif value.findCompetence(args[4]) == 1:                             #
							return ">pronote list note class competence" #list note class competence
						else:                                                                #
							return help('3.2.2')                                             #
					elif length == 4:                                                        #
						return ">pronote list note class" #list note class                   #
					else:                                                                    #
						return help('3.2.2')                                                 #
				else:                                                                        #
					return help('3.2')                                                       #
			else:                                                                            #
				return help('3.2')                                                           #
		#------------------------------------------------------------------------------------# list competence <all/class>
		elif args[2] == "competence":                                                        #
			if length > 3:                                                                   #
				if args[3] == "all":                                                         #
					return listcompetence.all() #list competence all               #
				elif value.findClass(args[3]) == 1:                                          #
					return listcompetence.classe(args[3]) #list competence class             #
				else:                                                                        #
					return help('3.3')                                                       #
			else:                                                                            #
				return help('3.3')                                                           #
		#------------------------------------------------------------------------------------#
		else:                                                                                #
			return help('3')                                                                 #
	else:                                                                                    #
		return help('3')                                                                     #
#--------------------------------------------------------------------------------------------# refresh
def refresh():                                                                               #
	args = value.getValue('args')                                                            #
	length = value.getValue('length')                                                        #
                                                                                             #
	if length > 2:                                                                           #
		#------------------------------------------------------------------------------------# refresh user
		if args[2] == "user":                                                                #
			return refreshuser.user()                                                        #
		else:                                                                                #
			return help('4')                                                                 #
	else:                                                                                    #
		return help('4')                                                                     #
#--------------------------------------------------------------------------------------------#