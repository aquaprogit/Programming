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

            bool result1 = fileWorker.CreateFile(firstFileName);
            bool result2 = fileWorker.CreateFile(secondFileName);
            fileWorker.CreateFile(outputFileName);

            if (consoleWorker.GetWriteMode() == WriteMode.Write)
                fileWorker.WriteData(firstFileName, consoleWorker.GetMultilineInput());
            else
            {
                if (result1 == false)
                    consoleWorker.PrintFileContent("\nFirstData.txt content: ", fileWorker.ReadData(firstFileName));
                fileWorker.AppendData(firstFileName, consoleWorker.GetMultilineInput());
            }
            Console.WriteLine("====================");
            if (consoleWorker.GetWriteMode() == WriteMode.Write)
                fileWorker.WriteData(secondFileName, consoleWorker.GetMultilineInput());
            else
            {
                if (result2 == false)
                    consoleWorker.PrintFileContent("\nSecondData.txt content: ", fileWorker.ReadData(secondFileName));
                fileWorker.AppendData(secondFileName, consoleWorker.GetMultilineInput());
            }
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
