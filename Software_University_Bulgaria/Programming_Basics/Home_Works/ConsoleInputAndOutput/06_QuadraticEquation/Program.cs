using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    //Write a program that reads the coefficients a, b and c of a
    //quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). Examples:

    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = ((b * b) - (4 * a * c));

            if(discriminant > 0 )
            {
                double x1 = ((-b) - Math.Sqrt(discriminant))/(2*a); 
                double x2 = ((-b) + Math.Sqrt(discriminant))/(2*a);
                Console.Write("x1 = {0} , x2 = {1}",x1,x2);
            }
            else if (discriminant == 0 )
            {
                double x1AndX2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("x1 = x2 = {0}",x1AndX2);
            }
            else if (discriminant <0)
            {
                Console.WriteLine("No real roots.");
            }
            Console.Read();

        }
    }
}
