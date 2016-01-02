using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Flowcontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            //The good the bed and the Ugly , input logic and output
            #region The Input
            Console.WriteLine("Your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your name? ");
            string name = Console.ReadLine();

            #endregion The Input

            #region The Logic
            string pass = age > 24 ? "pass" : "nopass";

            switch (name)
            {
                case "Scott":
                    ServeSoda();
                    break;
                case "Alan":
                    ServeWhisky();
                    break;
                case "Asen":
                case "Jonny":
                    ServeWhisky();
                    ServeSoda();
                    break;
                default:
                    ServeMilk();
                    break;
            }


            if (age <= 2)
            {
                if (name == "Asen")
                {
                    Console.WriteLine("Serve beer Galahar");
                   
                }
                ServeMilk();
            }

            else if (age < 21)
            {
                ServeSoda();   
            }

            else
            {
                ServeWhisky();
            }

            #endregion The Logic
        }

        #region The Functions
        private static void ServeWhisky()
        {
           /** Console.WriteLine("With Ice or without?");

            char y = Console.ReadKey().KeyChar;
            char n = Console.ReadKey().KeyChar;
            **/
            throw new NotImplementedException();
        }

        private static void ServeSoda()
        {
            throw new NotImplementedException();
        }

        private static void ServeMilk()
        {
            throw new NotImplementedException();
        }

        #endregion The Functions
    }
}
