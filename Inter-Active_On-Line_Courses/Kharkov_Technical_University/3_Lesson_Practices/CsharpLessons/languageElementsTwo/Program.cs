using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace languageElementsTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate ("First",   "Last");
            string word;
            word = Concatenate("First   "  , "Last");
            Console.WriteLine(word);
            Console.Read();
 

        }
        static string Concatenate(string first,string last )
        {
            string whole = first + last;
            return whole;       //If you return a value from the function you state return!
        }
    
    }

}
