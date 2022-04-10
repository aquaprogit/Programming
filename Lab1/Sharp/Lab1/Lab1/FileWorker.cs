using System.IO;

namespace Lab1
{
    internal class FileWorker
    {
        /// <summary>
        /// Creates file in executable file directory
        /// </summary>
        /// <param name="fileName">File name without extension</param>
        public void CreateFile(string fileName)
        {
            if (File.Exists($"{fileName}.txt") == false)
                File.Create($"{fileName}.txt").Close();
        }
        /// <summary>
        /// Rewrites file with the given content
        /// </summary>
        /// <param name="fileName">File name without extension</param>
        /// <param name="data">Content</param>
        public void WriteData(string fileName, string[] data)
        {
            if (File.Exists($"{fileName}.txt") == false)
                CreateFile($"{fileName}.txt");
            File.WriteAllLines($"{fileName}.txt", data);
        }
        /// <summary>
        /// Append file with the given content
        /// </summary>
        /// <param name="fileName">File name without extension</param>
        /// <param name="data">Content</param>
        public void AppendData(string fileName, string[] data)
        {
            if (File.Exists($"{fileName}.txt") == false)
                CreateFile($"{fileName}.txt");
            File.AppendAllLines($"{fileName}.txt", data);
        }
        /// <summary>
        /// Reads all lines of the file
        /// </summary>
        /// <param name="fileName">File name without extension</param>
        /// <returns>Array of lines of the file</returns>
        public string[] ReadData(string fileName)
        {
            return File.Exists($"{fileName}.txt") ? File.ReadAllLines($"{fileName}.txt") : new string[0];
        }
    }
}
