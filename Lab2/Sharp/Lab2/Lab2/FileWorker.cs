using System;
using System.Collections.Generic;
using System.IO;

namespace Lab2
{
    internal static class FileWorker
    {
        public static void WriteObjectsToFile(string path, params Furniture[] objs)
        {
            WriteInMode(path, objs, FileMode.Truncate);
        }
        public static void AppendObjectsToFile(string path, params Furniture[] objs)
        {
            WriteInMode(path, objs, FileMode.Append);
        }
        public static Furniture[] ReadFromFile(string path)
        {
            List<Furniture> list = new List<Furniture>();
            if (File.Exists(path) == false)
                return new Furniture[0];
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                while (reader.PeekChar() != -1)
                {
                    list.Add(new Furniture(
                        reader.ReadString(),
                        reader.ReadString(),
                        reader.ReadInt32(),
                        reader.ReadInt32(),
                        ColorFromString(reader.ReadString())
                        ));
                }
            }
            return list.ToArray();
        }
        private static Color ColorFromString(string str)
        {
            return (Color)Enum.Parse(typeof(Color), str, true);
        }
        private static void WriteInMode(string path, Furniture[] objs, FileMode fileMode)
        {
            if (File.Exists(path) == false) File.Create(path).Close();
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, fileMode)))
            {
                foreach (var item in objs)
                {
                    writer.Write(item.Name);
                    writer.Write(item.Kind);
                    writer.Write(item.Amount);
                    writer.Write(item.Price);
                    writer.Write(item.Color.ToString());
                }
            }
        }
    }
    enum OpenMode
    {
        Append,
        Write
    }
}
