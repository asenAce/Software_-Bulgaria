using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThreeExceptionSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 32;
            object objValue = intValue;
            string strValue;

            try
            {
                strValue = (string)objValue;
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
