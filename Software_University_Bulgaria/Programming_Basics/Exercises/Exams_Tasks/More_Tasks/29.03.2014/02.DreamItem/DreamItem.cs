using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DreamItem
{
    class DreamItem
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split('\\');  // Mthod Split. take the value from the console and separeted it in 
            //this case the devider is '\\' so later we can use it for massive; 

            string month = input[0];
            decimal moneyPerHour = decimal.Parse(input[1]);
            decimal hoursPerDay = decimal.Parse(input[2]);
            decimal itemPrice = decimal.Parse(input[3]);

            int daysPerMonth = 31;

            switch (month)
            {
                case "Feb":
                    daysPerMonth = 18;
                    break;
                case "Apr":
                case "Jun":
                case "Sept":
                case "Nov":
                    daysPerMonth = 20;
                    break;
                default:
                    daysPerMonth = 21;
                    break;
            }

            decimal hoursPerMonth = hoursPerDay * daysPerMonth;
            decimal moneyPerMonth = hoursPerMonth * moneyPerHour;

            if ( moneyPerMonth> 700)
            {
                moneyPerMonth = moneyPerMonth + (moneyPerMonth * 0.1M);
            }

            decimal moneyLeft = moneyPerMonth - itemPrice;

            string output = "";
            if (moneyLeft >= 0)
            {
                output = string.Format("Money left = {0:f2} leva.",moneyLeft);
            }

            else
            {
                output = string.Format("Not enough money. {0:f2} leva needed.",Math.Abs(moneyLeft));
            }
            Console.WriteLine(output);

        }
    }
}
