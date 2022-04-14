namespace Lab4
{
    internal static class Extension
    {
        public static bool InRange(this double self, double minValue, double maxValue)
        {
            if (minValue > maxValue)
                (minValue, maxValue) = (maxValue, minValue);
            return self >= minValue && self <= maxValue;
        }
    }
}
