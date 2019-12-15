bot qui permet de gérer les notes de chacune des personnes de la classe

tu peux demander au bot plusieurs choses:
- d'enregistrer tes notes
- d'afficher tes notes
- d'afficher les notes de quelqu'un d'autre (si il est ok)
- d'afficher la moyenne de la classe, la sienne, d'un(e) élève...
- d'afficher tes paramètres


______________________________________________________

|-----------------------------people---------------------------------|
| id_people | pseudo_discord | name | last_name | class | birth_date |
|--------------------------------------------------------------------|

fonction(studient, professor, administrator)
classe(B1, B2, B3, I1, I2)

|-------------------------------------------note---------------------------------------------|
| id_note | studient (#id_people) | professor (#id_people) | skill | numerator | denominator |
|--------------------------------------------------------------------------------------------|

bloc_competence(1.1, 1.2, 1.3, 2.1, 2.2, 2.3, 3.1, 3.2, 3.3, 3.4, 3.5, 3.6, 4.1, 4.2, 5.1, 5.2)

|--------------------competence-----------------------|
| id_bloc_competence | class | bloc_competence | name |
|-----------------------------------------------------|


COMMANDS:
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