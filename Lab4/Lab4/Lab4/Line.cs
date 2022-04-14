namespace Lab4
{
    internal class Line
    {
        public Point A { get; private set; }
        public Point B { get; private set; }

        public Line()
        {
            A = new Point();
            B = new Point(x: 1);
        }
        public Line(Point pointEnd)
        {
            A = new Point();
            B = pointEnd;
        }
        public Line(Point pointStart, Point pointEnd)
        {
            A = pointStart;
            B = pointEnd;
        }
        public Line((double, double) pointEnd)
        {
            A = new Point();
            B = new Point(pointEnd);
        }
        public Line((double, double) pointStart, (double, double) pointEnd)
        {
            A = new Point(pointStart);
            B = new Point(pointEnd);
        }
        public static Line operator +(Line first, Line second)
        {
            Point vectorFirst = new Point(first.B.X - first.A.X, first.B.Y - first.A.Y);
            Point vectorSecond = new Point(second.B.X - second.A.X, second.B.Y - second.A.Y);
            Point resultVector = new Point(vectorFirst.X + vectorSecond.X, vectorFirst.Y + vectorSecond.Y);
            return new Line((resultVector.X + first.A.X, resultVector.Y + first.A.Y));
        }
        public static Line operator ++(Line self)
        {
            return new Line(self.A, new Point(self.B.X + 1, self.B.Y + 1));
        }
        public bool IsOnLine(Point point)
        {
            var equation = this.GetEquationOfLine();
            return point.X * equation.xCoeff + equation.freeCoeff == point.Y &&
                point.X.InRange(A.X, B.X) &&
                point.Y.InRange(A.Y, B.Y);

        }
        public (double xCoeff, double freeCoeff) GetEquationOfLine()
        {
            double xCoeff = (double)(B.Y - A.Y) / (B.X - A.X);
            double freeCoeff = -1.0D * A.X * xCoeff + A.Y;
            return (xCoeff, freeCoeff);
        }
        public override string ToString()
        {
            var (xCoeff, freeCoeff) = GetEquationOfLine();
            return $"[{A} -> {B}]\n" +
                $"y = {xCoeff:F4}x {freeCoeff:+0.##}";
        }
    }
}
