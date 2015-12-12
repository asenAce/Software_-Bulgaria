using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class Tiger : Tank
    {
        private const int fuel = 1400;
        private const int RANGE = 900;
        public   int antiTankShells = 22;
      //  private const int ANTI_INFANTRY_SHELLS = 16;
      //  private const int SPEED_MAX = 40;
      //  private const int SPEED_ROUGH_TERRAIN = 30;
        private double rangeDetaction = 76.77;
        private int distanceTraveled;



        private const int SHELLDAMAGE = 30;
        private const int  health = 550;
        int shells = 38;

        private int shellDamage = 25;
        private int armory = 300;

        public Tiger()
            :base(health)
        {

        }

        public int Armory { get; set; }
        public int ShellDamage { get; set; }


        public int DistanceTraveled { get; set; }
        public int Fuel { get; set; }
        public int Range { get; set; }
        public int AntiTankShells { get; set; }
     //   public int ANTI_INFANTRY_SHELLS { get; set; }
     //   public int SPEED_MAX { get; set; }
     //   public int SPEED_ROUGH_TERRAIN       {           get;          set;      }

        public double RangeDetaction
        {
            get
            {
                return this.rangeDetaction;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Incorrect");
                }

                this.rangeDetaction = value;
            }
        }

        // full / energy consumption

        public int FuelConsumptionBattleConditions(int FUEL, int RANGE)
        {
            if (RANGE == 900)
            {
                FUEL = FUEL - 9;

                return FUEL;
            }

            if (RANGE == 800)
            {
                FUEL = FUEL - 8;

                return FUEL;
            }

            else if (RANGE < 600)
            {
                FUEL = FUEL - 6;

                return FUEL;
            }

            else if (RANGE < 500)
            {
                FUEL = FUEL - 5;

                return FUEL;
            }

            else if (RANGE < 400)
            {
                FUEL = FUEL - 4;

                return FUEL;
            }

            return FUEL--;

        }

        //Method that calculate the fuel consumption
        public int FuelConsumptionNonBattleConditions(int FUEL, int DistanceTraveled)
        {
            const int HOURCONSUMPTION = 75;
            int timeTraveled = 0;

            FUEL = (HOURCONSUMPTION * timeTraveled) - FUEL;

            return FUEL;

        }

        public override string ToString()
        {
            string theStatus;

            theStatus = string.Format("Tank Tiger Armory{0}\nAmonitions{1}",this.Armory,this.AntiTankShells);

            return theStatus;
        }


    }
}
