using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccount
{
    class CreditCardSilver : BankAccounts // Inharited the BankAccounts
    {
        // Declarin my private variables
        private int monthlyQuota;
        private int transactionCount;
        private double fee;

        //Creating a new creditCard account
        public CreditCardSilver(double initDeposit,int trans,double fee)
        {
            super(initDeposit);
            setMonthlyQuota(trans);
            setFee(fee);
        }
        // Override the BankAccount's withdrawFunds polymorphisum
        public double withdraw(double amount)
        {
            transactionCount++;
            return super.withdraw(amount);
        }
        //access fee if went over!
        public void accessFee()
        {
            int extra = getTransactionCount() - getMonthlyQuota(); // Formula for calculating
            if(extra>0)
            {
                double total_fee = extra * fee();
                double balance = getBalance() - total_fee;
                setBalance(balance);
            }
            transactionCount = 0;
        }
        public double fee()
        {
            return fee;
        }
        public void setFee(double fee)
        {

        }
        public int getMonthlyQuota(int quota)
        {
            return monthlyQuota;
        }
        public void setMonthlyQuota(int quota)
        {
            monthlyQuota = quota;
        }
        public int getTransactionCount()
        {
            return transactionCount;
        }

    }
}
