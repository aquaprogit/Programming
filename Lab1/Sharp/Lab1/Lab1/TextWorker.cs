using System.Linq;

namespace Lab1
{
    internal class TextWorker
    {
        public string[] SecondWithoutFirst(string[] first, string[] second)
        {
            return second.Where(i => first.Contains(i) == false).ToArray();
        }
    }
}
