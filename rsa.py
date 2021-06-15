import ast
from Crypto.PublicKey import RSA
from Crypto.Cipher import PKCS1_OAEP
from Crypto import Random
import base64


def create_save_key():
    random_generator = Random.new().read
    key = RSA.generate(4096, random_generator)

    k = key.exportKey("PEM")
    print(k)

    p = key.publickey().exportKey("PEM")
    print(p)

    with open("private.pem", "w") as kf:
        kf.write(k.decode())
        kf.close()

    with open("public.pem", "w") as pf:
        pf.write(p.decode())
        pf.close()

    return key



def rsa_encrypt():

    key = create_save_key()
    publickey = key.publickey()
    encryptor = PKCS1_OAEP.new(publickey)

    file = open("Liste_des_gagnants_du_Loto.txt", "r")
    new_file_content = ""

    for line in file:
        encrypted = encryptor.encrypt(bytes(line, 'utf-8'))
        new_file_content += str(encrypted)

    file.close()

    writing_file = open("Liste_des_gagnants_du_Loto_rsa_encrypt.txt", "w+")
    writing_file.write(new_file_content)
    writing_file.close()


def rsa_decrypt():
    key = RSA.importKey(open('private.pem', 'r').read())
    decryptor = PKCS1_OAEP.new(key)

    file = open("Liste_des_gagnants_du_Loto_rsa_encrypt.txt", "r")
    new_file_content = ""
    array_line = []

    for line in file:
        array_line = line.split("b'")

    firstElement = True
    for line in array_line:

        if(firstElement):
            firstElement = False
        else:
            line = "b'" + line
            decrypt_line = decryptor.decrypt(ast.literal_eval(str(line)))
            decrypt_line.decode('utf-8')
            new_file_content += decrypt_line.decode('utf-8')

    file.close()
    writing_file = open("Liste_des_gagnants_du_Loto_rsa_decrypt.txt", "w+")
    writing_file.write(new_file_content)
    writing_file.close()





