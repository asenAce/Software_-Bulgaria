using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Convert
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("State youe name please");
            string  name = Console.ReadLine();
            Console.WriteLine("Hello {0} enter your first int",name);

            string firststring = Console.ReadLine();
            //    ﬁrst = Convert.ToInt32(ﬁrstString);
            int first = Convert.ToInt32(firststring);


            Console.WriteLine(string.Compare(firststring,name));
        }
    }
}
