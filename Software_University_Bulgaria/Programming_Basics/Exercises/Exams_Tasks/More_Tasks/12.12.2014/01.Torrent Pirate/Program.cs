using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Torrent_Pirate
{
    /*
     * Problem 1 – Torrent Pirate
Captain Jack Sparrow is a famous pirate. He loves to steal different stuff just for fun and he loves watching movies. He recently discovered a brand new technology called peer-to-peer or torrent. After he browsed a famous site, he made a collection of movies he would like to download. Assume 1 movie has a size of 1500MB. Jack doesn’t want to pay for the internet, so he decided to go to the mall and use the free Wi-Fi there. The Wi-Fi has a fixed speed of 2MB/s. Unfortunately for Jack, his wife will be going with him to the mall and this means that the download would not be free at all. She likes to buy sandals and other useless stuff. You are given the money his wife spends per hour at the mall.
Your task is to help Jack calculate whether it is cheaper to go to the mall and download the movies or go to the cinema to watch them. If the amount is the same, Jack still wants to make his wife happy, so he goes to the mall.
Input
The input data should be read from the console. It consists of three input values, each at a separate line:
Download data d: how much megabytes in total Jack should download.
Price of cinema p: how much money would cost Jack to go to the cinema to watch one movie.
Wife spending	 w: how much money per hour does Jack’s wife spend.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console.
On the only output line you must print “{place to go} -> {price to pay}lv”.
The price to pay should be formatted with 2 digits after the decimal sign.
Constraints
d is an integer number in range [0...2,147,483,647]. p is an integer number in range [0…30]. w is an integer number in range [0…200].
Allowed working time for your program: 0.25 seconds.
Allowed memory: 16 MB.
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {

            int downloadData = int.Parse(Console.ReadLine());
            int priceCinema = int.Parse(Console.ReadLine());
            double wifeSpending = double.Parse(Console.ReadLine());

            int movie = 1500;
            
            
            int seconds = 60;
            int minutes = 60;

            int fixInternetSpeed = 2;

            double DownLoadTime = (downloadData) / (fixInternetSpeed)/(seconds) /(minutes);
            

            double priceForDownloading = (DownLoadTime)*(wifeSpending);  // mall-->
             

            int theNumbersofMovies = (downloadData)/(movie);
            int  cinemaPrice= (theNumbersofMovies) * (priceCinema); //cinema-->

            if (priceForDownloading > cinemaPrice)
            {
                Console.WriteLine("the cost for downloading the movie is {0}.lv and the cost for going to cinema is {1}.lv",priceForDownloading,priceCinema);
                Console.WriteLine("cost mall {0}.lv > cost cinema {1}.lv",priceForDownloading,cinemaPrice);
            }
            else if (priceForDownloading < cinemaPrice)
            {
                Console.WriteLine("the cost for downloading the movie is {0}.lv and the cost for going to cinema is {1}.lv",cinemaPrice,priceForDownloading);
                Console.WriteLine("cost mall {0}.lv < cost cinema {1}.lv",priceForDownloading,cinemaPrice);
            }

            else
            {
                Console.WriteLine("The cost are equal {0}.lv = {1}.lv",priceForDownloading,cinemaPrice);
            }
            Console.ReadLine();
        }
    }
}
