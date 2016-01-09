using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//From C# EBOOK nACOW p.177

namespace ConcatinationOfThreeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 07

            Console.WriteLine("Please enter your name.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello {0}{1}",firstName,lastName);


            //Example 06

            DateTime d = new DateTime(2009,10,23,15,30,22);
            Console.WriteLine("  {0: dd/MM/yyyy HH:mm:ss} ",d);
            Console.WriteLine(" {0: d.MM.yy g.}" , d);
            Console.Read();

            //Example 05.

            string name = "Boris";
            int ageThree = 18;
            string town = "Plovdiv";
            Console.Write("{0} is {1} years old from {2} !\n",name,ageThree,town);
            // The command said console display this string "".WriteLine is a method of Console and Console is a object!
            //{0} on zero possition place variable name separeted with , next possition is {1} with variable ageThree
            //This is so called placeholder.
            Console.Read();


            //Example 04.
            string str = "Hello world !";

            //Print (the normal way)
            Console.Write(str);

            //Print (through formatting string)
            Console.Write("{0}", str);  // {0} it is called a placeholder and 0 specifay the possition which must replaced in this case the command said put variable str on 0-ro possition.
            // The result Hello world !Hello world !


            //Example 03.
            string s = "Four:  " +2+2;
            Console.WriteLine(s);
            Console.Read();
            // Four :22

            string s1 = " Four: "+ (2+2);
            Console.WriteLine(s1);
            Console.Read();
            // Four : 4


            int ageTwo = 26;
            string textTwo = "He is " + ageTwo + " years old . ";
            Console.WriteLine(textTwo);
            Console.Read();


            string age = "twenty six";
            string text = " He is "+ age + "  years old. "; // Concatination 
            Console.WriteLine(text);
            Console.Read();
        }
    }
}
