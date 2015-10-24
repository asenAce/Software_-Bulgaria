using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInACircle
{
    //⦁	Point in a Circle,Write an expression that checks if given point (x,  y)
    //is inside a circle K({0, 0}, 2). Examples:

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x =  ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("y = ");
            double y = double.Parse(Console.ReadLine());

            bool isInside = (x*x)+(y*y) <= (2*2);
            Console.WriteLine("Those cordinates are inside the circle= : " + isInside);
            Console.ReadLine();
        }
    }
}
