using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation 
/**
 * TASK ,02 Print Company Information
 *A company has name, address, phone number, fax number, web site and manager.
 * The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company and its 
 * manager and prints it back on the console.
 * */
{
    class Program : infoCompanyAndManadger  // Inheratage infoCompanyAndManadger with : 
    {       // Can be includet try : catch logic
        static void Main(string[] args)
        {
            // Instantiate new objects manadger and company
            Company newCompany = new Company();
            Manadger newManadger = new Manadger();

            string showCompanyName = "\n The Company Name is :   ";
            string showCompanyAddress = "\n The Company Address is :  ";
            string showCompanyPhoneNumber = "\n The Company Phone Number is :  ";
            string showCompanyFaxNumber = "\n The Fax Number is :  ";
            string showCompanyWebSite = "\n The Company web site is :  ";

            string showManadgerFirstName = "\n The Manadger first name is : ";
            string showManadgerMiddleName = " \n The Manadger middle name is : ";
            string showManadgerLastName = "\n The Manadger last  name is : ";
            string showManadgerAge = "\n The age of the Manadger are :  ";
            string showManadgerPhoneNumber = "\n The Phone number of the manadger is :  ";

              const string THE_CREATOR = " created by ACE";

            Console.WriteLine("\n Please write your company name:  "); // OutPut
            newCompany.name = Console.ReadLine();       // InPut

            Console.WriteLine("\n Please write your company Address:  ");
            newCompany.address = Console.ReadLine();

            Console.WriteLine("\n Please write your company phone Number:  ");
            newCompany.phoneNumberOne = long.Parse(Console.ReadLine());
            
            /** I am trying to put some try catch logic in order the user not be able to put anything but letters,in case he put numbers and vai versa 
             * the program should promp a error message
            string errorMessage;

            try
            {
                phoneNumberOne(phoneNumberOne != long);
            }
            catch(OverflowException ofEx)
            { 
                  errorMessage = ofEx.Message;
                Console.WriteLine(errorMessage);
            }
            **/
            


            Console.WriteLine("\n Please write your company fax Numver:  ");
            newCompany.faxNumberOne = long.Parse(Console.ReadLine());


            Console.WriteLine("\n Please write you company's web site :  ");
            newCompany.webSite = Console.ReadLine();      

            Console.WriteLine("*************************************************************");

            Console.WriteLine("Please write your first name:  ");
            newManadger.firstName = Console.ReadLine();

            Console.WriteLine("Please write your middle name:   ");
            newManadger.middleName = Console.ReadLine();

            Console.WriteLine("Please write your last name:  ");
            newManadger.lastName = Console.ReadLine();

            Console.WriteLine("Please write your age:  ");
            newManadger.age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Please write your number :  ");
            newManadger.phoneNumberTwo = long.Parse(Console.ReadLine());



            Console.WriteLine("\n*******************This is the information regarding the Company ***************  {0}{1}{2}{3}{4}{5}{6}{7}{8}{9} ", showCompanyName,newCompany.name, showCompanyAddress, newCompany.address, 
                showCompanyPhoneNumber,newCompany.phoneNumberOne, showCompanyFaxNumber, newCompany.faxNumberOne, showCompanyWebSite, newCompany.webSite);          
            Console.WriteLine("\n*************Information regarding the Company Manadger************************* {0}{1}{2}{3}{4}{5}{6}{7}{8}{9}",showManadgerFirstName,newManadger.firstName,showManadgerMiddleName,newManadger.middleName, showManadgerLastName,newManadger.lastName,showManadgerAge,newManadger.age,showManadgerPhoneNumber, newManadger.phoneNumberTwo );
            
            Console.WriteLine("\nThank you for your time");
            Console.WriteLine(THE_CREATOR);
            Console.Read();
             

            

            
        }
    }
}
