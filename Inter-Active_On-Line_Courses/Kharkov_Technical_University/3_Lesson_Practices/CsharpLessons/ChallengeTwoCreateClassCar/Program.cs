using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoCreateClassCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();      // I am creating a new object called car! with the word NEW

            myCar.make = "Chevrolet";    // I am giving the values here of the variables!
            myCar.model = "Camaro";
            myCar.color = "black";

            myCar.Drive();      // i am calling the functions that i created previusly. () passing the arguments if we have any in the ();
            myCar.Stop();
        }
    }
}
