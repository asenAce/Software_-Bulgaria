using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numerology
{

    /**
     * Numerology involves a lot of repeated calculations, but as a programmer you can automate this process and earn some easy cash! You will be given the birthdate and username of a random fellow student. Your task is to calculate a celestial number. Below is a description of the process, see the example to understand your task better.
First, multiply together the numbers representing the day, year and month of the birthdate. Numerologists love odd numbers, so if the month is an odd number, you should square the result of the multiplication. Next, add to the result each digit ('0' = 0, '1' = 1… '9' = 9) or the position in the English alphabet of each letter in the username – e.g. “a” = 1, “b” = 2… “z” = 26. Capital letters weigh twice as much - the letter “A” will add 1*2 to the sum, “Z” will add 2*26, etc. 
13 is a sacral number and your celestial number should be between 0 and 13 inclusive. So, if the resulting number is greater than 13 you should keep adding its digits together until you get the coveted celestial number in its final form. Then all you have to do is print it to the console! Whew! Numerology…

     * Input
     * 
The input data is read from the console. 
On the only input line you will be given a date in the format [day.month.year] and a username, separated by a single space.
The input data will always be valid and in the format described. There is no need to check it explicitly.

     * Output
     * 
The output data must be printed on the console.
On the only output line you must print the calculated celestial number.
Constraints
The date will be in format dd.mm.yyyy and between 01.01.1900 and 31.12.2014.
The username will be between 4 and 20 characters long and will contain only digits (0-9) and upper-case and lower-case letters from the English alphabet (no hyphens or non-English letters).
Time limit: 0.25 seconds. Allowed memory: 16 MB.

     * 
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            // Input

            string input = Console.ReadLine();
            // Create a masive. [] ID  userData 
            string [] userData =input.Split('.',' ');  // method .Split here has separetion with two symbols '.',' ' 


            // information from the user.
            int day = int.Parse(userData[0]);      // userData[0] possition 0.
            int month = int.Parse(userData[1]);    // userData[0] possition 1.
            int year = int.Parse(userData[2]);

            string userName = userData[3];

            long result = day * month * year;


            // Logic

            if (month % 2 != 0 )  // is not finnish on 0 means not even 
            {
                result *= result;  // num ^ 2 
            }

            foreach (var symbol in userName)  // The programe took the first symbol  in the string with ID  userName
            {
                if (symbol >= '0' && symbol <= '9')
                {
                    result += symbol - '0';
                    
                }

                else if (symbol >= 'a' && symbol <= 'z' )
                {
                    result += symbol - 'a' + 1;
                }

                else
                {
                    result += 2 *(symbol - 'A' + 1);
                }

                
            }

            while (result > 13)
            {
                int digitSum = 0;

                while (result > 0)
                {
                    digitSum += (int)(result % 10);
                    result /= 10;
                }

                result = digitSum;

            }



            // Output
            Console.WriteLine(result);
        }

        
    }
}
