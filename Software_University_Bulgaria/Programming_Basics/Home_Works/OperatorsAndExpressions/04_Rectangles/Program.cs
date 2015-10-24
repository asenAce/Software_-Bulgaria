using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rectangles
{
    //Write an expression that calculates rectangle’s
    //perimeter and area by given width and height. Examples:
    
    class Program
    {
        static void Main(string[] args)
        {
            string centimeters = "centimeters";
            Console.WriteLine("Program description:This program Write an expression that calculates rectangle’s perimeter and area by given width and height. ");
            Console.WriteLine("Please state the width of the rectangle in centimeters: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please state the height of the rectangle in centimeters: ");
            double height = double.Parse(Console.ReadLine());
            double area = height * width;
            // The formula for  the perimeter is  2*(Side A + Side B);
            double perimeter = 2*(height + width);
            Console.WriteLine("**************************************************");
            Console.WriteLine("The area of the rectengle is : \n{0} {1} \nand his perimeter is :\n{2} {3}",area,centimeters,perimeter,centimeters);
            Console.Read();
        }
    }
}
