using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            int hour = DateTime.Now.Hour;

            if (hour < 12)  //condition
            {
                Console.WriteLine("Good morning");      //alternative
            }
            else if (hour < 18)
            {
                Console.WriteLine("Good afternoon");
            }
            else
            {
                Console.WriteLine("Good evening");
            }

            // What if we want more than one statement?
            if (hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("Who wants lunch?");
            }
            //Nested if statements

            if (hour<12)
            {
                Console.WriteLine("gOOD AFTERNOON");
            }
            else
            {
                if (hour < 18)
                {
                    Console.WriteLine("Good afternoon!");
                }
                else
                {
                    Console.WriteLine("Good evening!");
                }
            // A deeper if statements


            }

            // An if statement takes any Boolean expression,not just a comparison.

            bool isMorning = hour < 12;

            
            if (isMorning)
            {
                Console.WriteLine("Good morning");
            }
            
            if (!isMorning)
            {
                Console.WriteLine("Good afternoon!");
            }
           // Use && and ||

            DayOfWeek day = DateTime.Now.DayOfWeek;
            bool isSaturday = day == DayOfWeek.Saturday;
            bool isSunday = day == DayOfWeek.Sunday;

            if (isSaturday || isSunday)
            {
                if (isMorning)
                {
                    Console.WriteLine("Who wants brunch?");
                }
                
            }

            // Or

            if ((isSaturday || isSunday) && isMorning)
            {
                Console.WriteLine("Time for sex");
            }


        }
    }
}
