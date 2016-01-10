using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChessboardGame
{
    /**
     * Goshko is a keen chess player. One day he was bored with his work and decided to take a break and 
     * create a game using the chessboard. He takes a string, e.g. "Software University_2345", 
     * converts its symbols to numbers through their ASCII codes and fills a chessboard with them. 
     * He takes the values of capital and small letters and digits only. The value of any other symbol is zero. 
     * He fills the board’s squares with the numbers, from left to right and from top to bottom (see the example below). 
     * The size of the chessboard is n*n (e.g. n = 5) and it always starts with a black square. N will always be an odd number.

     * Let’s assume that there are two competing teams: the black team and the white team. Every team’s score is the sum of the values in its squares. However if a square contains a capital letter its value should be given to the opposing team. In the example above the scores are calculated as follows:
White Team Score = 83 'S' + 111 'o' + 116 't' + 97 'a' + 101 'e' + 105 'i' + 101 'e' + 115 's' + 116 't' + 51 '3' + 53 '5' = 1049
Black Team Score = 102 'f' + 119 'w' + 114 'r' + 85 'U' + 110 'n' + 118 'v' + 114 'r' + 105 'i' + 121 'y' + 50 '2' + 52 '4' = 1090.
Input
The input data should be read from the console.
The first line holds the size n of the chessboard.
The second line holds the input string.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
The first output line holds the winning team in format: “The winner is: {name} team”.
The second line holds the difference between the scores of the winning and the losing team. 
In case the score is equal, print “Equal result: {points}”. Do not print the difference in this case!
Constraints
The number n will be an odd integer in the range [1 … 9].
Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

     * 
     * */

    class Program
    {
        static void Main(string[] args)
        {
            int boardSize = int.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();
            int cellsCount = boardSize * boardSize; // Formula for Squr Hight * Width


            if (cellsCount > inputString.Length)
            {
                string additionalCharacters = new string(' ', cellsCount - inputString.Length);

                inputString = inputString + additionalCharacters;
            }
            

            int blackTeamScore = 0; // Initially from Zero
            int whiteTeamScore = 0;

            

            for (int letter = 0; letter < cellsCount; letter++) // This is how we move whith in the border for cycle
            {
                char currentChar=inputString[letter]; //

                if ((currentChar>='a' && currentChar <='z') || (currentChar >='A' && currentChar<='Z')||(currentChar>='0' && currentChar<='9'))
                {
                    if (letter % 2 == 0) // Test for even number 
                    {
                        if ((currentChar >= 'A' && currentChar <= 'Z'))
                        {
                            whiteTeamScore += currentChar;
                        }
                        else
                        {
                            blackTeamScore += currentChar;
                        }
                    }
                    // else mean odd number , odd and even in this task mean black and white cubics.
                    else
                    {   //Testfo  r capital letters
                        if ((currentChar >= 'A' || currentChar <='Z'))
                        {
                            blackTeamScore += currentChar;
                        }
                        else
                        {
                            whiteTeamScore += currentChar;
                        }
                    }
                }
            }

            //Test who si the winner
            if ( blackTeamScore<whiteTeamScore)
            {
                Console.WriteLine("The winner is:White team ");
                Console.WriteLine("The score is : {0} ",(whiteTeamScore - blackTeamScore));
            }
            else if (blackTeamScore>whiteTeamScore)
            {
                Console.WriteLine("The winner is:Blck team ");
                Console.WriteLine("The score is : {0} ",(blackTeamScore-whiteTeamScore));
            }
            else
            {
                Console.WriteLine("Equal result {0}",blackTeamScore);
            }
        }
    }
}
