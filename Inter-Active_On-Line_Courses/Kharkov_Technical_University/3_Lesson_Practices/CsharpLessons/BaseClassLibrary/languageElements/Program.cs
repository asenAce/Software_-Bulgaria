using System;
using System.Collections.Generic;       //Those  are the libraries where the methods are written!
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace languageElements
{
    class Program
    {
        static void Main(string[] args)     // The beggining of the program!
        {
            concatenate("Asen ", "Last");

        }
     
    static void concatenate(string first, string last)      //Creating a Fx Functions (the arguments)
            // public is the access modifier, which means can be access form everywhere!    
    {           //concatenate means we combine two strings  
            string whole = first +  last;
            Console.WriteLine(whole);                       // whole is a variable 
            Console.Read();    
    }

    }
}
