
def offusc():
    file = open("Liste_des_gagnants_du_Loto.txt", "r")
    first_line = True
    new_file_content = ""

    for line in file:
        if first_line:
            first_line = False
            new_file_content += line
        else:
            array_line = line.split(";")
            names = array_line[0]
            date = array_line[1]

            names_off = offusc_array("&", names, " ")
            date_off = offusc_array("#", date, "/")
            new_file_content += names_off + ";" + date_off + ";" + array_line[2] + ";" + array_line[3]

    file.close()
    writing_file = open("Liste_des_gagnants_du_Loto_off.txt", "w+")
    writing_file.write(new_file_content)
    writing_file.close()



def offusc_array(char_replace, string, escape):

    array_replace = list(string)

    for i in range(len(array_replace)):
        if array_replace[i] != escape:
            array_replace[i] = char_replace

    return "".join(array_replace)





