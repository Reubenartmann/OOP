using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge02
{
    public class Triangle : Shape
    {

        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double _Colour, double _Side1, double _Side2, double _Side3) : base (_Colour)
        {
            Side1 = _Side1;
            Side2 = _Side2;
            Side3 = _Side3;
        }



    }
}
