using ShapesDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeManager sm = new ShapeManager();

            string userinput = "";

            Console.WriteLine("Press 1 to create a square");
            Console.WriteLine("Press 2 to create a triangle");
            Console.WriteLine("Press 9 to close loop");




            while (userinput != "9")
            {
                if (userinput == "1")
                {
                    sm.AddShape(new Square(7));
                    Console.WriteLine("Parameter:" + sm.GetFirstShape().GetPerimeter());
                    Console.WriteLine("Area:" + sm.GetFirstShape().GetArea());
                    userinput = "";
                }
                else if (userinput == "2")
                {
                    sm.AddShape(new Triangle(3, 5, 7));
                    Console.WriteLine("Parameter:" + sm.GetFirstShape().GetPerimeter());
                    Console.WriteLine("Area:" + sm.GetFirstShape().GetArea());
                    userinput = "";
                }
                else
                {
                    userinput = Console.ReadLine();
                }
                
            }
        }
    }
}
