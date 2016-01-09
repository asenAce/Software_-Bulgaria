using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _05.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now is a static property.
            DateTime time = DateTime.Now;

            var day = time.Day;
            var dayOfWeek = time.DayOfWeek; //an enumerated type
            var second = time.Second;
            var ticks = time.Ticks;


            /**
            DayOfWeek dow = DayOfWeek.Monday; // Good example for OOP DayOfWeek is an Object
                // . Monday is a method . the method is a characteristic of the object.
            **/

            // What happens if we add some time?
            time.AddHours(1.5);
            Console.WriteLine(time);

            DateTime newTime = time.AddHours(1.5);

            //Object creation by using a constructor
            DateTime birthday = new DateTime(1972,11,30);

            var age = DateTime.Now - birthday;

            //A TimeSpan can be a bit tricky

            var days = age.Days;
            var seconds = age.Seconds;
            var totalSeconds = age.TotalSeconds;

            //DateTimes can also be compared
            var result =(birthday < DateTime.Now);

            var culture = CultureInfo.CreateSpecificCulture("en-GB");
            var british = time.ToString(culture);
            var custom = string.Format("{0:yyyy MMM dd hh:mm tt}",time);
             

        }
    }
}
