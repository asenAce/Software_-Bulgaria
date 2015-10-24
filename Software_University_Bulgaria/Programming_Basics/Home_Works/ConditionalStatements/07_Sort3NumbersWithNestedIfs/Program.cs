using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07.Sort3NumbersWithNestedIfs
{
    /**
     * Write a program that enters 3 real numbers and prints them sorted in descending order. 
     * Use nested if statements. Don’t use arrays and the built-in sorting functionality.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program   enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality.");
            Console.WriteLine("**************************************************");
            
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if( a >b && a>c)
            {
                //Console.WriteLine("The order of the numbers are as follow:{0}{1}{2} ",a,b,c);
                if(b>c)
                {
                    Console.WriteLine("The order of the numbers are as follow:{0} {1} {2} ",a,b,c);
                }
                else
                {
                    Console.WriteLine("The order of the numbers are as follow:{0}  {1}  {2} ",a,c,b);
                }
                Console.ReadLine();
            }
            else if( b>a && b>c)
            {
                //Console.WriteLine("The order of the numbers are as follow:{0}{1}{2} ",b,a,c);
                if (c> a) //Compare c with a  in order to print the right sicuence of numbers.
                {
                    Console.WriteLine("The order of the numbers are as follow:{0} {1} {2} ", b, c, a);
                }
                else
                {
                    Console.WriteLine("The order of the numbers are as follow:{0}  {1}  {2} ", b, a, c);
                }
                Console.ReadLine();
            }
            else if(c>a && c > b)
            {
                //Console.WriteLine("The order of the numbers are as follow:{0}{1}{2} ",c,b,a);
                if (a > b)
                {
                    Console.WriteLine("The order of the numbers are as follow:{0} {1} {2} ", c, a, b);
                }
                else
                {
                    Console.WriteLine("The order of the numbers are as follow:{0}  {1}  {2} ", c, b, a);
                }
                Console.ReadLine();
            }
            else if(a==b && b==c)
            {
                Console.WriteLine("The numbers are equals");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Dammm , you are joycking again");
            }



        }
    }
}
