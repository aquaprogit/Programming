from os import system
import file_worker as file
import console_worker as console
import text_worker as text


def main():
    file.write_to_file('first.txt', console.get_write_mode(), console.get_multiline_input())
    file.write_to_file('second.txt', console.get_write_mode(), console.get_multiline_input())

    from_first = file.read_file('first.txt')
    from_second = file.read_file('second.txt')
    output_content = text.second_without_first(from_first, from_second)

    print('=====================')
    print('Second file, where excluded lines from first file')
    for line in output_content:
        print(line)
    print(f'Count of lines is: {text.get_content_length(output_content)}')
    file.write_to_file('output.txt', file.OpenMode.write, output_content)

if __name__ == '__main__':
    main()
    system('pause')
