using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge02
{
    public class Circle : Shape
    {

        public double PI { get; set; }
        public double Radius { get; set; }
          

        public Circle(double _Colour, double _PI, double __Radius) : base(_Colour)
        {
            PI = _PI;
            Radius = __Radius;
        }

        public double GetArea()
        {
            PI = 3.142;
            return PI * (Radius * Radius);
        }

        public double GetPerimeter()
        {
            PI = 3.142;
            return 2 * PI * Radius;
        }

    }
}
