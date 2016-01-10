using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SpyHard
{

    /**
     * 
     * You are a handler. Your task is to relay messages between field operatives (spies), and headquarters (the CIA). The CIA developed a system; first, the operatives send coded messages to you, then you partially decrypt each message and relay it to headquarters where further decryption takes place. 
You will be given a key and a message. The key will be a number, it shows the base of the numeral system you’ll need to use for decryption. The message is comprised of various symbols which you convert to a number by adding together either the letter’s position in the alphabet (a = 1, b = 2, … , z = 26) if the symbol is a letter, or the symbol’s code in the ASCII table otherwise. After you get the sum of the symbols, you need to convert it to the numeral system provided by the key.
To headquarters you need to send a single string containing three numbers concatenated together; 
     * the first part will be the numeral system you used, next comes the number of symbols in the initial 
     * message and finally comes the partially decrypted message (a number in the specified numeral system). 
     * See the example below to get a clearer idea of the steps you need to take.
Input
The input data should be read from the console.
The first input line holds a number (the key).
The second input line holds a string (the message).
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
On the only output line you must print the code you’ll transmit to headquarters.
Constraints
The key will be a number between 2 and 10 inclusive.
The length of the message will be between 1 and 100 symbols.
Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

     * 
     * 
     * */

    class Program
    {
        static void Main(string[] args)
        {
            //Two variable reading from the Console.
            int numeralSystem = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            //initializate a start counter from o;
            int totalValue = 0;
            string  convertedValue = "";

            //for  loop the programe looping the element i in the range given by the Console. in the varable input wiht type string
            for (int i = 0; i < input.Length; i++)
            {
                //This block of code check is the input is a capital letter in the range from A to Z by ASCII table!
                if (input[i] >= 'A' && input[i] <= 'Z' )
                {
                    totalValue += input[i] - 64;
                }
                //This block of code check is the input is a small letter in the range a to z
                else if (input[i] >= 'a' && input[i]<= 'z') 
                {
                    totalValue += input[i] - 96; //ASCII Table
                }
                //if not is something else this part of the code handle this case
                else
                {
                    totalValue += input[i]; //Store the value in the input
                }

            }

            do
            {
                convertedValue += (totalValue % numeralSystem);
                totalValue /= numeralSystem;

            } while (totalValue != 0);

            Console.Write(numeralSystem.ToString()+input.Length);
            convertedValue.ToCharArray().Reverse().ToList().ForEach(c => Console.Write(c));
        
        }
    }
}
