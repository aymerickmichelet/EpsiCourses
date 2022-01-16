# import numpy as np
#
# input_values = ([3, 1.5], [2, 1], [4, 1.5], [3, 1], [3.5, 0.5], [2, 0.5], [5.5, 1], [1, 1])  # longueur/largeur
# output_values = ([1], [0], [1], [0], [1], [0], [1], [0])  # couleur attendu
#
#
# def sigmoid(x) -> float:
#     return 1 / (1 + np.exp(-x))
#
#
# def sigmoidPrime(x) -> float:
#     return x * (1-x)
#
#
# class NeuronalNetwork:
#     def __init__(self):
#         self.inputSize = 2  # nombre de neurone d'entrée
#         self.hiddenSize = 3  # nombre de neurone cachée
#         self.outputSize = 1  # nombre de neurone de sortie
#
#         # neurone d'entrée
#         self.input = np.array(input_values, dtype=float)
#         self.input /= np.amax(self.input, axis=0)
#
#         # neurone caché
#         self.hidden = []
#
#         # neurone de sortie
#         self.output = np.array(output_values, dtype=float)
#
#         # poids random
#         self.weight1 = np.random.randn(self.inputSize, self.hiddenSize)  # matrice 2x3
#         self.weight2 = np.random.randn(self.hiddenSize, self.outputSize)  # matrice 3x1
#
#     # Preduction
#     def forward(self):
#         return sigmoid(np.dot(sigmoid(np.dot(self.input, self.weight1)), self.weight2))
#
#     def backward(self):
#         output_temp = self.forward()
#         deltaErrorOutput = (self.input - output_temp) - sigmoidPrime(output_temp)
#         deltaErrorHidden = (deltaErrorOutput.dot(self.weight2.T)) * self.sigmoidPrime(output_temp)
#
#         self.weight1 += input_values.T.dot(deltaErrorHidden)
#         self.weight2 += output_temp.T.dot(deltaErrorOutput)
