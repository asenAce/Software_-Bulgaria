using _01.Shapes.IFaces;
using _01.Shapes.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Start
    {
        static void Main(string[] args)
        {

            IShapes[] shapes = 
            {
                new Circle(2.5),
                new Rectangle(13,2.5),
                new Triangle(8,3.5,8),
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("This is a {0} with area: {1:f2} and perimeter {2:f2}"
                    ,shape.GetType().Name
                    ,shape.CalculateArea()
                    ,shape.CalculatePerimeter());

            }

        }
    }
}
