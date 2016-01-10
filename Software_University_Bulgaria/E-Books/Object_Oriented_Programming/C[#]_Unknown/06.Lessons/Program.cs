using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * double bankBal = 1000;
             * const double INT_RATE = 0.04;    
             * string inputString;    
             * char response;      
             * Console.Write("Do you want to see your balance? Y or N ..."); 
             * inputString = Console.ReadLine();     
             * response = Convert.ToChar(inputString); 
             * 
             * while(response == 'Y')    
             * {          
             * Console.WriteLine("Bank balance is {0}", bankBal.ToString("C"));    
             * bankBal = bankBal + bankBal * INT_RATE; 
             * Console.Write("Do you want to see next year's balance? Y or N ...");    
             * inputString = Console.ReadLine();      
             * response = Convert.ToChar(inputString);  
             * }    
             * 
             * Console.WriteLine("Have a nice day!");
             * 
             * */

            double bankBal = 1000;
            const double INT_RATE = 0.04;
            string inputString;
            char response;

            Console.WriteLine("Do you want to see your balance?  Y or N .....");
            inputString = Console.ReadLine();
            response = Convert.ToChar(inputString);

            while (response == 'Y')
            {
                Console.WriteLine("Bank balance is {0}",bankBal.ToString("C"));
                bankBal = bankBal + bankBal * INT_RATE;
                Console.WriteLine("Do you want to see next year's balance? Y or N ...");
              // inputString = Console.ToChar(inputString);
            }

            Console.WriteLine("Have a nice day");
        }
    }
}
