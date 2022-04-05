using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ConsoleWorker
    {
        /// <summary>
        /// Provides user multiline input while exit key + ALT are not pressed 
        /// </summary>
        /// <param name="exitKey">Key to exit</param>
        /// <returns>Array of inputted lines</returns>
        public string[] GetMultilineInput(ConsoleKey exitKey = ConsoleKey.E)
        {
            ConsoleKeyInfo key;
            string result = "";
            bool keepEntering;
            do
            {
                key = Console.ReadKey();
                keepEntering = key.Key != exitKey || key.Modifiers != ConsoleModifiers.Alt;
                if (keepEntering)
                {
                    switch (key.Key)
                    {
                        case ConsoleKey.Enter:
                            result += "\n";
                            Console.CursorTop++;
                            break;
                        case ConsoleKey.Backspace:
                            Console.Write(' ');
                            Console.CursorLeft--;
                            break;
                        default:
                            result += key.KeyChar.ToString();
                            break;
                    }
                }
                else
                {
                    Console.CursorLeft--;
                    Console.Write(' ');
                    Console.WriteLine();
                }
            } while (keepEntering);
            return result.Split('\n');
        }
    }
}
