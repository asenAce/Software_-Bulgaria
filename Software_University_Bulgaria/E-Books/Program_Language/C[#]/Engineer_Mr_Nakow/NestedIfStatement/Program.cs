using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            int first = 5;
            int second = 3;

            if (first == second)
            {
                Console.WriteLine("Those two numbers are equal.");
            }
            else
            {
                if (first > second)
                {
                    Console.WriteLine(" The first number is greater .");
                }
                else
                {
                    Console.WriteLine("The second number is greater. ");
                }

                // a siquence of if else 

                char ch = 'A';
                if (ch == 'A' || ch == 'a')
                {
                    Console.WriteLine("Vowel [ei]");
                }
                else if (ch == 'E' || ch == 'e')
                {
                    Console.WriteLine("Vowel [i:]");
                }
                else if (ch == 'I' || ch == 'i')
                {
                    Console.WriteLine("Vowl [ai]");
                }
                else if (ch == 'O' || ch == 'o')
                {
                    Console.WriteLine("Vowel [ou]");
                }
                else if (ch == 'U' || ch == 'u')
                {
                    Console.WriteLine("Vowel [ju:]");
                }
                else
                {
                    Console.WriteLine("Consonant ");
                }
                Console.Read();
            }

        }
    }

}