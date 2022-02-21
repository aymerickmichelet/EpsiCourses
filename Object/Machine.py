import Exploid
from Product import Product


class Machine(Exploid):
    def __init__(self, needs: dict, production: Product, execution_time: int):
        needs = needs
        productions = {
            production,
            1
        }
        super(Machine, self).__init__(needs, productions, execution_time)
