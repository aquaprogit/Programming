using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class TextWorker
    {
        public string[] SecondWithoutFirst(string[] first, string[] second)
        {
            return second.Except(first).ToArray();
        }
    }
}
