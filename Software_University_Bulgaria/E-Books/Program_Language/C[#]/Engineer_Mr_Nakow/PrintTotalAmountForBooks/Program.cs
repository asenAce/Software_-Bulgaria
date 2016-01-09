using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTotalAmountForBooks
{
    class Program
    {
        static void PrintTotalAmountForBooks(decimal[]  prices)
        {
            decimal totalAmount = 0;
            
            foreach ( decimal singleBookPrice in prices)
            {
                totalAmount = totalAmount + singleBookPrice;
            }
            Console.WriteLine("The total amount of all books is:  "  + totalAmount);
        }


        static void Main(string[] args)
        {
            decimal[] prices = new decimal[] { 3m, 5m };
            PrintTotalAmountForBooks(prices);



        }
    }
}
