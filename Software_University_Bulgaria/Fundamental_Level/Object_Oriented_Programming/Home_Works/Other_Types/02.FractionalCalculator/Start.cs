using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FractionalCalculator
{
    class Start
    {
        static void Main()
        {
             

            try
            {
                var fractionOne = new Fraction(22,7);
                var fractionTwo = new Fraction(40, 7);

                 

               var result = fractionOne + fractionTwo;

               Console.WriteLine(result.Numerator);
               Console.WriteLine(result.Denominator);
               Console.WriteLine(result);

               var fractionOnTheLimit = new Fraction(long.MaxValue, 2);
               var resultTwo = fractionOnTheLimit + fractionOne;

            }       // when??
            catch (Exception ex) when (ex is ArgumentOutOfRangeException || ex is ArgumentException || ex is InvalidOperationException)
            {
                
               Console.WriteLine(ex.Message);
            }

        }
    }
}
