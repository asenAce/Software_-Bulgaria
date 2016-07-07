namespace BoatRacingSimulator.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the behaviour of the Race class.
    /// </summary>
    public interface IRace
    {
        /// <summary>
        /// The distance of the current Race.
        /// </summary>
        int Distance { get; }

        /// <summary>
        /// The wind speed of the current race.
        /// </summary>
        int WindSpeed { get; }

        /// <summary>
        /// The speed of the ocean current in the current Race.
        /// </summary>
        int OceanCurrentSpeed { get; }

        /// <summary>
        /// A boolean property indicating whether Motorboats(boats with engines) are allowed.
        /// </summary>
        bool AllowsMotorboats { get; }

        /// <summary>
        /// A method for adding boats to the inner collection of participants for the current Race.
        /// </summary>
        /// <param name="boat">The boat to be added to the Race participants</param>
        void AddParticipant(IBoat boat);

        /// <summary>
        /// A method which returns a copy of the collection of participants.
        /// </summary>
        /// <returns>Returns a copy of the collection of participants.</returns>
        IList<IBoat> GetParticipants();
    }
}
