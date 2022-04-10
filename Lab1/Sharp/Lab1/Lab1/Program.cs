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

            if (consoleWorker.GetWriteMode() == WriteMode.Write)
                fileWorker.WriteData(firstFileName, consoleWorker.GetMultilineInput());
            else
                fileWorker.AppendData(firstFileName, consoleWorker.GetMultilineInput());
            Console.WriteLine("====================");
            if (consoleWorker.GetWriteMode() == WriteMode.Write)
                fileWorker.WriteData(secondFileName, consoleWorker.GetMultilineInput());
            else
                fileWorker.AppendData(secondFileName, consoleWorker.GetMultilineInput());
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
            //TextWorker worker = new TextWorker();
            //FileWorker fileWorker = new FileWorker();
            //foreach (var line in worker.SecondWithoutFirst(fileWorker.ReadData("firstData"), fileWorker.ReadData("secondData")))
            //{
            //    Console.WriteLine(line);
            //}
            Console.ReadLine();
        }
    }
}
