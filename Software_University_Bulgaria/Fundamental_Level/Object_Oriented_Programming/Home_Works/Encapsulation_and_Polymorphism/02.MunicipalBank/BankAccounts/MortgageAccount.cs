using _02.MunicipalBank.IFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.MunicipalBank.Customers;
using _02.MunicipalBank.IFaces;

namespace _02.MunicipalBank.BankAccounts
{
    class MortgageAccount : BankAccount
    {

        public MortgageAccount(ICustomer customer,decimal balance,decimal monthlyInterestRate)
            : base(customer,balance,monthlyInterestRate)
        {


        }

        public override decimal CalculateInterest(int periodInMonths)
        {

            int monthsWithFullInterest;
            decimal resultInterest;

            switch (this.Customer.CustomerType)
            {
                case  CustomerType.Individual:
                    int monthsWithNoInterest = 6;
                    monthsWithFullInterest = Math.Max(0,periodInMonths - monthsWithNoInterest);
                    resultInterest = base.CalculateInterest(monthsWithFullInterest);
                    break;
                case  CustomerType.Company:
                    int monthsWithHalfInterest = 12;
                    resultInterest += this.Balance * (1 + (this.MonthlyInterestRate / 2 * periodInMonths)); // Problem!
                    monthsWithFullInterest = Math.Max(0, periodInMonths - monthsWithHalfInterest);
                    resultInterest += base.CalculateInterest(monthsWithFullInterest);
                    break;
               
            }

            return resultInterest;


        }
    }
}
