import Exploid
from Product import Product


class Pump(Exploid):
    def __init__(self, amount_production: int, execution_time: int):
        needs = {}
        productions = {
            Product.OIL,
            amount_production
        }
        super(Pump, self).__init__(needs, productions, execution_time)
