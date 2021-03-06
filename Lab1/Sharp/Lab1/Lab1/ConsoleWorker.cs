using System;
using System.Linq;

namespace Lab1
{
    internal class ConsoleWorker
    {
        public string[] GetMultilineInput(ConsoleKey exitKey = ConsoleKey.E)
        {
            PrintInputHint(exitKey);
            bool keepEntering;
            string result = "";
            do
            {
                var key = Console.ReadKey(true);
                keepEntering = key.Key != exitKey || key.Modifiers != ConsoleModifiers.Alt;
                if (keepEntering)
                {
                    switch (key.Key)
                    {
                        case ConsoleKey.Enter:
                            result += "\n";
                            Console.CursorLeft = 0;
                            Console.CursorTop++;
                            break;
                        case ConsoleKey.Backspace:
                            if (Console.CursorLeft == 0)
                                break;
                            Console.CursorLeft--;
                            Console.Write(" ");
                            Console.CursorLeft--;
                            result = result.Remove(result.Length - 1, 1);
                            break;
                        default:
                            Console.Write(key.KeyChar);
                            result += key.KeyChar.ToString();
                            break;
                    }
                }
            } while (keepEntering);
            Console.Write("\n");
            return result.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
        public WriteMode GetWriteMode()
        {
            string input;
            string[] possibleInputs = new string[] { "a", "w" };
            do
            {
                Console.WriteLine("Choose write mode: print \'w\' to open in write mode,\n" +
                    "print \'a\' to open in append mode");
                input = Console.ReadLine();
            } while (possibleInputs.Contains(input.ToLower()) == false);
            switch (input.ToLower())
            {
                case "a":
                    return WriteMode.Append;
                case "w":
                    return WriteMode.Write;
                default:
                    return WriteMode.Write;
            }
        }

        public void PrintFileContent(string header, string[] content)
        {
            Console.WriteLine(header + "\n====================");
            foreach (var item in content)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("====================");
        }
        private void PrintInputHint(ConsoleKey key)
        {
            Console.WriteLine($"Enter text, which would be written to next file\n" +
                $"[To exit entering mode press ALT+{key}]");
        }
    }
    enum WriteMode
    {
        Write,
        Append
    }
}
