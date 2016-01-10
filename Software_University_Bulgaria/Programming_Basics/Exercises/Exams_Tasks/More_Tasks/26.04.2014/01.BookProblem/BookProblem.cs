using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BookProblem
{
    /**
     * Stefan is a keen reader. He wants to read a programming book and wants to know exactly when he will finish it.
Every day in a given month he reads up some pages. Some days he goes camping and on these days he doesn’t read.
You will be given the book’s page count, the number of camping days in a month and number of pages which Stefan reads in a normal day, each on a separate line. Assume each month has 30 days and each year has 12 months. Calculate how many years and months Stefan will need in order to read the book and print the result on the console in format “X years Y months”. If Stefan never reads the book, print “never”.
Note that if, for example, Stefan needs 3.1 months, you need to round that up – so you have to print “0 years 4 months”. 
Input
The input will be read from the console. It consists of exactly three lines:
On the first line you will be given an integer – the number of pages of the book.
On the second line you will be given the number of camping days in a month.
On the third line you will be given the number of pages which Stefan reads every normal day.  
The input will always be valid and in the format described, there is no need to check it explicitly.
Output
The output should be printed on the console.
On the only output line print the number of years and months Stefan will need to read the book in format “X years Y months”.
If Stefan cannot read the book, you should print “never”.
Constraints
The number of pages of the book will be an integer in the range [1 … 2 000 000 000].
The number of camping days will be an integer in the range [0 … 30].
The number of pages Stefan reads in a normal day will be an integer in the range [0 … 100].
Allowed working time: 0.1 seconds. Allowed memory: 16 MB.
     * 
     * 
     * */


    class BookProblem
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int campDays = int.Parse(Console.ReadLine());
            int regularDays=int.Parse(Console.ReadLine());

            //Pages read for month
            int pagesReadNormaly = (30- campDays)*regularDays;

            if ((campDays == 30) || (regularDays == 0))
            {
                Console.WriteLine("never");
            }

            else
            {
                double months = 0;

                months = Math.Ceiling(bookPages/(double)pagesReadNormaly);
                int years = (int)(months/12);
                months = months % 12;

                Console.WriteLine("{0} years {1} months", years,(int)months);
            }





        }
    }
}
