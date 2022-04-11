using System.Linq;

namespace Lab2
{
    internal static class ContentWorker
    {
        public static Furniture[] GetAvaibleTypes(Furniture[] furnitures, string category)
        {
            return furnitures.Any(f => f.Name == category)
                ? furnitures.Where(f => f.Name == category && f.Amount > 0).ToArray()
                : new Furniture[0];
        }
        public static Furniture[] GetItemsInRange(Furniture[] furnitures, int minValue, int maxValue)
        {
            return furnitures.Where(f => f.Price >= minValue && f.Price <= maxValue).ToArray();
        }
    }
}
