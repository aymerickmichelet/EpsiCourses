# import numpy as np
# from NeuronalNetwork import NeuronalNetwork
#
#
# def getColor(number) -> str:
#     if number > 0.5:
#         return str("Rouge")
#     else:
#         return str("Bleu")
#
#
# NN = NeuronalNetwork()
# for b in range(100):
#     result = NN.forward()
#     print("Train " + str(b))
#     print("Sortie attendu \tSortie obtenu \tCouleur attendu \tCouleur obtenu")
#     for a in range(8):
#         expected = NN.output[a]
#         obtained = result[a]
#         print(str(expected) + "  \t\t\t" + str(obtained) + "  \t" + getColor(expected) + "  \t\t\t\t" + getColor(obtained))
#     print()
#     NN.backward()