
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RemoveOddOccurences
{
    class RemoveOddOccurences
    {
        static void Main()
        {
            //VID


            // The Input
            //*******************
            //Get the info from the user! store it in the variable ID input
            string input = Console.ReadLine();

            // Creating FIRST list  List<> of type int ID numbers.NB assign numbers = to variable input
            // using the Method .Split() empty parameters to separed and read the informaton from the user.
            //() method '' separed the info with empty space more Methods .Select 
            List<int> numbers = input.Split(' ').Select(s => int.Parse(s)).ToList<int>();
            // Creating SECOND list  List<> of type int ID numbers.
            List<int> removeList = new List<int>();
            // Creating THIRD list  List<> of type int ID numbers.
            List<int> keepList = new List<int>();

            //The Logic
            for (int i = 0; i < numbers.Count; i++)
            {
                int occurence = 1;

                if (keepList.Contains(numbers[i]))
                {
                    continue;
                }

                for (int k = 0; k < numbers.Count; k++)
                {
                    // This block of code detect the occurence numbers 5 == 5 appear in the first for possition[i] in the List<>
                    // numbers and in the possition [k] in the same List<> ID numbers
                    if (numbers[i] == numbers[k])
                    {
                        occurence++;
                    }
                }

                // This block of code chech if the number that occure on dividion on 2 is not = to 0 and not ...
                if (occurence % 2 != 0 && !removeList.Contains(numbers[i]))
                {
                    removeList.Add(numbers[i]);
                }
                
                // In the other case
                else
                {
                    keepList.Add(numbers[i]);
                }

                occurence = 1;

            }

            // Passt throw each of the elements in the removeList, element num

            foreach (var num in removeList)
            {
                if (numbers.Contains(num))
                {
                    numbers.RemoveAll(item => item == num);
                }
                
            }

            //The Output

            Console.WriteLine(string.Join(" ", numbers.ToList()));

        }
    }
}
