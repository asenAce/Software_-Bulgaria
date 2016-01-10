using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            Console.Write(a);       //15

            double c = 15.5;
            int b = 14;
            //...

            Console.Write("{0} + {1} = {2}" , a,b,a + b);

            string str = "Hello C#"; 
            /**Exponesion first is the type which here is a string second, is ID idenefier with whom the program id the name
             *  thee the asign operator = give a value to the variable in this case is a string of characters written in the "" 
             *  ; state the end of the command
             * */
            Console.WriteLine(str);
            /**
             * Object Console has method called WriteLine which show data to the console in the () are the paramethers! ID 
             * and the programme write the value which is in the str ID , string of charachteres!
             * */

            string name = "Marry";
            int year = 1987;

            //....
            /**
             * in the "" we show position {0} and possition {1} out off the string we separeted with , and give 
             * orders to the programe what to put on those possitions in this case varables name and year ,name,years
             * */
            Console.WriteLine("{0} was born in {1}. ",name,year);

        }
    }
}
