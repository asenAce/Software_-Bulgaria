using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            //Notice that this is overcomplicated. Streamline:

            while (true)
            {
                Console.WriteLine("What is your name? ");
                name = Console.ReadLine();

                if (name.Length != 0 )
                {
                    break;
                }
                Console.WriteLine("This is not a name!");
            }

            Console.WriteLine("Hello, {0}",name);
            Console.WriteLine("Hello, {0}",name);


            // The age


            int age;
            while (true)
            {
                Console.WriteLine("How old you are");
                string inPut = Console.ReadLine();

                bool isSuccess = int.TryParse(inPut,out age);
                if (isSuccess)
                { 
                    break;
                    
                }
                Console.WriteLine("{0} is not an age!", inPut);
            }
            Console.WriteLine("{0} is the age ",age);
             
        }
    }
}
