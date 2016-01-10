using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Budget
{
    /**
     * Kiro is a grown up now. He’s working and he has a certain amount of money available to last the month. He wants to know if that’s possible. Kiro spends 10lv every weekday when he’s not going out. He goes out p weekdays in the month. When he goes out he spends 3% of his total budget (rounded down to the nearest integer. Example: 3% of 608 = 18.24 rounded down to 18) in addition to his normal daily expense of 10lv. On weekends Kiro spends 20lv per day when he’s not going to his hometown. Kiro goes to his hometown h weekends per month. When he’s at his hometown he doesn’t spend anything because he stays with his parents. On top of everything Kiro pays 150lv per month for rent. We assume that each month has 30 days and 4 weekends.
Your task is to write a program that calculates if Kiro can last the month.
     * 
Input
The input data should be read from the console. It consists of three input values, each at separate line:
The number n – amount of money Kiro has to last the month.
The number p – number of weekdays Kiro goes out per month.
The number h – number of weekends that Kiro spends in his hometown.
The input data will always be valid and in the format described. There is no need to check it explicitly.
     * 
Output
The output data must be printed on the console.
On the only output line you must print “Yes, leftover {0}.” if Kiro has enough to last the month, or ”No, not enough {0}.” if he can’t.
Print “Exact Budget.” if Kiro has just enough.
     * 
Constraints
The number n is an integer in range [0... 2,147,483,647].
The number p is an integer in range [0…22] and h is an integer in range [0…4]. 
Allowed working time for your program: 0.25 seconds.
Allowed memory: 16 MB.

     * 
     * */


    class Budget
    {
        static void Main(string[] args)
        {

            // input

            int money = int.Parse(Console.ReadLine());
            int weekdaysGoingOut = int.Parse(Console.ReadLine());
            int homeTownWeekends = int.Parse(Console.ReadLine());


            int normalWeekDays = 22 - weekdaysGoingOut;
            int totalWeekendDays = 8;

            // logic

            totalWeekendDays -=(homeTownWeekends * 2);
            // 10 * ((3% of 800) + 10) 

            int moneySpent = normalWeekDays * 10 ;
            moneySpent += weekdaysGoingOut * (((3 * money / 100)) * 10);
            moneySpent += 150;
            moneySpent += totalWeekendDays * 20;


            int moneyLeft = money - moneySpent;  // Neto

            if (moneyLeft > 0 )
            {
                Console.WriteLine("Yes, leftovers {0}.",moneyLeft);
            }

            else if (moneyLeft < 0)
            {
                Console.WriteLine("No, not enough {0}.",Math.Abs(moneyLeft));
            }
            else
            {
                Console.WriteLine("Exact Budget.");
            }
            // output

            Console.WriteLine(moneySpent);


        }
    }
}
