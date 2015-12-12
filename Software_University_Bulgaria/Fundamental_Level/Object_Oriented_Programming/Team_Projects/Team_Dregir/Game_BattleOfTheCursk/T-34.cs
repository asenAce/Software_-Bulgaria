using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class T_34 : Tank
    {

        public   int fuel = 1200;
        public   int range = 800;
        public   int antiTankShellsRussian = 18;
       // private  int ANTI_INFANTRY_SHELLS = 12;
        private const int SPEED_MAX = 60;
       // private const int SPEED_ROUGH_TERRAIN = 40;
        private double rangeDetaction = 56.77;
        private int distanceTraveled;
        private int shellDamage = 30;
        private int armory = 200;
        private const int health = 450;

        public T_34()
            :base(health)
        {

        }

        public int Armory { get; set; }
        public int ShellDamage { get; set; }
        public int DistanceTraveled { get; set; }
        public int Fuel { get; set; }
        public int Range { get; set; }
        public int AntiTankShellsRussian { get; set; }
     //   public int ANTI_INFANTRY_SHELLS { get; set; }
        public int Speed_max { get; set; }
     //   public int SPEED_ROUGH_TERRAIN      {  get;   set;}

        public double RangeDetaction 
        { 
            get
            {
                return this.rangeDetaction;
            }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Incorrect");
                }

                this.rangeDetaction = value;
            }
        }

        // full / energy consumption

        public int FuelConsumptionBattleConditions(int FUEL, int RANGE)
        {
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


        public int FuelConsumptionNonBattleConditions(int FUEL, int DistanceTraveled)
        {
            const int HOURCONSUMPTION = 55;
            int timeTraveled = 0;

            FUEL = (HOURCONSUMPTION * timeTraveled) - FUEL;

            return FUEL;

        }

        public void Fire(Tiger germanHeavyBattleTank)
        {
            if (this.antiTankShellsRussian == 0)
            {
                throw new ArgumentException("empty Magazine");
            }

            // it should be the armory tank to decrise
            germanHeavyBattleTank.Armory = Armory - ShellDamage;
            
            // one shell was fired
            this.antiTankShellsRussian--;

        }

        public override string ToString()
        {
            string theStatus;

            theStatus = string.Format("Info T-34: Amonitions{0}, Armory{1} ",this.AntiTankShellsRussian,this.Armory);

            return theStatus;
        }

    }
}
