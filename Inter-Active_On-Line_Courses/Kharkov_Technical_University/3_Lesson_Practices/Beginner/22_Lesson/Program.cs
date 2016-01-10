using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Power
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("number");
            double number = int.Parse(Console.ReadLine());

            Console.WriteLine("Power: ");
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine("The Power is :  ");
            Console.WriteLine(Power(number,power));

            Console.WriteLine("The Power down is  :  ");
            Console.WriteLine(Power(number, power,true));
        }


        static double Power( double paramNumber,int paramPower)
        {
            double result = Math.Pow(paramNumber,paramPower);
            return result;
        }

        static double Power( double paramNumber,int paramPower,bool roundDown)
        {
            double result = Power(paramNumber,paramPower);

            if ( roundDown)
            {
                result = Math.Floor(result);
            }

            return result;

            Console.ReadLine();
        }

        
    }
}
