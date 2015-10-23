using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive.cs
{
    class UniCodeCharacters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input");
            string input = Console.ReadLine();
             
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                result.Append( (c));
            }

            Console.WriteLine(result.ToString());

        }

        static string getUnicodeChar(char c)
        {
            return "\\u" + ((int)c).ToString("X").PadLeft(4, '0');
        }
    }
}
