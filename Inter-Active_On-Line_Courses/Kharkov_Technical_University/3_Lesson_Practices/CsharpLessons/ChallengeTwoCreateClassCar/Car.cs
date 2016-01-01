using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoCreateClassCar
{
    class Car
    {
        public string make;
        public string model;
        public string color;

        public void Drive()
        {
            Console.WriteLine("We are driving!");
          //  Console.Read();
        }

        public void Stop()      // Methods!
        {
            Console.WriteLine("Stopping!");
            Console.Read();
        }
    }
}
