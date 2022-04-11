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
            #region user input
            //string writeMode = ConsoleWorker.Input("Choose write mode: print \'w\' to open in rewrite mode\n" +
            //    "print \'a\' to open in append mode", str => str.ToLower() == "w" || str.ToLower() == "a").ToLower();
            //if (writeMode == "a")
            //{
            //    Furniture[] data = FileWorker.ReadFromFile(firstPath);
            //    if (data.Length > 0)
            //    {
            //        Console.WriteLine("Content from first file: ".PadLeft(32));
            //        foreach (Furniture item in data)
            //        {   
            //            Console.WriteLine(item + "\n===========================");
            //        }
            //    }
            //}
            //List<Furniture> fromInput = new List<Furniture>();
            //do
            //{
            //    fromInput.Add(ConsoleWorker.GetFurnitureFromInput());
            //} while (ConsoleWorker.Input("Continue? [y/n]", str => str.ToLower() == "y" || str.ToLower() == "n") != "n");

            //if (writeMode == "a")
            //    FileWorker.AppendObjectsToFile(firstPath, fromInput.ToArray());
            //else if (writeMode == "w")
            //    FileWorker.WriteObjectsToFile(firstPath, fromInput.ToArray());
            #endregion

            #region already filled
            Furniture[] furniture = new Furniture[] {
                    new Furniture("chair", "bar", 10, 650, Color.Brown),
                    new Furniture("table", "school", 44, 556, Color.Orange),
                    new Furniture("chair", "school", 0, 310, Color.Orange),
                    new Furniture("chair", "school", 243, 330, Color.White),
                    new Furniture("mirror", "bathroom", 1, 440, Color.White),
                    new Furniture("chair", "school", 19, 2200, Color.Yellow)
            };
            FileWorker.WriteObjectsToFile(firstPath, furniture);
            #endregion

            var allFurniture = FileWorker.ReadFromFile(firstPath);
            ConsoleWorker.OutputItems("All furniture list: ".PadLeft(32), allFurniture);

            var availableChairs = ContentWorker.GetAvailableTypes(allFurniture, "chair", ConsoleWorker.Input("Kind to select: "));
            FileWorker.WriteObjectsToFile(outputPath, availableChairs);

            var chairs = FileWorker.ReadFromFile(outputPath);
            ConsoleWorker.OutputItems("Available chairs of kind:".PadLeft(32), chairs);

            var chairsInRange = ContentWorker.GetItemsOutOfRange(chairs, 300, 500);
            FileWorker.WriteObjectsToFile(outputPath, chairsInRange);

            var result = FileWorker.ReadFromFile(outputPath);
            ConsoleWorker.OutputItems("Chairs with price not in [300-500]:".PadLeft(32), result);
            Console.ReadLine();
        }
    }
}
