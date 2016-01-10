using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Headphones
{
    /**
     * Stamat really loves all kinds of music. He listens to music all the time. He even dreams of it. One day he decided to start programming. The only way he can write code is while listening to music (and singing… and even dancing). 
Your task is to help Stamat write a program that prints his headphones on the console using only 
     * asterisks '*' and dashes '-'. And since his headphones are very special they have a diameter. 
     * See the example below to better understand how the diameter affects the headphones' size.
     * 
     * Input:
     * 
The input data consists of only 1 line: the diameter of Stamat's headphones.
Output
The output data should be printed on the console.
     * 
       Constraints:
     * 
The diameter of Stamat's headphones will always be an odd number in the range [3..29].
Allowed work time: 0.1 seconds.
Allowed memory: 16 MB.

     * 
     * */


    class Program
    {
        static void Main(string[] args)

        {
            //Divided to three moduls.the image 
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}",new string ('-',(n-1)/2),new string('*',n+2)); //The red part of the image

            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string ('-',(n-1)/2),new string('-',n));
            }


            for (int i = 0,count = 0; i < n; i++)  //Instantiate a thirth variable count assign a value 0;
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string ('-',((n-1)/2)- count),
                    new string('*',1+2 * count),
                    new string('-',n - 2 * count));

                if (i < n/2)    //this indicated if the programe is in the middle of the loop NB!
                {
                    count++; 
                }
                else
                {
                    count--;
                }
                
            }

        }
    }
}
