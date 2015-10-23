using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TaskFour.cs
{
    class SentenceExtractor
    {
        static void Main(string[] args)
        {

            Console.WriteLine("the word");
            string word = Console.ReadLine();

            Console.WriteLine("for Check");
            string toCheck = Console.ReadLine();

            Regex rgx = new Regex(@"(\w[^.!?]*)?(?i:\b"+ word + @"\b)[^.!?]*[.!?]");
            MatchCollection matches = rgx.Matches(toCheck);

            foreach (var item in matches)
            {
                Console.WriteLine(item);   
            }

        }

    }
}
