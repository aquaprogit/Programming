using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Plane> planes = new List<Plane>();
            /* 
             (4,5,7.5)
             */
            //planes = new List<Plane>() {
            //    new Plane(-3,  8,  4,  2),
            //    new Plane(-3,  6, -3, -4),
            //    new Plane(-3, -4,  8, -8),
            //    new Plane(-7, -5,  0, -9),
            //    new Plane( 0,  2,  8,  1),
            //    new Plane( 1, -3, -9, -7)
            //};

            do
            {
                planes.Add(ConsoleWorker.GetPlaneFromUser());
                Console.WriteLine("================");
            } while (ConsoleWorker.GetAnswer("Continue? [y/n]: "));
            ConsoleWorker.PrintPlanes("All planes: ", planes.ToArray());
            Point point = ConsoleWorker.GetPointFromUser();
            ConsoleWorker.PrintPlanes("Planes, what owns this point: ",
                planes.Where(p => p.IsOwnsPoint(point)).ToArray());

            Console.ReadLine();
        }
    }
}
