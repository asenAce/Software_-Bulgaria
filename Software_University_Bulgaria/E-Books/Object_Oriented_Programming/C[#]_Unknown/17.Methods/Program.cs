using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017.Methods
{
    public class HelloClass
    {
        public static void Main(string[] args)
        {

            double myHours = 32.3;
            double myRate = 12.33;
            double grossPay;

            grossPay = CalcPay(myHours,myRate);

            Console.WriteLine("I work  {0} hours at {1} pre hour",myHours,myRate);
            Console.WriteLine("My gross pay is {0}",grossPay.ToString("C"));

            ShowWelcomeMessage();
            Console.WriteLine("Hi");

            double myPurchase = 12.99;
            DisplaySalesTax(myPurchase);
            DisplaySalesTax(33.44);


        }

        public static void ShowWelcomeMessage()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Hello");
            Console.WriteLine("Have a nice day");
        }

        public static void DisplaySalesTax(double saleAmount)
        {
            double tax;
            const double RATE = 0.07;
            tax = saleAmount * RATE;

            Console.WriteLine("The tax on {0} is {1}",saleAmount.ToString("C"),tax.ToString("C"));
        }


        public static double CalcPay(double hours,double rate)
        {
            double gross;
            gross = hours * rate;
            return gross;
        }

    }
}
