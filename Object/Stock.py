import Storage
from Product import Product


class Stock(Storage):
    def __init__(self):
        super(Stock, self).__init__(Product.OIL, 10000000000000000000000000000)
