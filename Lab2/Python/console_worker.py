from furniture import Furniture


def get_items_from_user() -> list[Furniture]:
    cont = False
    items = [Furniture]
    while not cont:
        item = Furniture(
            input('Enter category: '),
            input('Enter purpose : '),
            int(input('Enter amount  : ')),
            int(input('Enter price   : ')),
            input('Enter color   : ')
        )
        items.append(item)
        cont = input("Continue? [y/n]") == 'y'
    return items

def print_items(header: str, items: list[Furniture]):
    print(header)
    for i in items:
        i.print()
        print('==================')
