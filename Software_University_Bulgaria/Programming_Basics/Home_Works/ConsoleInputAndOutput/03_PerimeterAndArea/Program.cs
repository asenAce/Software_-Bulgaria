using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclePerimeterAndArea
{
    /**
     * Write a program that reads the radius r of a circle and prints
     * its perimeter and area formatted with 2 digits after the decimal point. Examples:
     * */


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" radios = "); //Out Put to the console
            double radios = double.Parse(Console.ReadLine());  // ReadLine inPut from the user store the given  value in the variable called
            // radios  ID with a type double mean can show 0.0 but before that .Parse converted...
 
            double perimeter  = (2 * Math.PI)* radios;  // The formula for a perimether Math object with. PI method
            double area = Math.PI*(radios * radios);       //The formula for area 

            Console.WriteLine("The Perimeter is : {0:f2}",perimeter);   //Out Put to the conslole ,using placeHolders 
            Console.WriteLine("The Area is :{0:f2}",area);
            Console.Read(); // Hold the console


        }
    }
}
