import socket, threading, os, sys, time
UDP_IP = "127.0.0.1"
UDP_PORT = 5010
MESSAGE = b"Hello, World!"
NB_MESSAGE = 1

class transmitter(threading.Thread):
    def __init__(self, name="Thread", wait=0):
        threading.Thread.__init__(self)
        self.name = name
        self.wait = wait

    def run(self):
        print ("[" + str(self.name) + "] > Process starting. (IP: "+str(UDP_IP)+", PORT: "+str(UDP_PORT)+")")
        for i in range(NB_MESSAGE):
            sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
            sock.sendto(MESSAGE, (UDP_IP, UDP_PORT))
            print("[" + str(self.name) + "] > send message - " + str(MESSAGE))
        print ("[" + str(self.name) + "] > Process finished.")