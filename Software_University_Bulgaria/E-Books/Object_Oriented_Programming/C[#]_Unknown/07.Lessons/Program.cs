using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Lesson.BankPrograme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson 07 BankPrograme

            /*
             * double bankBal;  
             * double rate;      
             * int year;     
             * const double START_BAL = 1000;    
             * const double START_INT = 0.04;    
             * const double INT_INCREASE = 0.02;    
             * const double LAST_INT = 0.08;     
             * const int END_YEAR = 5;    
             * 
             * for(rate = START_INT; rate <= LAST_INT; rate += INT_INCREASE)   
             * {    
             * 
             * bankBal = START_BAL;        
             * Console.WriteLine("Starting bank balance is {0}",bankBal.ToString("C"));       
             * Console.WriteLine("  Interest Rate: {0}",rate.ToString("P"));     
             * 
             * for(year = 1; year <= END_YEAR; ++year)    
             * {           
             * bankBal = bankBal + bankBal * rate;  
             * Console.WriteLine("  After year {0}, bank balance is {1}",year, bankBal.ToString("C")); 
             * 
             * 
             * */

           // int year;

            const double START_BAL = 1000;
            const double START_INT = 0.04;
            const double INT_INCREASE = 0.02;
            const double LAST_INT = 0.08;
            const int END_YEAR = 5;

            for (double rate = START_INT; rate <= LAST_INT; rate += INT_INCREASE)
            {
                double bankBal = START_BAL;
                Console.WriteLine("starting bank balance is {0}",bankBal.ToString("C"));
                Console.WriteLine("Interest rate: {0}",rate.ToString("P"));

                for (int year = 1; year <= END_YEAR; year++)
                {
                    bankBal = bankBal + bankBal * rate;
                    Console.WriteLine("After year {0}, bank balance is {1}",year,bankBal.ToString("C"));
                }
            }




        }
    }
}
