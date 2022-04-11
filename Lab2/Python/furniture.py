class Furniture:
    def __init__(self, name: str, kind: str, amount: int, price: int, color: str) -> object:
        self.name = name
        self.kind = kind
        self.amount = amount
        self.price = price
        self.color = color

    def print(self) -> object:
        print(f'Title            : {self.name} {self.kind}\n'
              f'Amount in storage: {self.amount}\n'
              f'Price per one    : {self.price}\n'
              f'Color            : {self.color}')