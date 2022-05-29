from int_array import *
from float_array import *


def print_arrays(header: str, arrays: list[TArray]):
    print(header)
    for array in arrays:
        print(array)
    print("      ")


def main():
    int_arrays = []
    float_arrays = []

    m = int(input("Enter m: "))
    for i in range(m):
        int_arrays.append(IntArray(5, True))
        float_arrays.append(FloatArray(5, True))
    print_arrays('Int arrays: ', int_arrays)
    print_arrays('Float arrays: ', float_arrays)

    value = int(input("Enter number to work with: "))
    for i in range(m):
        int_arrays[i].increase_all(value)
        float_arrays[i].decrease_all(value)
    print_arrays('Int arrays after adjustment: ', int_arrays)
    print_arrays('Float arrays after adjustment: ', float_arrays)

    all_arrays = [*int_arrays, *float_arrays]
    max_av = all_arrays[0].get_average()
    arr_av = all_arrays[0]
    for array in all_arrays:
        if array.get_average() >= max_av:
            max_av = array.get_average()
            arr_av = array
    print(f'{arr_av} with max average: {max_av}')


if __name__ == '__main__':
    main()
