using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017.HomeWork
{
    class Program
    {
       public static void Main(string[] args)
        {
            int[] callLength = { 2,6};
            double[] rate = { 0.04,0.12};
            double priceOfCall;

            Console.WriteLine("{0,10}{1,10}{2,10}","Minutes","Rate","Price");

           for ( int x = 0; x < callLength.Length; x++)
			{
			    for (int y = 0; y < rate.Length; y++)
			    {
			        priceOfCall = CalcPhoneCallPrice(callLength[x],rate[y]);
                    Console.WriteLine("{0,10}{1,10}{2,10}",callLength[x],rate[y],priceOfCall.ToString("C"));
			    }
			}

        }

        public class PhoneCallsOne(int[] callLength)
        {
             

        }

        public static double CalcPhoneCallPrice(int minutes,double rate)
        {
            const double BASE_FEE = 0.25;
            double callFee;
            callFee = (BASE_FEE + minutes) * rate;
            return callFee;
        }
    }
}
