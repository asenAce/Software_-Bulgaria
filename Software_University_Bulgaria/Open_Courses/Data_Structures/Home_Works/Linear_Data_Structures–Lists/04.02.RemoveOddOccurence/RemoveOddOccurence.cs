using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02.RemoveOddOccurence
{
    class RemoveOddOccurence
    {
        // Programe with Dictionary

        static void Main(string[] args)
        {

            // The Input
            Dictionary<int, int> allOccurences = new Dictionary<int, int>();

            string input = Console.ReadLine();
            string[] inputStr = input.Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries);


            // The Logic
            //  allOccurences = Task05OccurencesCountClass.GetOccurences(inputStr);

            StringBuilder sb = new StringBuilder();

            foreach (var key in allOccurences.Keys)
            {
                if (allOccurences[key] %2 !=0)
                {
                    continue;
                }

                for (int i = 0; i < allOccurences[key]; i++)
                {
                    sb.Append(key);
                    sb.Append(" ");
                }
                
            }

            //The Output

            Console.WriteLine(sb.ToString());

        }
    }
}
