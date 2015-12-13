using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InterestCalculator
{
    public delegate decimal InterestCalculator(decimal sum, decimal interest, int years); // CalculateInterest
    

    class TheInterestCalculator
    {
       // private readonly InterestCalculator interestdelegate;

        private decimal sum;
        private decimal interest;  //InterestRate
        private int years;
        private InterestCalculator calculationMethod;
        //  public decimal balance;
        private const int MONTHSINYEAR = 12;


        public TheInterestCalculator()
        {

        }

        public TheInterestCalculator(decimal sum, decimal interest, int years, InterestCalculator calculationMethod)
        {

            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.calculationMethod = calculationMethod;
            
           // this.Balance = moneyBalance;

        }

      //  public decimal  Balance { get; private set; }

        public decimal Sum 
        {
            get
            {
                return this.sum;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Incorrect");
                }
                 
                this.sum = value;
            }
        }
        public decimal Interest 
        {
            get
            {
                return this.interest;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Incorrect");
                }
                 
                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Incorrect");
                }
                this.years = value;
            }
        }

        public decimal AccruedInterest
        {
            get
            {
                return this.calculationMethod(this.Sum,this.Interest,this.Years);
            }
        }


        public   decimal GetTheSimpleInterestNow(decimal sum, decimal interest, int years)
        {
            decimal interestMultiplier;
            decimal balanceWithInterest;
            decimal theResultRoundit;

            interestMultiplier = 1 + (interest * years);
            balanceWithInterest = sum * interestMultiplier;

            theResultRoundit = decimal.Round(balanceWithInterest, 4);

            return theResultRoundit;
        }

        public   decimal GetTheCompoundInterestNow(decimal sum, decimal interest, int years)
        {
            decimal interestMultierBase;
            decimal interestMultiplier;
            decimal balanceWithInterest;
            decimal theResultRoundit;
            int interestMultierPower;

            interestMultierBase = 1 + (interest / MONTHSINYEAR);
            interestMultierPower = years * MONTHSINYEAR;
            interestMultiplier = 1;

            for (int i = 0; i < interestMultierPower; i++)
            {
                interestMultiplier = interestMultiplier * interestMultierBase;
            }

            balanceWithInterest = sum * interestMultiplier;

            theResultRoundit = decimal.Round(balanceWithInterest, 4);

            return theResultRoundit;

        }

    }
}
