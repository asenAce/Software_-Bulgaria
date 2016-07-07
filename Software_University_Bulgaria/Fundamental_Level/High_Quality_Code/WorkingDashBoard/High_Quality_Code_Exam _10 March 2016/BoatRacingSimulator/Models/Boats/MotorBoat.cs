namespace BoatRacingSimulator.Models.Boats
{
    using BoatRacingSimulator.Interfaces;

    public abstract class MotorBoat : Boat
    {
        protected MotorBoat(string model, int weight, IBoatEngine boatEngine) : base(model, weight)
        {
            this.Engine = boatEngine;
        }

        public IBoatEngine Engine { get; private set; }
    }
}
