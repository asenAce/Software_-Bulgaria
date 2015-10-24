using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010.PointInsideACircleOutsideOfARectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
           
            bool isInCircle = (x - 1)*(x-1)+(y - 1)*(y - 1)<=(1.5 * 1.5);
            bool isOutsideRectangle = x > 1 || x < 6 && y > -1 || y < 2;

            if( x == 0 || y == 0 )
            {
                Console.WriteLine("naine");
            }
            else if( isInCircle == true && isOutsideRectangle == true)
            {
                Console.WriteLine("  Yhea ,Yhea vunda ba ");
            }
            else
            {
                Console.WriteLine("  Willst du mich verarschen !!!");
            }

            Console.WriteLine("Goten aben !!");
            Console.ReadLine();



        }
    }
}
