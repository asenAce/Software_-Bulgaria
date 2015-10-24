using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GravitationOnTheMoon
{
    class Program
    {
        //The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that 
        //calculates the weight of a man on the moon by a given weight on the Earth. Examples
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your weight"); // 1.Out put to the console asking the user his weight
            double earthWeight = double.Parse(Console.ReadLine()); //2. The given value from the user is converted by .Parse after that
            // the value is stored in the variable earthWeight with type double .
            double moonWeight = ((double)0.17 * (earthWeight)); // 3.Now we found the value of moonWeight by formula  earthWeight multiplat
            // by 0.17 which is 17 % of the number will give us the value of moonWeight.
            Console.WriteLine("Your weight on the Moon will be :{0}",moonWeight); //4.Out Put prompt to the console the result, the result
            //is depict by placeholder.
            Console.Read();
        }
    }
}
