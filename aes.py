from Crypto.Cipher import AES
from Crypto import Random
import unidecode

filename = "file.txt"
key = "This is a key123"
mod = AES.MODE_CBC
jsp = "This is an IV456"
# jsp = Random.new().read(AES.block_size)


def read() -> list:
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


def write(content: list) -> None:
    global filename, key, mod, jsp
    lines16bytes = content
    open(filename, "w").write("")
    file = open(filename, "a")
    for line in lines16bytes:
        for field in line:
            print(field)
            obj = AES.new(key, mod, jsp)
            temp = obj.encrypt(field)
            file.write(str(temp))
    file.close()


def encrypt():
    write(read())


encrypt()


# obj = AES.new('This is a key123', AES.MODE_CBC, 'This is an IV456')
# message = "Steven Larson"
# ciphertext = obj.encrypt(message)
#
# print(ciphertext)
#
# obj2 = AES.new('This is a key123', AES.MODE_CBC, 'This is an IV456')
# print(obj2.decrypt(ciphertext))
#
# # lire le fichier, ajaouter chaque ligne dans une liste, chiffrer les lignes de la liste
