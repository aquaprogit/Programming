from t_array import TArray
from random import *


class FloatArray(TArray):
    def get_average(self):
        sum_of_all = 0
        for i in self.items:
            sum_of_all += i
        return round(sum_of_all / self.size, 2)

    def __str__(self):
        return ' '.join(['{:.2f}'.format(x).rjust(6, ' ') for x in self.items])

    def fill_randomly(self):
        for i in range(self.size):
            self.items[i] = round(random() + randint(-25, 25), 2)
