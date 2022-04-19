using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>();
            Console.Write("Enter word to work with: ");
            string input = "dskgkdfjl;wfklwefwejnewjghwqlqwdqkjdlkwqhriqowursnajhrwqjrhsajhjkqwfjhsfhjsaihujwenbjasddjbasdihwiuhwqjsdajkas";
            foreach (char i in input)
            {
                tree.Insert(i);
                Console.Write("|" + i + " " + ((int)i).ToString().PadLeft(3) + "| ");
            }
            Console.WriteLine();
            var withRepeatance = tree.PostorderTreeWalk()
                            .GroupBy(g => g)
                            .Select(c => new { Value = c.Key, Count = c.Count() })
                            .Where(a => a.Count > 1);
            Console.WriteLine(tree.DisplayTree());

            foreach (var item in withRepeatance)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    tree.Remove(item.Value);
                    Console.WriteLine(tree.DisplayTree());
                }
            }

            foreach (int i in tree.PostorderTreeWalk())
            {
                Console.Write("|" + (char)i + " " + i.ToString().PadLeft(3) + "| ");
            }
            Console.ReadLine();
        }
    }
}
