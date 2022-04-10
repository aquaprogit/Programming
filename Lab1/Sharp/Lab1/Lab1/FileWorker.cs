using System.IO;

namespace Lab1
{
    internal class FileWorker
    {
        public bool CreateFile(string fileName)
        {
            if (File.Exists($"{fileName}.txt") == false)
            {
                File.Create($"{fileName}.txt").Close();
                return true;
            }
            return false;
        }
        public void WriteData(string fileName, string[] data)
        {
            if (File.Exists($"{fileName}.txt") == false)
                CreateFile($"{fileName}.txt");
            File.WriteAllLines($"{fileName}.txt", data);
        }
        public void AppendData(string fileName, string[] data)
        {
            if (File.Exists($"{fileName}.txt") == false)
                CreateFile($"{fileName}.txt");
            File.AppendAllLines($"{fileName}.txt", data);
        }
        public string[] ReadData(string fileName)
        {
            return File.Exists($"{fileName}.txt") ? File.ReadAllLines($"{fileName}.txt") : new string[0];
        }
    }
}
