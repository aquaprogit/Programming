using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Furniture
    {
        public Furniture(string name, string type, int amount, int price, Color color)
        {
            Name = name;
            Kind = type;
            Amount = amount;
            Price = price;
            Color = color;
        }
        public string Name { get; private set; }
        public string Kind { get; private set; }
        public Color Color { get; private set; }
        public int Price { get; private set; }
        public int Amount { get; private set; }

        public override string ToString()
        {
            return $"Title : {Name} {Kind}\n" +
                   $"Amount: {Amount}\n" +
                   $"Price : {Price}\n" +
                   $"Color : {Color}";
        }
    }
    enum Color
    {
        Red,
        Green,
        Blue,
        Yellow,
        Orange,
        Purple,
        Brown,
        White,
        Black
    }
}
