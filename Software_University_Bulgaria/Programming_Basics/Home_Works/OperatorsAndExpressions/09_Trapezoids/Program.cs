using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Program
    {
        //Write an expression that calculates trapezoid's area by given sides a and b and height h. 
        static void Main(string[] args)
        {
            //Formula for an area of a Trapech is A= (base a + base b)* h / 2
            Console.WriteLine(" This program  calculates trapezoid's area by given sides a and b and height h.");
            Console.WriteLine("******************************************************************");
            Console.WriteLine("Please state the value of site a =  ");
            double siteA = double.Parse(Console.ReadLine());
            Console.WriteLine("Please state the value of site b =  ");
            double siteB = double.Parse(Console.ReadLine());
            Console.WriteLine("Please state the value of site h =  ");
            double h = double.Parse(Console.ReadLine());
            double theArea = ((siteA + siteB)*h) /2;


            Console.WriteLine("The area of the Trapezoid is:{0}  ",theArea);
            Console.Read();






        }
    }
}
