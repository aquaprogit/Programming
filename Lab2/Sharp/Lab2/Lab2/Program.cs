using System;
using System.Collections.Generic;
    
namespace Lab2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string firstPath = "first.dat",
                   outputPath = "output.dat";
            string writeMode = ConsoleWorker.Input("Choose write mode: print \'w\' to open in rewrite mode\n" +
                "print \'a\' to open in append mode", str => str.ToLower() == "w" || str.ToLower() == "a").ToLower();
            if (writeMode == "a")
            {
                Furniture[] data = FileWorker.ReadFromFile(firstPath);
                if (data.Length > 0)
                {
                    Console.WriteLine("Content from first file: ".PadLeft(32));
                    foreach (Furniture item in data)
                    {   
                        Console.WriteLine(item + "\n===========================");
                    }
                }
            }
            List<Furniture> fromInput = new List<Furniture>();
            do
            {
                fromInput.Add(ConsoleWorker.GetFurnitureFromInput());
            } while (ConsoleWorker.Input("Continue? [y/n]", str => str.ToLower() == "y" || str.ToLower() == "n") != "n");

            if (writeMode == "a")
                FileWorker.AppendObjectsToFile(firstPath, fromInput.ToArray());
            else if (writeMode == "w")
                FileWorker.WriteObjectsToFile(firstPath, fromInput.ToArray());

            var allFurniture = FileWorker.ReadFromFile(firstPath);
            ConsoleWorker.OutputItems("All furniture list: ".PadLeft(32), allFurniture);

            var avaibleChairs = ContentWorker.GetAvaibleTypes(allFurniture, "chair");
            FileWorker.WriteObjectsToFile(outputPath, avaibleChairs);

            var chairs = FileWorker.ReadFromFile(outputPath);
            ConsoleWorker.OutputItems("Avaible chairs:".PadLeft(32), chairs);

            var chairsInRange = ContentWorker.GetItemsInRange(chairs, 300, 500);
            FileWorker.WriteObjectsToFile(outputPath, chairsInRange);

            var result = FileWorker.ReadFromFile(outputPath);
            ConsoleWorker.OutputItems("Chairs with price in [300-500]:".PadLeft(32), result);
            Console.ReadLine();
        }
    }
}
