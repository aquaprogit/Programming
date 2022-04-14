using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                intArrays[i] = new IntArray(4);
                Worker.FillIntRandomly(intArrays[i]);
                Worker.DisplayArray($"Int array #{i + 1}: ", intArrays[i]);
            }
            Console.WriteLine("====================");
            for (int i = 0; i < m; i++)
            {
                doubleArrays[i] = new DoubleArray(4);
                Worker.FillDoubleRandomly(doubleArrays[i]);
                Worker.DisplayArray($"Double array #{i + 1}: ", doubleArrays[i]);
            }
            Console.ReadLine();

        }
    }
    class Worker
    {
        private static Random _random = new Random();
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
        public static void FillIntRandomly(IntArray array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                array[i] = _random.Next(-50, 51);
            }
        }
        public static void FillDoubleRandomly(DoubleArray array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                array[i] = _random.GetDouble(-25, 26);
            }
        }
    }
}
