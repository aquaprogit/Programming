using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            List<Plane> planes = new List<Plane>();

            planes = new List<Plane>() {
                new Plane(random.Next(-10,10),random.Next(-10,10),random.Next(-10,10), random.Next(-10,10)),
                new Plane(random.Next(-10,10),random.Next(-10,10),random.Next(-10,10), random.Next(-10,10)),
                new Plane(random.Next(-10,10),random.Next(-10,10),random.Next(-10,10), random.Next(-10,10)),
                new Plane(random.Next(-10,10),random.Next(-10,10),random.Next(-10,10), random.Next(-10,10)),
                new Plane(random.Next(-10,10),random.Next(-10,10),random.Next(-10,10), random.Next(-10,10)),
                new Plane(random.Next(-10,10),random.Next(-10,10),random.Next(-10,10), random.Next(-10,10))
            };

            //do
            //{
            //    planes.Add(ConsoleWorker.GetPlaneFromUser());
            //    Console.WriteLine("================");
            //} while (ConsoleWorker.GetAnswer("Continue? [y/n]: "));
            ConsoleWorker.PrintPlanes("All planes: ", planes.ToArray());
            Point point = ConsoleWorker.GetPointFromUser();
            ConsoleWorker.PrintPlanes("Planes, what owns this point: ",
                planes.Where(p => p.IsOwnsPoint(point)).ToArray());

            Console.ReadLine();
        }
    }
}
