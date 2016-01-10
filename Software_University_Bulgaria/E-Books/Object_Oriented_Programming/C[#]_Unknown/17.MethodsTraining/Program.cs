using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017.MethodsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MYRATE = 12.2;
            double myHours = 12.45;
            double grossPay;

            grossPay = calcPayment(myHours,MYRATE);

            Console.WriteLine("I worked those hours {0} , my rate is {1}",myHours,MYRATE);
            Console.WriteLine("My gross payment is {0}",grossPay.ToString("C"));

        }

        public static double calcPayment(double hours,double RATE)
        {
            double gross;
            gross = hours * RATE;
            return gross;

        }
    }



}
