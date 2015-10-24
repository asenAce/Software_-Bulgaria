using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09.PlayWithIntDoubleAndString
{
    class Program
    {
        /**
         * Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends
         * "*" at the end. Print the result at the console. Use switch statement. 
         * */
        static void Main(string[] args)
        {
            byte chose; //declare variable chose,byte is type small number
            // variable chose play the role as a key 
            Console.WriteLine("Plese choose your  input");
            Console.WriteLine("1 --->int ");
            Console.WriteLine("2 --->double ");
            Console.WriteLine("3 --->string ");
            //  int chose = int.Parse(Console.ReadLine());
             //chose = byte.Parse(Console.ReadLine());
            byte.TryParse(Console.ReadLine(), out chose); // The diferent between tryParse and Parse is that try ,try to convert to number, more protective!
           //after that the value is stired in variable chose.
            switch (chose)  // () condition work with chose.
            {
                case 1:
                     Console.WriteLine("Please enter int:");
                    int i = int.Parse(Console.ReadLine());
                    Console.WriteLine(i+1);
                    break;
                case 2:
                    Console.WriteLine("Please enter double:");
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine(d+1.00);
                    break;
                case 3:
                    Console.WriteLine("Please enter string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine( str + "*");
                    break;
                default:        //Pay attention to close the switch logic
                    Console.WriteLine("Did your mom never taught you to pay attention to the messages! ");
                    break;
            }
            
            Console.ReadLine();

        }
    }
}
