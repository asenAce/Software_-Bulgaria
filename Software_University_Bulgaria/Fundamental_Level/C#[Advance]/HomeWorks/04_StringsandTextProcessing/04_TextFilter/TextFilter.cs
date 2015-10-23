using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFour.cs
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("state the words");  // Promp the user
            string[] forbiddenWords = Console.ReadLine().Split(',');  // assign the values to the  array [] type string ID forbiddenWords

            // instantiated a string builder

            StringBuilder sb = new StringBuilder(Console.ReadLine());

            // iteration

            foreach (string str in forbiddenWords)
            {
                sb.Replace(str.Trim(),new string('*',str.Length));
            }


        }


    }
}
