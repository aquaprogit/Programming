using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Plane
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public double D { get; private set; }

        public Plane(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public bool IsOwnsPoint(Point point)
        {
            return A * point.X + B * point.Y + C * point.Z + D * 1 == 0;
        }
        public override string ToString()
        {
            string result = "";
            double[] coeffs = new double[] { A, B, C, D };
            string[] varChars = new string[] { "x", "y", "z", "" };
            for (int i = 0; i < coeffs.Length; i++)
            {
                if (coeffs[i] == 0) 
                    continue;
                result += coeffs[i].ToString("+ 0.0;- 0.0") + varChars[i] + " ";
            }
            if (result.StartsWith("+"))
                result = result.Substring(2);
            return result + "= 0";
        }
    }
}
