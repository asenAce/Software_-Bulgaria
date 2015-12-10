using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace _02.FractionalCalculator
{
    struct Fraction
    {
        private const string DenominatorError = "The Denominator can not be a zero";
        private const string FractionError = "Fraction {0} out of range";

        private long numerator;
        private long denominator;
        double value;
        

        public Fraction(long numerator, long denominator)
            :this()
        {

            this.Numerator = numerator;
            this.Denominator = denominator;

        }
        

        public long Numerator 
        {
            get
            {
                return this.numerator;
            }
          private  set
            {
                this.numerator = value;
            }
        }
        public long Denominator 
        { 
            get
            {
                return this.denominator;
            }

         private   set
            {
                if (value == 0 )
                {
                    throw new DivideByZeroException(DenominatorError);
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            try
            {
                var newNumerator = checked((a.Numerator * b.Denominator) + (a.Denominator * b.Numerator));
                var newDenominator = checked(a.Denominator * b.Numerator);

                return new Fraction(newNumerator,newDenominator);

            }
            catch (OverflowException)
            {

                throw new InvalidOperationException(string.Format(FractionError, "Addition"));
            }

        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            try
            {
                var newNumerator = checked((a.Numerator * b.Denominator) + (a.Denominator * b.Numerator));
                var newDenominator = checked(a.Denominator * b.Denominator);

                return new Fraction(newNumerator, newDenominator);

            }
            catch (OverflowException)
            {

                throw new InvalidOperationException(string.Format(FractionError, "Addition"));
            }

        }

        public override string ToString()
        {
            return ((decimal)this.Numerator / this.Denominator).ToString(CultureInfo.InvariantCulture);

        }
        


       


    }
}
