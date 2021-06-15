

def anony():
    file = open("Liste_des_gagnants_du_Loto.txt", "r")
    first_line = True
    new_file_content = ""

    for line in file:
        if first_line:
            first_line = False
            new_file_content += line
        else:
            array_line = line.split(";")
            names = array_line[0].split(" ")
            date = array_line[1].split("/")

            ano_name = names[0][0] + names[1][0]
            ano_date = date[-1]

            new_file_content += ano_name + ";" + ano_date + ";" + array_line[2] + ";"+ array_line[3]

    file.close()

    writing_file = open("Liste_des_gagnants_du_Loto_ano.txt", "w+")
    writing_file.write(new_file_content)
    writing_file.close()









