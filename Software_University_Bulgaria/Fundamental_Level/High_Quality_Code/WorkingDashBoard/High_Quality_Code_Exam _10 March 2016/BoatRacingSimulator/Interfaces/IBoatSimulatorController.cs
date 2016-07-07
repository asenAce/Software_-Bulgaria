namespace BoatRacingSimulator.Interfaces
{
    using BoatRacingSimulator.Enumerations;
    using BoatRacingSimulator.Exceptions;

    public interface IBoatSimulatorController
    {
        IRace CurrentRace { get; }

        IBoatSimulatorDatabase Database { get; }

        /// <summary>
        /// A method working like a factory, that creates different types of boat engines based on the input parameters and the passed in type and saves them in the database.
        /// </summary>
        /// <param name="model">The model of the desired engine.</param>
        /// <param name="horsepower">The horsepower of the engine.</param>
        /// <param name="displacement">The water displacement of the engine.</param>
        /// <param name="engineType">The type of the engine.</param>
        /// <returns>Returns a string message signifying the result of the action.</returns>
        string CreateBoatEngine(string model, int horsepower, int displacement, EngineType engineType);

        string CreateRowBoat(string model, int weight, int oars);

        string CreateSailBoat(string model, int weight, int sailEfficiency);

        string CreatePowerBoat(string model, int weight, string firstEngineModel, string secondEngineModel);

        string CreateYacht(string model, int weight, string engineModel, int cargoWeight);

        string OpenRace(int distance, int windSpeed, int oceanCurrentSpeed, bool allowsMotorboats);

        /// <summary>
        /// A method that finds a specified boat in the database from a given model and then attempts to sign it up in the current Race.
        /// </summary>
        /// <param name="model">The unique model of the boat to be registered.</param>
        /// <exception cref="NoSetRaceException">Throws an exception if there is no current Race set.</exception>
        /// <exception cref="System.ArgumentException">Throws an exception if the boat type does not meet the current Race requierments.</exception>
        /// <returns>Returns a string message signifying the result of the action.</returns>
        string SignUpBoat(string model);

        string StartRace();

        string GetStatistic();
    }
}
