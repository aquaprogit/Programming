from random import *


class TArray:
    def __init__(self, length: int, rand=False):
        self.size = length
        self.items = [0 for i in range(self.size)]
        if rand:
            self.fill_randomly()

    def __str__(self):
        pass

    def insert_at_index(self, value, index: int):
        if 0 > index >= self.size:
            raise IndexError('Index was out of range')
        self.items[index] = value

    def get_at_index(self, index: int):
        if 0 > index >= self.size:
            raise IndexError('Index was out of range')
        return self.items[index]

    def increase_all(self, value):
        for i in range(self.size):
            self.items[i] += value

    def get_average(self):
        pass

    def decrease_all(self, value):
        for i in range(self.size):
            self.items[i] -= value

    def fill_randomly(self):
        pass
