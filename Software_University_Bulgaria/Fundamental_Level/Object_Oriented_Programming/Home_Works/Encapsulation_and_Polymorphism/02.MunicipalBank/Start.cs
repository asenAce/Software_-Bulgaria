using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.MunicipalBank.Customers;
using _02.MunicipalBank.BankAccounts;
using _02.MunicipalBank.IFaces;


namespace _02.MunicipalBank
{
    class Start
    {
        static void Main(string[] args)
        {
            IAccount[] accounts = 
            {
                new DepositAccount(new Customer("First Name ",CustomerType.Individual), 1050.25m,0.0055m),
                new LoanAccount(new Customer("Company Name",CustomerType.Company), -10000,0.0005m),
                new MortgageAccount(new Customer("First Name",CustomerType.Individual), -50000,0.0030m),
                new DepositAccount(new Customer("Company name",CustomerType.Company), 30000,0.0020m)

            };

            // Console

            Console.WriteLine("12 - months interest on a deposit account (balance: {0:c2},rate: {1:f3}%) : interest: {2:c2}"
                ,accounts[0].Balance
                ,accounts[0].MonthlyInterestRate * 100
                ,accounts[0].CalculateInterest(12));

            Console.WriteLine("3 - months interest on a loan account (balance: {0:c2},rate: {1:f3}%) : interest: {2:c2}"
                , accounts[1].Balance
                , accounts[1].MonthlyInterestRate * 100
                , accounts[1].CalculateInterest(3));

            Console.WriteLine("15 - months interest on a mortgage account (balance: {0:c2},rate: {1:f3}%) : interest: {2:c2}"
                , accounts[2].Balance
                , accounts[2].MonthlyInterestRate * 100
                , accounts[2].CalculateInterest(15));

            Console.WriteLine("24 - months interest on a deposit account (balance: {0:c2},rate: {1:f3}%) : interest: {2:c2}"
                , accounts[3].Balance
                , accounts[3].MonthlyInterestRate * 100
                , accounts[3].CalculateInterest(24));

        }
    }
}
