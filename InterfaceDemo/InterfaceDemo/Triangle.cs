using ShapesDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Triangle : IShape
    {
        double sideOneLength { get; set; }
        double sideTwoLength { get; set; }
        double sideThreeLength { get; set; }

        public Triangle(double psideOneLength, double psideTwoLength, double psideThreeLength)
        {
            sideOneLength = psideOneLength;
            sideTwoLength = psideTwoLength;
            sideThreeLength = psideThreeLength;
        }

        public double GetArea()
        {
            return 0.5 * sideOneLength * sideTwoLength;
        }

        public double GetPerimeter()
        {
            return sideOneLength + sideTwoLength + sideThreeLength;
        }
    }
}
