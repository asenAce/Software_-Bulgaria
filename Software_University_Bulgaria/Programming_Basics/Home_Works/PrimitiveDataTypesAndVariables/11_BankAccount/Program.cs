using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccount 
{
    class Program : BankAccounts
    {
        /**
         * For this task i wish to use basic principals of Object Oriented Programming such as Inheritance,Polymorphisum.
         * In class  BankAccounts in the project i am declaring variables such as age, string FirstName,MiddleName,LastName
         * string CardHolderName with formatting concatination string,some of the variables are constant like the name of the bank which the bank 
         * wont change any time soon ,that's   why i decided to declare them like CONSTANT_VARIABLES. The idea is by using OOP Inheritance to use the major haracteristics of
         * a bank account by also to be able to override to add special characteristics for each of the accounts.Also i will create some 
         * functionality/ methods to the classes.
         * */
        static void Main(string[] args)
        {
            string firstName =  "Asen";
            string middleName = "Petrow";
            string lastName =   "Lozanov";
            string accountHolderName = string.Format("Holder name is {0} {1} {2}", firstName, middleName, lastName);
            // Or with concatination of a stirng
            // string accountHolderName = firstName + "  " + middleName + "  " +lastName; 
            int age = 25;
            char currency = '\u0024'; //  Unicode character for dollar sign $

            

            BankAccounts CreditCardBronze = new BankAccounts();    //  Instantiate  Objects.three bankAccounts
            BankAccounts CreditCardSilver = new BankAccounts();
            BankAccounts CreditCardGold =   new BankAccounts();

            //Now we define the characteristics of the bankAccount in the class and when we write the type of the account
            //for example CreditCardBronze.(and here we can see all the characteristics of an account like accountHolderName or currency. ) 
            
            CreditCardBronze.accountHolderName();
            CreditCardBronze.age();
            CreditCardBronze.amount();
            CreditCardBronze.currency();
            CreditCardBronze.deposit(); 
            // Invoce / call the method / Function with the name balance  situated in BankAccounts class file.
            CreditCardBronze.balance();      
            CreditCardBronze.transAction(); 


            //Be able to take the value from the console,i am trying to convert numeral input,so the client to deposit his amount by him self.
            string deposit = Console.ReadLine()
                int number = int.Parse(deposit);
                

            //Show the information on the console!
            Console.WriteLine(accountHolderName);   //About the cardHolder
            Console.WriteLine(age);                 //About the age of the cardHolder!
            Console.Read();     //Hold the console so we can read it!

        }
           
    }
}
