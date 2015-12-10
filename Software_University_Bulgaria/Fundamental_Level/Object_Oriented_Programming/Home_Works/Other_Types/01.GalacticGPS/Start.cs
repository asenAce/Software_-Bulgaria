using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GalacticGPS
{
    class Start
    {
        static void Main(string[] args)
        {

            Location home = new Location(18.037986,28.870097,Planets.Earth);
            Location bigPlanet = new Location(45.045588, 45.045599, Planets.Saturn);
            Location smallPlanet = new Location(45.045533, 45.045501,Planets.Uranus);


            Console.WriteLine(home);
            Console.WriteLine(bigPlanet);
        }
    }
}
