using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03.CheckForAPlayCard
{
    class Program
    {
        /**
         * Classical play cards use the following signs to 
         * designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a 
         * program that enters a string and prints “yes” if it is a valid card sign or “no” 
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("This programe designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints yes if it is a valid card sign or no ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Please choose a number of a Card :");
            int numberCard = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose card with letter: ");
            string letterNumber = Console.ReadLine();

            string j = "J";
            string q = "Q";
            string k = "K";
            string a = "A";


            switch (numberCard)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("YES");
                    break;
                default:
                    Console.WriteLine("Not a number!  ");
                    break;
            }

            if (letterNumber == j || letterNumber == q || letterNumber == k || letterNumber == a)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("It is not a card at all. ");
            }
            Console.ReadLine();
        }
    }
}
