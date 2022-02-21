import Product


class Storage:
    def __init__(self, product: Product, amount: int):
        self.product = product
        self.amount = amount
