from os import system

import console_worker as console
import content_worker as content
import file_worker as file
from furniture import Furniture


def main():
    furniture = [
        Furniture('chair', 'bar', 10, 650, 'Brown'),
        Furniture('table', 'school', 44, 556, 'Orange'),
        Furniture('chair', 'school', 0, 310, 'Orange'),
        Furniture('chair', 'school', 243, 330, 'White'),
        Furniture('mirror', 'bathroom', 1, 440, 'White'),
        Furniture('chair', 'school', 19, 2200, 'Grey')
    ]
    # furniture = console.get_items_from_user()
    console.print_items('All furniture list: ', furniture)
    # if input('Print \'a\' to append data or \'w\' to rewrite data: ') == 'w':
    #     file.write_to_file('first.dat', furniture)
    # else:
    #     file.append_to_file('first.dat', furniture)
    file.write_to_file('first.dat', furniture)

    from_file = file.read_from_file('first.dat')
    available_chairs = content.select_available_types(from_file, 'chair', input('Print kind of item to select: '))
    console.print_items('Available chairs with selected kind: ', available_chairs)
    file.write_to_file('output.dat', available_chairs)

    from_file = file.read_from_file('output.dat')
    removed = content.without_range(from_file, 300, 500)
    console.print_items('Removed items with price in [300; 500]: ', removed)
    file.write_to_file('output.dat', removed)


if __name__ == '__main__':
    main()
    system('pause')
