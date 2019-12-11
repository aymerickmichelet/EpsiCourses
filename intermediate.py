import socket, threading, os, sys, time
UDP_IP = "127.0.0.1"
UDP_PORT_TRANSMITTER = 5010
UDP_PORT_RECEIVER = 5010
NB_MESSAGE = 1

class intermediate(threading.Thread):
    def __init__(self, name="Thread"):
        threading.Thread.__init__(self)
        self.name = name
        self.step = "listen"
    
    def run(self):
        print ("[" + str(self.name) + "] > Process starting.")
        sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
        sock.bind((UDP_IP, UDP_PORT_TRANSMITTER))
        i = 0
        while i < NB_MESSAGE:
            self.join()
            if(self.step == "listen"):
                data, addr = sock.recvfrom(1024)
                print("[" + str(self.name) + "] > " + str(data))
                i+=1
                self.step = "sender"
                self.send(data)
        print ("[" + str(self.name) + "] > Process finished.")

    def send(self, data):
        if(self.step == "sender"):
            sock_receiver = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
            sock_receiver.sendto(data, (UDP_IP, UDP_PORT_RECEIVER))
            print("[" + str(self.name) + "] > send message - " + str(data))
            self.step = "listen"