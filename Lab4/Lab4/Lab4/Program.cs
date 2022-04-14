using System;
using System.Linq;

namespace Lab4
{
    internal class Program
    {
        /*
         https://www.desmos.com/calculator/ex5j3xz9rh
        */
        static void Main(string[] args)
        {
            Line V1, V2, V3;
            V1 = new Line((3, -5));
            V2 = new Line(new Point((-4, 0)), new Point((8, -1)));
            Console.WriteLine("Line1: \n" + V1.ToString());
            Console.WriteLine("=================\n");
            Console.WriteLine("Line2: \n" + V2.ToString());
            Console.WriteLine("=================\n");
            V3 = V1 + V2;
            Console.WriteLine("Line3: \n" + V3.ToString());
            Console.WriteLine("=================\n");
            V3++;
            Console.WriteLine("Line3 expanded: \n" + V3.ToString());
            Console.WriteLine("=================\n");
            Console.WriteLine("Enter point coords to check [11,11;22,22]");
            string input = Console.ReadLine();
            bool isValid = input.Split(';').All(p => double.TryParse(p, out _));
            while (isValid == false)
            {
                Console.Write("Invalid input. Try again: ");
                input = Console.ReadLine();
                isValid = input.Split(';').All(p => double.TryParse(p, out _));
            }
            string[] splitted = input.Split(';');
            Point toCheck = new Point(double.Parse(splitted[0]), double.Parse(splitted[1]));
            
            Console.Write(V3.IsOnLine(toCheck) ? "Point is on line" : "Point isn't on line");
            Console.ReadLine();
        }
    }
}
