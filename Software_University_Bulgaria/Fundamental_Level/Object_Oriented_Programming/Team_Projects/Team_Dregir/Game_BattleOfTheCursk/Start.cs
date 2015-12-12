using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 


namespace CustomExceptions
{
    class Start
    {
        private const int GAMETURNS = 4;

        static void Main(string[] args)
        {

            

            try
            {
                /*
                var germanTank = new Tank(300);
                var russianTank = new Tank(400);
                ExecuteAttack(germanTank, russianTank);
                */

                T_34  russianMainBattleTank = new T_34();
                Tiger germanHeavyBattleTank = new Tiger();
                BattleOfCurskCurve(russianMainBattleTank,germanHeavyBattleTank);
                
            }

            catch (TankException theExc)
            {

                Console.WriteLine(theExc.Message);
            }

        }

        private static void BattleOfCurskCurve(T_34 russianMainBattleTank, Tiger germanHeavyBattleTank)
        {
            bool magazineFull = true;

            CheckTheMagazine(magazineFull, russianMainBattleTank, germanHeavyBattleTank);

            while (magazineFull)
            {
                //Can be applyed second for cycle for the russian tank
                for (int i = 0; i < GAMETURNS; i++)
                {
                    AttackOnTheGermanTank(russianMainBattleTank,germanHeavyBattleTank);

                    if (russianMainBattleTank.Armory == 0)
                    {
                        Console.WriteLine("T-34 Was destroyed");
                    }

                    else if (germanHeavyBattleTank.Armory == 0)
                    {
                        Console.WriteLine("Tiger was destroyed");
                    }
                }

                Console.WriteLine(russianMainBattleTank.ToString());
                Console.WriteLine(germanHeavyBattleTank.ToString());
            }



        }

        private static void CheckTheMagazine(bool magazineFull, T_34 russianMainBattleTank, Tiger germanHeavyBattleTank)
        {

            if (germanHeavyBattleTank.antiTankShells == 0)
            {
                magazineFull = false;

                Console.WriteLine("Empty magazine");
            }

            else if (russianMainBattleTank.antiTankShellsRussian == 0)
            {
                magazineFull = false;

                Console.WriteLine("Empty magazine");
            }

            magazineFull = true;
        }

        private static void AttackOnTheGermanTank(T_34 russianMainBattleTank, Tiger germanHeavyBattleTank)
        {
            while (germanHeavyBattleTank.Armory > 0)
            {
                russianMainBattleTank.Fire(germanHeavyBattleTank);
            }
        }

        

        /*
        private static void ExecuteAttack(Tank germanTank, Tank russianTank)
        {
            while (germanTank.Health > 0)
            {
                russianTank.Shoot(germanTank);
            }
        }
         * */
    }
}
