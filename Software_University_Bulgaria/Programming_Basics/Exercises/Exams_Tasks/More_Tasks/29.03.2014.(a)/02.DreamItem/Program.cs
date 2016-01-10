using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DreamItem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Date from the console .Split is a method in the parameters () we state that will
            // read separetly the date from the console as the orientir will be .Array\\ 
            string[] input = Console.ReadLine().Split('\\');
            
            // type string ID month asign = input the info from the console on possition [0] 
            //first 
            string  month = input[0];
            //Instantiate a variable moneyPerHour with type decimal 
            // asign = decimal.Parse -method () parameters input [1] second possition
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

            if (moneyPerMonth > 700)
            {
                moneyPerMonth = moneyPerMonth + moneyPerMonth * 0.1M ;
            }

            decimal moneyLeft = moneyPerMonth - itemPrice;
            string output = "";

            if (moneyLeft >= 0)
            {
                output = string.Format(" Money left = {0:f2} leva.",moneyLeft);
            }

            else
            {
                output = string.Format(
                    "Not enough money bro  {0:f2} need it",Math.Abs(moneyLeft));
            }

            Console.WriteLine(output);
        }
    }
}
