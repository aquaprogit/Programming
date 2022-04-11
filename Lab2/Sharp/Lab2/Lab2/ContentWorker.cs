using System.Linq;

namespace Lab2
{
    internal static class ContentWorker
    {
        public static Furniture[] GetAvailableTypes(Furniture[] furnitures, string category, string kind)
        {
            return furnitures.Any(f => f.Name == category)
                ? furnitures.Where(f => f.Name == category && f.Kind == kind && f.Amount > 0).ToArray()
                : new Furniture[0];
        }
        public static Furniture[] GetItemsOutOfRange(Furniture[] furnitures, int minValue, int maxValue)
        {
            return furnitures.Where(f => f.Price <= minValue || f.Price >= maxValue).ToArray();
        }
    }
}
