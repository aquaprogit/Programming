from enum import Enum


class OpenMode(Enum):
    read = 'r'
    write = 'w'
    append = 'a'
    binary = 'b'


def write_to_file(file_name: str, open_mode: OpenMode, content: list[str]):
    if open_mode.value != 'w' and open_mode.value != 'a' and open_mode.value != 'b':
        return False
    with open(file_name, open_mode.value) as file:
        for line in content:
            file.write(line + '\n')
    return True

def read_file(file_name: str) -> list[str]:
    with open(file_name, 'r') as file:
        return file.read().split('\n')
