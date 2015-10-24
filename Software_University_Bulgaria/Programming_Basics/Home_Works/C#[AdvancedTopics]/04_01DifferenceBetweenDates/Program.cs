using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04.DifferenceBetweenDatesTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateStringFirst = Console.ReadLine();
            string dateStrinfSecond = Console.ReadLine();
            string format = "d.MM.yyyy";
            DateTime firstDate = DateTime.ParseExact(dateStringFirst,format,CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(dateStringFirst, format, CultureInfo.InvariantCulture);

            int difference = CalculateNumberDifferenceDates(firstDate,secondDate);
            Console.WriteLine("Days between : {0} ",difference);
            Console.ReadLine();
        }

        private static int CalculateNumberDifferenceDates(DateTime firstDate,DateTime secondDate)
        {
            
            // Difference in days,hours , and minutes.
            TimeSpan ts = firstDate-secondDate;

            //Difference in days.
            int differenceInDays = ts.Days;
            int differenceInHours = ts.Hours;
            return differenceInDays;
            return differenceInHours;
            Console.ReadLine();

        }
    }
}
