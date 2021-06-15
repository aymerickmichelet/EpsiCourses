from Crypto.PublicKey import RSA

def create_save_key():
    key = RSA.generate(1024)

    k = key.exportKey("PEM")
    print(k)

    p = key.publickey().exportKey("PEM")

    with open("rsa/private.pem", "w") as kf:
        kf.write(k.decode())
        kf.close()

    with open("rsa/public.pem", "w") as pf:
        pf.write(p.decode())
        pf.close()
