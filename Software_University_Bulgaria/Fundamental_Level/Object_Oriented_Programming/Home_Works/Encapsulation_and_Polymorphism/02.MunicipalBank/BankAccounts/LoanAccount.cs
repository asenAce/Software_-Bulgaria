using _02.MunicipalBank.Customers;
using _02.MunicipalBank.IFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MunicipalBank.BankAccounts
{
    class LoanAccount : BankAccount
    {

        public LoanAccount(ICustomer customer,decimal balance,decimal monthlyInterestRate )
            : base(customer,balance,monthlyInterestRate)
        {

        }

        public override decimal CalculateInterest(int periodInMonths)
        {
            int monthsWithoutInterest = 0;
            int monthsWithInterest;
            decimal resultInterest;

            switch (this.Customer.CustomerType)
            {
                case CustomerType.Individual:
                    monthsWithoutInterest = 3;
                    break;
                case CustomerType.Company:
                    monthsWithoutInterest = 2;
                    break;
                
            }

            monthsWithInterest = Math.Max(0,periodInMonths - monthsWithoutInterest);
            resultInterest = base.CalculateInterest(monthsWithInterest);
            return resultInterest;


        }


    }
}
