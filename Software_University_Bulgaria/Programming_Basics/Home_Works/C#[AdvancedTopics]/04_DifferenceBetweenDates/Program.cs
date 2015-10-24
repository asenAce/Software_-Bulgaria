using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DifferenceBetweenDates
{
    class Program
    {
        /**
         * Write a program that enters two dates 
         * in format dd.MM.yyyy and returns the number of days between them
         * */

        public static int CalculateDifferenceInDays(DateTime firstDate, DateTime secondDate)
        {
            TimeSpan difference = secondDate - firstDate;
            return int.Parse(difference.TotalDays.ToString());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("first date is :  ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("second date is :  ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(CalculateDifferenceInDays(firstDate,secondDate));
            Console.ReadLine();
        }
    }
}
