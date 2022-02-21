from Object.TaskManager import TaskManager
from Object.Task import Task
from Object.Pump import Pump
from Object.Machine import Machine
from Object.Product import Product

tasks = [
    Task("Pump 1", Pump(10, 2), 5, 1),
    Task("Pump 2", Pump(20, 3), 15, 2),
    Task("Machine 1", Machine({Product.OIL, 25}, Product.MOTOR, 5), 5, 4),
    Task("Machine 2", Machine({Product.OIL, 5}, Product.WHEEL, 3), 5, 3)
]

tm = TaskManager()


# implementation of storage
# increment iol in tank and handle limit iol
# increment wheel and motor in stock