from file_worker import *

def get_multiline_input() -> list[str]:
    print('Enter text to input.'
          '\nPress CTRL+C to exit entering'
          '\nPress ENTER to move on new line\n')
    result = []
    while True:
        try:
            result.append(input())
        except KeyboardInterrupt:
            print('\n')
            return result
def print_existing_content(header: str, content: list[str]):
    if len(content) == 0:
        return
    print(header)
    print('===============')
    for line in content:
        print(line)
    print('===============')

def get_write_mode() -> OpenMode:
    return OpenMode.append if input(
        'If u want to append data, print \'a\', otherwise print \'w\': ') == 'a' else OpenMode.write
