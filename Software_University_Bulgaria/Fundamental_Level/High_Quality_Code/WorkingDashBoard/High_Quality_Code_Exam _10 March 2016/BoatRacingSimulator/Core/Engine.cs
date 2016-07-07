namespace BoatRacingSimulator.Core
{
    using System;
    using System.Linq;
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.UI;

    public class Engine
    {
        public Engine(ICommandHandler commandHandler, IUserInterface userInterface)
        {
            this.CommandHandler = commandHandler;
            this.UserInterface = userInterface;
        }

        public Engine() : this(new CommandHandler(), new ConsoleUserInterface())
        {
        }

        public ICommandHandler CommandHandler { get; private set; }

        public IUserInterface UserInterface { get; private set; }

        public void Run()
        {
            while (true)
            {
                string line = this.UserInterface.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }

                var tokens = line.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var parameters = tokens.Skip(1).ToArray();

                try
                {
                    string commandResult = this.CommandHandler.ExecuteCommand(name, parameters);
                    this.UserInterface.WriteLine(commandResult);
                }
                catch (Exception ex)
                {
                    this.UserInterface.WriteLine(ex.Message);
                }
            }
        }
    }
}
