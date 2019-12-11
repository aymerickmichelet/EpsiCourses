import socket, threading, os, sys, time
UDP_IP = "127.0.0.1"
UDP_PORT = 5010
NB_MESSAGE = 1

class receiver(threading.Thread):
    def __init__(self, name="Thread"):
        threading.Thread.__init__(self)
        self.name = name

    def run(self):
        print ("[" + str(self.name) + "] > Process starting. (IP: "+str(UDP_IP)+", PORT: "+str(UDP_PORT)+")")
        sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
        sock.bind((UDP_IP, UDP_PORT))
        i = 0
        while i < NB_MESSAGE:
            data, addr = sock.recvfrom(1024)
            print("[" + str(self.name) + "] > " + str(data))
            i+=1
        print ("[" + str(self.name) + "] > Process finished.")