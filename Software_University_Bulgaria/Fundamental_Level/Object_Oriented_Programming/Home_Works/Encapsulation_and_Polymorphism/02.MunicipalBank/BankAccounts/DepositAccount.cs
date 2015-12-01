using _02.MunicipalBank.IFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MunicipalBank.BankAccounts
{
    class DepositAccount : BankAccount , IWithdrawable
    {
        public DepositAccount(ICustomer customer,decimal balance,decimal monthlyInterestRate)
            :base(customer,balance,monthlyInterestRate)
        {

        }

        public void WithdrawMoneyFromAccount(decimal amountToWithdraw)
        {
            this.Balance = Balance - amountToWithdraw;

        }


        public override decimal CalculateInterest(int periodInMonths)
        {
            decimal resultInterest;

            if (0 < this.Balance && this.Balance < 1000)
            {
                resultInterest = base.CalculateInterest(0);
            }

            else
            {
                resultInterest = base.CalculateInterest(periodInMonths);
            }

            return resultInterest;
        }

    }
}
