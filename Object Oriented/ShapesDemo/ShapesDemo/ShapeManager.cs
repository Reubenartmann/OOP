using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapesDemo
{
    public class ShapeManager
    {
        List<IShape> ShapesList = new List<IShape>();

        public ShapeManager()
        {

        }

        public void AddShape(IShape pShape)
        {
            ShapesList.Add(pShape);
        }

        public IShape GetFirstShape()
        {
            return ShapesList.First();
        }
        public IShape GetLastShape()
        {
            return ShapesList.Last();
        }
    }
}
