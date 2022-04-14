namespace Lab4
{
    internal class Point
    {
        public double X { get; private set; } = 0;
        public double Y { get; private set; } = 0;

        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
        public Point((double x, double y) coord)
        {
            (X, Y) = coord;
        }

        public override string ToString()
        {
            return $"({X:0.##}, {Y:0.##})";
        }
    }
}
