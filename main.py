import socket, threading, os, sys, time
from transmitter import transmitter
from intermediate import intermediate
from receiver import receiver

if __name__ == '__main__':
    list = []
    list.append(transmitter(name="Envoie 1", wait=2))
    list.append(transmitter(name="Intermediaire 1"))
    list.append(receiver(name="Receveur 1"))
    for thread in list:
        thread.start()
