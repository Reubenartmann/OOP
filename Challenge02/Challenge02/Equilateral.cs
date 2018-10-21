using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge02
{
    public class Equilateral : Triangle
    {
        public Equilateral(double _Colour, double _Side1, double _Side2, double _Side3) : base(_Colour, _Side1, _Side2, _Side3)
        {
        }

        public double GetArea()
        {
            double i = (Side1 + Side2 + Side3) / 2.0;
            return Math.Round(Math.Sqrt(i * (i - Side1) * (i - Side2) * (i - Side3)), 1);
        }

        public double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }

    }
}
