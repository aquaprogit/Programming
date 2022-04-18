using System;
using System.Linq;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            string input = "dhefmncejk";
            foreach (int i in input.ToArray().Select(c => Convert.ToInt32(c)))
            {
                tree.Insert(i);
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(tree.DisplayTree());
            Console.ReadLine();
        }
    }
}
