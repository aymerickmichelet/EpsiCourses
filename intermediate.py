import socket, threading, os, sys, time
UDP_IP = "127.0.0.1"
UDP_PORT_TRANSMITTER = 5010
UDP_PORT_RECEIVER = 5010
NB_MESSAGE = 1

class intermediate(threading.Thread):
    def __init__(self, name="Thread"):
        threading.Thread.__init__(self)
        self.name = name
    
    def run(self):
        print ("[" + str(self.name) + "] > Process starting. (IP: "+str(UDP_IP)+", LISTEN PORT: "+str(UDP_PORT_TRANSMITTER)+", SENDER PORT: "+str(UDP_PORT_RECEIVER)+")")
        sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
        sock.bind((UDP_IP, UDP_PORT_TRANSMITTER))
        i = 0
        while i < NB_MESSAGE:
            data, addr = sock.recvfrom(1024)
            print("[" + str(self.name) + "] > " + str(data))
            i+=1
            self.send(data)
            # time.sleep(500)
        print ("[" + str(self.name) + "] > Process finished.")

    def send(self, data):
        sock_receiver = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
        sock_receiver.sendto(data, (UDP_IP, UDP_PORT_RECEIVER))
        print("[" + str(self.name) + "] > send message - " + str(data))