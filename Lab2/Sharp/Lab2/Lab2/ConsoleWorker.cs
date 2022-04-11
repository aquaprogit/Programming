using System;
using System.Linq;

namespace Lab2
{
    internal static class ConsoleWorker
    {
        public static Furniture GetFurnitureFromInput()
        {
            Console.WriteLine("===================");
            return new Furniture(
                    Input("Enter furniture type".PadRight(32)),
                    Input("Enter purpose of item".PadRight(32)),
                    Convert.ToInt32(Input("Enter amount of item in storage".PadRight(32), str => uint.TryParse(str, out uint _))),
                    Convert.ToInt32(Input("Enter price per one item".PadRight(32), str => uint.TryParse(str, out uint _))),
                    (Color)Enum.Parse(typeof(Color), Input("Enter color of item".PadRight(32), str => Enum.GetNames(typeof(Color)).Contains(str)))
                    );
        }
        public static void OutputItems(string header, Furniture[] items)
        {
            Console.WriteLine(header);
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("==================");
            }
        }
        public static string Input(string content, Func<string, bool> func)
        {
            Console.Write(content + ": ");
            string input = Console.ReadLine();
            while (func(input) == false)
            {
                Console.Write("Invalid input. Try again: ");
                input = Console.ReadLine();
            }
            return input;
        }
        public static string Input(string content)
        {
            Console.Write(content + ": ");
            return Console.ReadLine();
        }
    }
}
