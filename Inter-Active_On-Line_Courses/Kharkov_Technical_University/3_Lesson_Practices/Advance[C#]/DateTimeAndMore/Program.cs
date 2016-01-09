using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace DateTimeAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(" Today is : " + today );
            DateTime tomorrow = today.AddDays(1);
            Console.WriteLine("Tomorrow will be : "  + tomorrow);

            double angleDegrees = 60;
            double angleRadians = angleDegrees * Math.PI / 180;
            Console.WriteLine(Math.Cos(angleRadians));

            Random rnd = new Random();
            Console.WriteLine(rnd.Next(1,100));

            WebClient webClient = new WebClient();

            // webClient.DownloadFile =  ("    "File.pdf);
            // Process.Start();


        }
    }
}
