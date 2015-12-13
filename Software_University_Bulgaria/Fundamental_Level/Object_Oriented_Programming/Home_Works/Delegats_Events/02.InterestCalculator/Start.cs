using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InterestCalculator
{
    class Start
    {
        static void Main()
        {
            // The original code from Phil Kolev do not work i make few changes i create an objects coumpoundInterest and  simpleInterest
            // which are calling the methods() GetTheCompoundInterestNow and GetTheSimpleInterestNow chenged also the class with 
            //empty constructor so no parameters are needed for creation of the two objects , but still do not work , ? how i can make decimals
            // works with int value in the code  i have two decimals and one int , namely years and they are involved in formulas for calculation
            // any feed backs will be appreciated, 

            TheInterestCalculator coumpoundInterest = new TheInterestCalculator();
            coumpoundInterest.GetTheCompoundInterestNow(500m, 0.056m, 10);
            Console.WriteLine(coumpoundInterest.AccruedInterest);
            coumpoundInterest.ToString(); 

            TheInterestCalculator simpleInterest = new TheInterestCalculator();
            simpleInterest.GetTheSimpleInterestNow(25000m,0.078m,15);
            Console.WriteLine(simpleInterest.AccruedInterest);


        }

       

         
    }
}
