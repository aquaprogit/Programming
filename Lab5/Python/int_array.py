from random import *

from t_array import TArray


class IntArray(TArray):
    def get_average(self):
        sum_of_all = 0
        for i in self.items:
            sum_of_all += i
        return round(sum_of_all / self.size, 3)

    def __str__(self):
        return ' '.join([str(x).rjust(3, ' ') for x in self.items])

    def fill_randomly(self):
        for i in range(self.size):
            self.items[i] = randint(-25, 25)
