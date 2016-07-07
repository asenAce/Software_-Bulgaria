namespace BoatRacingSimulator.UI
{
    using System;
    using BoatRacingSimulator.Interfaces;

    public class ConsoleUserInterface : IUserInterface
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadLine()
        {    
            return Console.ReadLine();
        }
    }
}
