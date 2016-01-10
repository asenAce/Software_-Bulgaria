using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingAMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            double colaPrice = 1.20;
            string cola = "Coca-Cola";
            double fantaPrice = 1.25;
            string fanta = "Fanta-Manta";
            double zagorkaPrice = 1.56;
            string zagorka = "Zagorka-Zatvorka";

            Console.WriteLine("Menu: ");
            Console.WriteLine("1. {0} - {1}", cola, colaPrice);
            Console.WriteLine("2. {0} - {1}", fanta, fantaPrice);
            Console.WriteLine("3. {0} - {1}", zagorka, zagorkaPrice);
            Console.WriteLine("We just want your money,and whea have a nice day :-)  ");
            Console.Read();

        }
    }
}
