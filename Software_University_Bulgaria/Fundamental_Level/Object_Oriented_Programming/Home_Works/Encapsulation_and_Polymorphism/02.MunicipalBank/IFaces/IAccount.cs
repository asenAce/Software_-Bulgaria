using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MunicipalBank.IFaces
{
    interface IAccount
    {
        ICustomer Customer { get; set; }

        decimal balance;
        decimal monthlyInterestRate;
        decimal calculateInterest; 

        public decimal Balance { get;  }
        public decimal MonthlyInterestRate { get; }

        decimal CalculateInterest(int periodInMonths);

        

    }
}
