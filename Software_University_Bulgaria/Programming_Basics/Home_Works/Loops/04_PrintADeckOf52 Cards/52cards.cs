
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04.PrintADeckOf52_Cards
{
    class Program
    {

        /**
         * Write a program that generates and prints all possible cards from a standard
         * deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

         * */
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;  //

            for (int card = 2; card <= 14;card++ )
            {
                for (int type = 3; type < 7;type++ )
                {
                    switch(card)
                    {
                        case 11:
                            Console.Write("{0,2}{1}",'J',(char)type);
                            break;
                            case 12:
                            Console.Write("{0,2}{1}",'Q',(char)type);
                            break;
                            case 13:
                            Console.Write("{0,2}{1}",'K',(char)type);
                            break;
                            case 14:
                            Console.Write("{0,2}{1}",'A',(char)type);
                            break;
                        default:
                            Console.Write("{0,2}{1}",card,(char)type);
                            break;
                    }
                    Console.WriteLine();
                    Console.ReadLine();
                }
            }
        }
    }
}
