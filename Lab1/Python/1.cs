using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstFileName = "firstData",
                   secondFileName = "secondData",
                   outputFileName = "outputData";
            TextWorker textWorker = new TextWorker();
            ConsoleWorker consoleWorker = new ConsoleWorker();
            FileWorker fileWorker = new FileWorker();

            fileWorker.CreateFile(firstFileName);
            fileWorker.CreateFile(secondFileName);
            fileWorker.CreateFile(outputFileName);

            fileWorker.WriteData(firstFileName, consoleWorker.GetMultilineInput());
            Console.WriteLine("====================");
            fileWorker.WriteData(secondFileName, consoleWorker.GetMultilineInput());
            Console.WriteLine("====================");

            string[] fromFirstFile = fileWorker.ReadData(firstFileName);
            string[] fromSecondFile = fileWorker.ReadData(secondFileName);
            string[] resultContent = textWorker.SecondWithoutFirst(fromFirstFile, fromSecondFile);

            Console.WriteLine("Second array without first one's elements:");
            foreach (string item in resultContent)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count of output elements: " + resultContent.Length);
            fileWorker.WriteData(outputFileName, resultContent);

            Console.ReadLine();
        }
    }
}
