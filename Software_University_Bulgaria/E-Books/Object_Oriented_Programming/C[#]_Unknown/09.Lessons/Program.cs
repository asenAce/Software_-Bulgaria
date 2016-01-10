using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Resourant
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lesson 09 Resourant
             * */
            double dinnerPrice = 10.00; 
            double tipRate; 
            double tip;

            const double LOWRATE = 0.10;
            const double MAXRATE = 0.25; 
            const double TIPSTEP = 0.05; 
            const double MAXDINNER = 100.00;
            const double DINNERSTEP = 10.00;
 
            Console.Write(" Price");
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
            {
                Console.Write("{0, 8}",tipRate.ToString("F")); 
                Console.WriteLine(); 
                Console.WriteLine("----------------------------------------");

                const int NUM_DASHES = 40;
                for (int x = 0; x < NUM_DASHES; ++x)
                {
                    Console.Write("-");
                    Console.WriteLine();
                }
            }

            tipRate = LOWRATE;

            while (dinnerPrice <= MAXDINNER)
            { 
                Console.Write("{0, 8}", dinnerPrice.ToString("C")); 
                while (tipRate <= MAXRATE) 
                { 
                    tip = dinnerPrice * tipRate; 
                    Console.Write("{0, 8}", tip.ToString("F")); tipRate += 0.05;
                } 

                dinnerPrice += DINNERSTEP; 
                tipRate = LOWRATE;
                Console.WriteLine(); 
            } 

        }
    }
}
