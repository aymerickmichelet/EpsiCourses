from Crypto.Cipher import Blowfish
import unidecode

filename = "blowfish.txt"
key = "This is a key123"


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
    global filename, key
    lines16bytes = content
    open(filename, "w").write("")
    file = open(filename, "a")
    for line in lines16bytes:
        for field in line:
            print(field)
            obj = Blowfish.new(key)
            temp = obj.encrypt(field)
            file.write(str(temp))
    file.close()


def encrypt():
    write(read())


encrypt()
