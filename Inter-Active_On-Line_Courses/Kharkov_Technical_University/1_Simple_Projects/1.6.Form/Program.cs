using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022.Morgidge
{
    class Program
    {
        static void Main(string[] args)
        {          
            

            //ReadPositiveDecimal();
            #region Input

            //Declaring the variables
            decimal principal;
            decimal interestRate;
            decimal monthlyPayment;

            while(true)
            {
             principal = ReadPositiveDecimal("Please enter the principal: ");
             interestRate = ReadPositiveDecimal("Please enter the interest rate: ");
             monthlyPayment = ReadPositiveDecimal("Please enter the monthly payment: ");

             if (principal*interestRate / 1200 < monthlyPayment)
             {
                 break;
             }
             Console.WriteLine("The monthly payment does not cover the interest!");         
             
            }

            decimal totalInterest = TotalInterest(principal, interestRate, monthlyPayment);
            int payoffMonths = PayoffMonths(principal, interestRate, monthlyPayment);
            
            /**
            decimal totalInterest = TotalInterest(principal,interestRate,monthlyPayment);
            Console.WriteLine("Your total interest is {0:C2}.",totalInterest);

            int months = PayoffMonths(principal, interestRate, monthlyPayment);
            Console.WriteLine("Payoff date is  {0:MMM yyyy}.", DateTime.Now.AddMonths(months));
             * 
             * 
             * decimal[] extraPayments = {100.0m, 300.0m,1000.0m};
            */

            #endregion Input

            decimal[] extraPayments = { 100.0m, 300.0m, 1000.0m };

            foreach (var extraPayment  in extraPayments)
            {
                var newInterest = TotalInterest(principal, interestRate, monthlyPayment + extraPayment);
                var newMonths = PayoffMonths(principal,interestRate,monthlyPayment + extraPayment);

                Console.WriteLine("Extra payment of {0:C2} reduces interest by {1:C2} and time by {2} months.",extraPayment
                    ,totalInterest - newInterest,months - newMonths);
            
             }

            #region Output
            #endregion Output

        }

        static decimal ReadPositiveDecimal(string prompt )
        {
            decimal result;
            while (true)
            {
                #region Input
                Console.WriteLine(prompt);
                string principalText = Console.ReadLine();
                bool isSuccess = decimal.TryParse(principalText, out result);
                #endregion Input
                #region Logic
                if (!isSuccess)
                {
                    Console.WriteLine("Please enter a decimal value.");
                }
                else if (result < 0.0m)
                {
                    Console.WriteLine("Please enter a positive value");
                }
                else
                {
                    break;
                }

            }

            return result;
        }
                

        static decimal TotalInterest (decimal principal,decimal interestRate, decimal monthlyPayment)
        {
            if (principal < 0.0m)
            {
                throw new ArgumentException("principal must be positive","principal");
            }
            if (interestRate < 0.0m)
            {
                throw new ArgumentException("interest rate must be positive","interestRate");
            }
            if (monthlyPayment < 0.0m)
            {
                throw new ArgumentException("monthly payment must be positive","monthlyPayment");
            }
            if (principal * interestRate / 1200 >= monthlyPayment)
            {
                throw new ArgumentException("monthly payment does not cover interest", "monthlyPayment");
            }

            /**
             * Every month there will be a payment,which reduces the principal and pays interest.This 
             * repeats until the principal is gone. 
             * 
             * */

            decimal totalInterest = 0.0m; //starting from 0
            decimal currentPrincipal = principal;

            while (0.0m < currentPrincipal)
            {
                // Those is the Formulas for calculations;
                decimal currentInterest = currentPrincipal * interestRate / 1200;
                decimal reduction = monthlyPayment - currentInterest;
                //   Insurtion
                //   Debug.Assert(reduction > 0.0m);

                currentPrincipal = currentPrincipal - reduction;
                totalInterest = totalInterest + currentInterest;
            }

            return totalInterest;
        }
        #region PayoffMonths Function
            //Another function
        static int PayoffMonths (decimal principal,decimal interestRate,decimal monthlyPayment)
        {
            if (principal < 0.0m)
            {
                throw new ArgumentException("principal must be positive","principal");
            }
            if (interestRate < 0.0m)
            {
                throw new ArgumentException("interest rate must be positive","interestRate");
            }
            if (monthlyPayment < 0.0m)
            {
                throw new ArgumentException("monthly payment must be positive","monthlyPayment");
            }
            if (monthlyPayment <= principal*interestRate / 1200)
            {
                throw new ArgumentException("monthly payment must cover interest","monthlyPayment");
            }

            int totalMonths = 0;
            decimal currentPrincipal = principal;

            while (0.0m < currentPrincipal)
            {
                // Those is the Formulas for calculations;
                decimal currentInterest = currentPrincipal * interestRate / 1200;
                decimal reduction = monthlyPayment - currentInterest;
                //Insurtion
                //   Debug.Assert(reduction > 0.0m);

                currentPrincipal = currentPrincipal - monthlyPayment;
                totalMonths += 1;

            }
            return totalMonths;
        }


        #endregion PayoffMonths Function
                #endregion Logic

    }
}
