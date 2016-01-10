using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017.MethodsTrainingII
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MYRATE = 12.88;
            double myHour = 44;
            double grossPayment;
            grossPayment = CalcPayment(myHour,MYRATE);

            Console.WriteLine("work{} rate{}",myHour,MYRATE);
            Console.WriteLine("My Gross Payment is {0}",grossPayment.ToString("C"));
        }


        public static double CalcPayment(double hour,double rate)
        {
            double gross;
            gross = hour * rate;
            return gross;
        }

    }
}
