using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            string word = "water water";

            Console.WriteLine(word.Substring(0,1));
            Console.WriteLine(word.Substring(0,2));
            Console.WriteLine(word.Substring(1,2));
            Console.WriteLine(word.Substring(0,word.Length-1));
            Console.WriteLine(word.Substring(2,word.Length-1));

            Console.Read();

             * 
             * */
            /*
             * int shipDay; 
             * DayOfWeek deliverDay; 
             * shipDay = (int)DayOfWeek.THURSDAY; 
             * deliverDay = (DayOfWeek) shipDay;

             * */


            int shipDay;
            DayOfWeek deliverDay;
            shipDay = (int)DayOfWeek.Thursday;
            deliverDay = (DayOfWeek)shipDay;

            Console.WriteLine(shipDay);
            Console.WriteLine(deliverDay);
            Console.Read();
        }
    }
}
