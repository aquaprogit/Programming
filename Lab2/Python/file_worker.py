import pickle

from furniture import Furniture


def write_to_file(path: str, furniture_list: list[Furniture]):
    with open(path, 'wb') as file:
        for item in furniture_list:
            pickle.dump(item, file)


def append_to_file(path: str, furniture_list: list[Furniture]):
    with open(path, 'ab') as file:
        for item in furniture_list:
            pickle.dump(item, file)


def read_from_file(path: str) -> list[Furniture]:
    items = []
    end_file = False
    with open(path, 'rb') as file:
        while not end_file:
            try:
                items.append(pickle.load(file))
            except EOFError:
                end_file = True
    return items
