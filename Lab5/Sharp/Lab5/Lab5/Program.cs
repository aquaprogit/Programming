using System;
using System.Linq;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Worker.Input("Enter m: ", str => int.TryParse(str, out _)));
            IntArray[] intArrays = new IntArray[m];
            DoubleArray[] doubleArrays = new DoubleArray[m];
            for (int i = 0; i < m; i++)
            {
                intArrays[i] = new IntArray(5);
                intArrays[i].FillRandomly();
                doubleArrays[i] = new DoubleArray(5);
                doubleArrays[i].FillRandomly();
            }
            Worker.PrintArrays("Int arrays", intArrays);
            Console.WriteLine("====================");
            Worker.PrintArrays("Double arrays", doubleArrays);
            Console.WriteLine("====================");
            int value = int.Parse(Worker.Input("Enter number to work with: ", str => int.TryParse(str, out _)));

            for (int i = 0; i < m; i++)
            {
                intArrays[i].IncreaseAll(value);
                doubleArrays[i].DecreaseAll(value);
            }
            Worker.PrintArrays("Int arrays", intArrays);
            Console.WriteLine("====================");
            Worker.PrintArrays("Double arrays", doubleArrays);
            Console.WriteLine("====================");
            IntArray intAv = (IntArray)Worker.WithMaxAverage(intArrays);
            DoubleArray doubleAv = (DoubleArray)Worker.WithMaxAverage(doubleArrays);
            if (intAv.GetAverage() > doubleAv.GetAverage())
                Worker.DisplayArray($"Max value is {intAv.GetAverage()} in ", intAv);
            else
                Worker.DisplayArray($"Max value is {doubleAv.GetAverage()} in ", doubleAv);
            Console.ReadLine();

        }
    }
    class Worker
    {
        public static string Input(string header, Func<string, bool> func)
        {
            Console.Write(header);
            string input = Console.ReadLine();
            while (func(input) == false)
            {
                Console.Write("Incorrect input. Try again: ");
                input = Console.ReadLine();
            }
            return input;
        }
        public static double Max(double a, double b)
        {
            return a > b ? a : b;
        }
        public static void DisplayArray<T>(string header, TArray<T> array) where T : struct
        {
            Console.WriteLine(header);
            Console.Write("\t");
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write($"{array[i]} ".PadLeft(7));
            }
            Console.WriteLine();
        }
        public static TArray<T> WithMaxAverage<T>(TArray<T>[] arrays) where T : struct
        {
            return arrays.OrderByDescending(a => a.GetAverage()).First();
        }
        public static void PrintArrays<T>(string header, TArray<T>[] arrays) where T : struct
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                DisplayArray($"{header} #{i + 1}: ", arrays[i]);
            }
        }
    }
}
