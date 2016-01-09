using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] sections = new string[3, 3];

            sections[0,0]="*********";
            sections[0,1]="Top Center";
            sections[0, 2] = "Top Right";

            sections[1, 0] = "Middle lEFT";
            sections[1, 1] = "Middle Center";
            sections[1, 2] = "Middle Right";

            sections[2, 0] = "Bottom lEFT";
            sections[2, 1] = "Bottom Center";
            sections[2, 2] = "Bottom Right";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sections[i,j] + "\t");
                    if ((j+1)%3 == 0 )
                    {
                        Console.WriteLine("");
                    }
                }
            }

            Console.ReadLine();
        
        }
    }
}
