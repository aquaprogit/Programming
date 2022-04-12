using System;

namespace Lab3
{
    internal static class ConsoleWorker
    {
        public static Point GetPointFromUser()
        {
            return new Point(
                    Convert.ToDouble(Input("Enter x like 0,00: ", str => double.TryParse(str, out _))),
                    Convert.ToDouble(Input("Enter y like 0,00: ", str => double.TryParse(str, out _))),
                    Convert.ToDouble(Input("Enter z like 0,00: ", str => double.TryParse(str, out _)))
                    );
        }
        public static Plane GetPlaneFromUser()
        {
            return new Plane(
                    Convert.ToDouble(Input("Enter A like 0,00: ", str => double.TryParse(str, out _))),
                    Convert.ToDouble(Input("Enter B like 0,00: ", str => double.TryParse(str, out _))),
                    Convert.ToDouble(Input("Enter C like 0,00: ", str => double.TryParse(str, out _))),
                    Convert.ToDouble(Input("Enter D like 0,00: ", str => double.TryParse(str, out _)))
                );
        }
        public static bool GetAnswer(string header)
        {
            return Input(header, str => str == "y" || str == "n") == "y";
        }
        public static void PrintPlanes(string header, Plane[] elems)
        {
            Console.WriteLine(header + "\n===============");
            foreach (Plane item in elems)
            {
                Console.WriteLine(item.ToString() + "\n===============");
            }
        }
        public static string Input(string header, Func<string, bool> func)
        {
            Console.Write(header);
            string input = Console.ReadLine();
            while (func(input) == false)
            {
                Console.Write("Incorect input. Try again: ");
                input = Console.ReadLine();
            }
            return input;
        }
        public static string Input(string header)
        {
            Console.Write(header);
            return Console.ReadLine();
        }
    }
}
