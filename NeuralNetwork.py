import numpy as np


def sigmoid(s):
    return 1 / (1 + np.exp(-s))


def sigmoidPrime(s):
    return s * (1 - s)


class Neural_Network:

    def parseData(self, text):

        # data: (color/length/witdh)
        data = ([1, 3, 1.5], [0, 2, 1], [1, 4, 1.5], [0, 3, 1], [1, 3.5, 0.5], [0, 2, 0.5], [1, 5.5, 1], [0, 1, 1])

        if text == "output":
            text = 0
        elif text == "input":
            text = 1

        dataParse = []
        for d in data:
            if text == 0:
                dataParse.append(d[0])
            elif text == 1:
                dataParse.append([d[1], d[2]])

        return dataParse

    def __init__(self):
        self.train = 100

        self.dataInput = np.array(self.parseData("input"), dtype=float)
        self.dataInput /= np.amax(self.dataInput, axis=0)
        self.dataOutput = np.array(self.parseData("output"), dtype=float)

        print(str(self.dataInput))
        print(str(self.dataOutput))

        self.inputSize = 2
        self.hiddenSize = 3
        self.outputSize = 1

        self.weight1 = np.random.randn(self.inputSize, self.hiddenSize)  # matrice 2x3
        self.weight2 = np.random.randn(self.hiddenSize, self.outputSize)  # matrice 3x1

        for i in range(self.train):
            self.backward(self.dataInput, self.dataOutput, self.forward(self.dataInput))

    def forward(self, X):
        self.z2 = sigmoid(np.dot(X, self.weight1))
        return sigmoid(np.dot(self.z2, self.weight2))

    def backward(self, X, y, o):
        self.o_delta = (y - o) * sigmoidPrime(o)

        wesh = self.weight2.T

        print(str(wesh))

        hola = self.o_delta.dot(wesh)

        self.z2_delta = hola * sigmoidPrime(self.z2)

        self.weight1 += X.T.dot(self.z2_delta)
        self.weight2 += self.z2.T.dot(self.o_delta)


NN = Neural_Network()

# print("Valeurs d'entrées: \n" + str(X))
print("Sortie actuelle: \n" + str(NN.dataOutput))
print("Valeurs prédite: \n" + str(np.matrix.round(NN.forward(NN.dataInput), 2)))
print("\n")