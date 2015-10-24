using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccount
{
    public class BankAccounts     
        //Declaring my member variables! the information in this class will be basic , so i can use it with enxaretence.
        //I am declaring the variables here by asign a value in the main().
    {
        public   string firstName;
        public   string middleName;
        public   string lastName;
        public   string accountHolderName;
        public const string BANK_NAME = "UnitedBanks";    // declaring a CONSTANT_VARIABLE
        public const string BANK_IBAN = "UN_BG90864563VR";
        private const string BANK_HEADOFFICE = "City of Varna";
        public char currency;  // be able to show one of the major characteristic of a bank account in wich currency is the account,and show the information on the console.
        public int age;        // The age of the cardHolder.
        private double balance; // Very important this information show how much money are in the each account.
        public double  amount;
        public decimal deposit;
        public double withDraw;

        // I am creating a construcor!
            public BankAccounts(double initDeposit)
            {
                setBalance(initDeposit);
            }
        // Depositing founds
            public void depositFunds(double amount)
            {
                setBalance(getBalance() + amount );
            }

        public string accountHolderName()
        {
            Console.WriteLine("");
        }

        

        public void  currency()    //This method  calculate the dayly currency rate from Euro to $
        {

        }
        
        

        public void  amount()
        {

        }

        public int age      // Indentefai the Age of the cardHolder!
        {
            get 
            { 
                return this.age;
            }
            set
            {
                if(value <0)     // Never trust the user!
                {
                    Console.WriteLine("Your age can not be a negative number!");
                }
                else
                {
                    this.age = value;
                }
            }

        }

        // A query
        public double getBalance()
        {
            return balance;
        }

        //set balance
        protected void setBalance(double newBalance)
        {
            balance = newBalance;
        }



        // the first method/Function that each of the bankAccount must be able to perform is the possibilieties
        //the client to be able to deposit some money.

        public void  deposit()
        {

        }

        public double withDraw(double amount)
        {
            if(amount >= balance)
            {
                amount = balance;
            }
            setBalance(getBalance() - amount);
            return amount;
        }
        
        public void balance(double)  // This method / Function is from returning type.
        {
            double balance = amount -  withDraw;
            return balance;
        }

        public void closeTheAccoutn()
        {

        }
        
        public void transAction()
        {

        }

        public void overDraft()
        {

        }

        public void bankPenalty()
        {

        }
        
        public void bankInterest()
        {

        }




    }
}
