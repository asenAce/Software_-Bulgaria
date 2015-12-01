using _02.MunicipalBank.IFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MunicipalBank.BankAccounts
{
   abstract  class BankAccount : IAccount , IDepositable
    {

       private ICustomer customer;
       private decimal monthlyInterestRate;


       protected BankAccount(ICustomer customer,decimal balance,decimal monthlyInterestRate)
       {
           this.Customer = customer;
           this.Balance = balance;
           this.MonthlyInterestRate = monthlyInterestRate;

       }


       public ICustomer Customer 
       {
           get
           {
               return this.customer; 
           }
           set
           {
               if (value == null)
               {
                   throw new ArgumentNullException("customer","Incorrect");
               }

               this.customer = value;
           }
       }

       public decimal MonthlyInterestRate  
       {
           get
           {
               return this.monthlyInterestRate;
           }
           set
           {
               if (value < 0 )
               {
                   throw new ArgumentOutOfRangeException("monthly Interest Rate","Incorrect");
               }

               this.monthlyInterestRate = value;
           }
       }

       public decimal Balance 
       {
           get;
           protected set;
       }

       public virtual decimal CalculateInterest(int periodInMonths)
       {
           decimal resultInterest;
           resultInterest = this.Balance * (1 + (this.MonthlyInterestRate * periodInMonths));
           return resultInterest;

       }

       public void DepositAmountToAccount(decimal amountToDeposit)
       {

           this.Balance = Balance + amountToDeposit;
       }



    }
}
