from Crypto.Cipher import AES
from Crypto import Random
import unidecode

filename = "file.txt"
key = "This is a key123"
mod = AES.MODE_CBC
jsp = "This is an IV456"


def read_encrypt() -> list:
    global filename
    file = open(filename, "r")
    result = []
    for line in file.readlines():
        line = unidecode.unidecode(line)
        l_split = line.split(";")
        l_dollars = []
        for field in l_split:
            field = field.strip('\n')
            for x in range(16-len(field)):
                field += '$'
            l_dollars.append(field)
        result.append(l_dollars)
        file.close()
    return result


def write_encrypt(content: list) -> None:
    global filename, key, mod, jsp
    lines16bytes = content
    open(filename, "w").write("")
    file = open(filename, "a")
    for line in lines16bytes:
        for field in line:
            # print(field)
            obj = AES.new(key, mod, jsp)
            temp = obj.encrypt(field)
            file.write(str(temp))
            print(temp)

    file.close()


def decrypt():
    global filename

    file = open(filename, "r")
    result = []
    delimitor = None

    # content = file.read().replace("'b'", "€") # "'b'" => "b" ?
    # l_split = content.split("€")

    content = file.read()

    while len(content) > 1:
        delimitor = None
        if "'" in content:
            simple = content.index("'")
        else:
            simple = 10000000000
        if '"' in content:
            double = content.index('"')
        else:
            double = 10000000000

        if simple < double:
            delimitor = "'"
        else:
            delimitor = '"'

        content = content[content.index(delimitor) + 1:]

        second_delimitor = content.index(delimitor)

        field = content[:second_delimitor]

        result.append(field)
        # result.append(field)

        content = content[second_delimitor + 1:]

        print(result[-1])

    print("-=-=-=-=-=-=-=-=-=-")

    obj2 = AES.new(key, mod, jsp)

    for field in result:
        print(str(field) + " - " + str(type(field)))
        # print(obj2.decrypt(field))
        # réécrire dans le fichier .txt


def encrypt():
    write_encrypt(read_encrypt())




encrypt()

# decrypt()

# obj = AES.new('This is a key123', AES.MODE_CBC, 'This is an IV456')
# message = "aaaSteven Larson"
# ciphertext = obj.encrypt(message)
#
# print(ciphertext)

# obj2 = AES.new('This is a key123', AES.MODE_CBC, 'This is an IV456')
# print(obj2.decrypt(b'\xc6\xd8H}\xb7Iw\xec**Y`O}\x18\xa1'))

# # lire le fichier, ajaouter chaque ligne dans une liste, chiffrer les lignes de la liste

# b'\xc6\xd8H}\xb7Iw\xec**Y`O}\x18\xa1'
