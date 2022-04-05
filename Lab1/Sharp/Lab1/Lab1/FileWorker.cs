using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
