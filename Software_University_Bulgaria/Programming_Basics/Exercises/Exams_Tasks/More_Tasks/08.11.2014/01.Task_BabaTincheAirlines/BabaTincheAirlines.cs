using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Task_BabaTincheAirlines
{
    /*
     * Every month Baba Tinche travels to the Republic of Tajikistan to meet her boyfriend. But the tickets are so expensive that she decides to establish her own airline instead called Baba Tinche Airlines. There are three travel classes in Baba Tinche Airlines:
First Class which accommodates 12 passengers. The ticket price is $7000.
Business Class which accommodates 28 passengers. The ticket price is $3500.
Economy Class which accommodates 50 passengers. The ticket price is $1000.
Please note that some passengers are Frequent Flyers and their tickets are 70% off ($1000 ticket will cost $300). Also some passengers purchase a meal on the flight, which costs 0.5% of the ticket price for the travel class they are in. Please help Baba Tinche calculate her income and calculate the difference between her income and the maximum possible income (the maximum possible income being all seats taken, no Frequent Flyers and everyone purchasing meals). You will be given the number of passengers for each class, the number of passengers who are Frequent Flyers in that class, and the number of passengers who purchase a meal in that class.

     * Input
     * 
The input data should be read from the console. It consists of exactly 3 lines:
The first line holds the number of all passengers in First Class
The second line holds the number of all passengers in Business Class
The third line holds the number of all passengers in Economy Class
The second and third number on all lines will be the number of Frequent Flyers and the number of passengers who will purchase a meal in the given class.
The input data will always be valid and in the format described. There is no need to check it explicitly.

     * Output
     * 
The output should be printed on the console. It should consist of exactly 2 lines.
The first line will  hold Baba Tinche’s income cast to an integer
The second line holding the difference between the maximum possible profit and baba Tinche’s actual profit cast to an integer

     * Constraints
     * 
The first number in the first line will be in the range [0…12]. 
The first number in the second line will be in the range [0…28]. 
The first number in the third line will be in the range [0…50]. 
The second and third numbers on all lines will be less or equal to the first number.
Allowed memory: 16 MB. Allowed working time: 0.25 seconds.

     * 
     * */

    class BabaTincheAirlines
    {
        static void Main(string[] args)
        {
            // input

            const int maxIncome = 233160;
            // First class is the Economy class

            string[] firstClassInfo = Console.ReadLine().Split();
            
            int firstClassPassengers = int.Parse(firstClassInfo[0]);
            int firstClassFrequent = int.Parse(firstClassInfo[1]);
            int firstClassMeals = int.Parse(firstClassInfo[2]);

            //Second class is , [] massive where the programe store the info .Split is a method of Console.ReadLine() that split the info
            // so the programe store it more easily () attach an empty parameters ()....
            
            string[] secondClassInfo = Console.ReadLine().Split();

            int secondClassPassengers = int.Parse(secondClassInfo[0]);
            int secondClassFrequent = int.Parse(secondClassInfo[1]);
            int secondClassMeals = int.Parse(secondClassInfo[2]);

            //The third class is the business class
            string[] thirdClassInfo = Console.ReadLine().Split();

            int thirdClassPassengers = int.Parse(thirdClassInfo[0]);
            int thirdClassFrequent = int.Parse(thirdClassInfo[1]);
            int thirdClassMeals = int.Parse(thirdClassInfo[2]);


            // logic

            decimal income = 0m ;

            //Declaring the Formulas:
            income += (firstClassPassengers - firstClassFrequent) * 7000;
            income += firstClassFrequent * 7000 * 0.3m;  // This is 30%
            income += firstClassMeals * 7000 * 0.005m;   // This is a 0.05%


            income += (secondClassPassengers - secondClassFrequent) * 3500;
            income += secondClassFrequent * 3500 * 0.3m;  // This is 30%
            income += secondClassMeals * 3500 * 0.005m;


            income += (thirdClassPassengers - thirdClassFrequent) * 1000;
            income += thirdClassFrequent * 1000 * 0.3m;  // This is 30%
            income += thirdClassMeals * 1000 * 0.005m;

            // Output

            int result = (int)income;
            Console.WriteLine(result);
            Console.WriteLine(maxIncome - result);

        }
    }
}
