using System;
using System.Linq;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<char> tree = new Tree<char>();
            string input = "dhefmncejk";
            foreach (char i in input)
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
