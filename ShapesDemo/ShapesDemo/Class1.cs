using System;

namespace ShapesDemo
{
    public class Square : IShape
    {
        public int SideLength { get; set; }


        public Square(int pSideLength)
        {
            SideLength = pSideLength;
        }
        public double GetArea()
        {
            return SideLength * SideLength;
        }

        public double GetPerimeter()
        {
            return SideLength + SideLength + SideLength + SideLength;
        }
    }
}
