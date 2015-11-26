using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.PCCatalogue
{
    class Start
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");

            // Assigning the Video Cards
            Components mcardVLC = new Motherboard("VLC",(decimal)185.89);
            Components vcardRadeon = new GraphicCard("Radeon",(decimal)102.34,"onr of the best");
            Components vcardGeForce = new GraphicCard("GeForce",(decimal)156.89,"no good");

            // Assigning the Processors
            Components proIntel = new Processor("Intel",(decimal)347.667,"no bad");
            Components proAMD = new Processor("AMD",(decimal)405.239,"the best");

            // Computers
            Computer compAMDRadeon = new Computer("Fasty", new List<Components>() { mcardVLC,vcardRadeon,proAMD});
            Computer compIntelGeForce = new Computer("Star");

            compIntelGeForce.Components.Add(vcardGeForce);
            compIntelGeForce.Components.Add(mcardVLC);
           

            List<Computer> computers = new List<Computer>
            {
                compIntelGeForce,compAMDRadeon
            };

            computers.OrderBy(c => c.Price).ToList().ForEach(c => Console.WriteLine(c.ToString()));

            
        }
    }
}
