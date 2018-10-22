using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge02
{
    public class Square : Quadrilateral, IShapeData
    {
        public Square(double _Colour, double _Side1, double _Side2, double _Side3, double _Side4) : base(_Colour, _Side1, _Side2, _Side3, _Side4)
        {

        }

        public double GetArea()
        {
            return Side1 * Side2;
        }

        public double GetPerimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }
    }
}
