import Storage
from Product import Product


class Tank(Storage):
    def __init__(self):
        super(Tank, self).__init__(Product.OIL, 50)
