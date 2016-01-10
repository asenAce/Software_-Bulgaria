using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examPrep0711._014
{
    class Program
    {
        static void Main(string[] args)
        {
            // ctr f

            int money = int.Parse(Console.ReadLine());
            int weekdaysGoingOut = int.Parse(Console.ReadLine());
            int hometownweekends = int.Parse(Console.ReadLine());

            int normalWeekdays = 22 - weekdaysGoingOut;
            int totalWeekendsDays = 8;

            totalWeekendsDays -= (hometownweekends * 2);
            //10*((3% of 800)+10)
            int moneySpent = normalWeekdays * 10;
            moneySpent += weekdaysGoingOut + (((3 * money) / 100) + 10);
            moneySpent += 150;
            moneySpent += totalWeekendsDays * 20;

            int moneyLeft = money - moneySpent;

            if (moneyLeft > 0)
            {
                Console.WriteLine("Yes,leftover {0}.",moneyLeft);
            }
            else if ( moneyLeft < 0 )
            {
                Console.WriteLine("No,not enough {0}.",Math.Abs(moneyLeft));
            }
            else
            {
                Console.WriteLine("Exact Budget.");
            }
            
            Console.WriteLine();
        }
    }
}
