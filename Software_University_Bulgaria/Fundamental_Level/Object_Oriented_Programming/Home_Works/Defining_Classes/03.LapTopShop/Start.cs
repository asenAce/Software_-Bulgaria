using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LapTopShop
{
    class Start
    {
        static void Main(string[] args)
        {
            // Defining the Battery 
            Battery lionLithy = new Battery("Li-Ion Premimum,4-cells,2550 mAh");
            Battery nickelLithy = new Battery("Ni-cd",(float)4.5);

            //Defining the Laptops 9 parameters , creating an Object laptop# with pre-defined parameters in the ctor/the Constructor 
            // in the class LapTop objects can be created only in the class everything is Objects,objects interact among themselves and this 
            // create a programe; the Constructor is like a biscuites cutter in the kitchen he make the forms from the dough as set the tast 
            //the form even the color but each biscuites is unique! More over a dish is consist of more than one biscuit there is a 
            // brown sugar ,glassing , a cherry on the top of the dessert/namely the dish,bluido/ and all of them are objects interact
            //in the plate by doing so  they give you diferent tasts and flavors enriching your Plateau namely creating a dish!
            LapTop laptopOne = new LapTop("AsusRegilar",(decimal)869.50,"Asus","Intel i3-3455Mhz","8 GB","1TB","Intel HD 4400",
                lionLithy,"13.3 IPS sensor display");

            LapTop laptopTwo = new LapTop("AsusGold",(decimal)955.44,"Asus","Intel i5-560Mhz","16GB","2TB","Intel HD 5500",
                nickelLithy,"16'' IPS sensor display");

            LapTop laptopThree = new LapTop("AsusPlatinum",(decimal)1400.80,"Asus","Intel i7-700Mhz","32GB","6TB","Radeon JP-7790",
                nickelLithy, "18'' IPS sensor display ");

            Console.WriteLine(laptopOne.ToString());
            Console.WriteLine();
            Console.WriteLine(laptopTwo.ToString());
            Console.WriteLine();
            Console.WriteLine(laptopThree.ToString());
            Console.WriteLine("Asen LapTop Shop the best prices in the city: ");

        }
    }
}
