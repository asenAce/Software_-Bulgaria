using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTriangleArea
{
    class Program
    {
        static double CalcTriangleArea(double width,double height) // this is the method.
        //acces modifaer , type , ID CalcTriangleArea (width, height) those are parameters
        {
            return (width * height) / 2;  //This is the formula
        }


        static void Main(string[] args)
        {
            DateTime today = DateTime.Now; // static . net classes
            double cosine = Math.Cos(Math.PI);

            Random rnd = new Random();
            int randomNumber = rnd.Next(1,99);

            Console.Write("Enter triangle width:  ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter triangle hight:  ");
            double high = double.Parse(Console.ReadLine());

            Console.WriteLine(CalcTriangleArea(width,high));
            Console.ReadLine();



        }
    }
}
