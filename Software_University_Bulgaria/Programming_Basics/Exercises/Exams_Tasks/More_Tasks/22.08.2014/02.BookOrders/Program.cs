using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BookOrders
{
    /*
     *Bai NakMan has his own book store business. He often makes orders for new books, but the procedure is kind of complicated. You will be given the number of orders N. Each order holds, number of packets, amount of books per packet and price per book. Depending on the number of packets, you get different discount ranging from 5% to 15%.  If the packets in the order are less than 10, there is no discount. Otherwise they have the following discounts (10-19 packets = 5% discount, 20-29 = 6%, 30-39 = 7%, ..., 100-109 = 14%). If the packets are 110 or more, there is 15% discount for all books. Your task is to sum how many books Bai NakMan has bought and the end price of all books. Check the examples below to understand your task better.
Input
The input data should be read from the console.
At the first line you will be given integer number N representing the number or orders.
At the next 3*N lines you will be given the following inputs:
Book price
Number of packets
Books per packet
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It should consist of exactly 2 lines:
On the first line print the amount of all bought books
On the second line print the price of all books bough, rounded to the second number after the decimal point
Constraints
The number of orders, packets and books per packet will all be integers in range [0…10000].
The book price will always be a floating-point number in range [±5.0 × 10-324 … ±1.7 × 10308].
Allowed working time for your program: 0.1 seconds.
Allowed memory: 16 MB.
 
     * 
     * */

    class Program
    {
        static void Main(string[] args)
        {
            //input

            int orders = int.Parse(Console.ReadLine());
            int totalBooks = 0;


            double totalPrice = 0.0;


            for (int i = 0; i < orders; i++)
            {
                int packets = int.Parse(Console.ReadLine());
                int booksPerPacket = int.Parse(Console.ReadLine());
                double price = double.Parse(Console.ReadLine());

                int allbooks = packets * booksPerPacket;
                totalBooks += allbooks;
                double discount =0.0;

                if (packets >= 10 && packets <= 19)
                {
                    discount = 0.05; // in the range between 10 and 19 packets the client get a 5%  discount 0.05 with type decimal is 
                    // how the programe calculate the discount.
                }
                else if (packets >= 20 && packets <=29)
                {
                    discount = 0.06;
                }
                else if (packets >= 30 && packets<= 39)
                {
                    discount = 0.07;
                }
                else if (packets >= 40 && packets<=49)
                {
                    discount = 0.08;
                }
                else if (packets >= 50 && packets<=59)
                {
                    discount = 0.09;
                }
                else if (packets >= 60 && packets <= 69)
                {
                    discount = 0.10;
                }
                else if (packets >= 70 && packets <=79)
                {
                    discount = 0.11;
                }
                else if (packets >=80 && packets <= 89)
                {
                    discount = 0.12;
                }
                else if (packets >= 90 && packets <=99)
                {
                    discount = 0.13;
                }
                else if (packets >= 100 && packets <= 109)
                {
                    discount = 0.14;
                }
                else if( packets >= 110)
                {
                    discount = 0.15;
                }

                double finalPrice = (price * allbooks) - ((allbooks * price)* discount);
                totalPrice += finalPrice;


            }

            //logic


            //output
            Console.WriteLine(totalBooks);
            Console.WriteLine("{0:F2}",totalPrice);


        }
    }
}
