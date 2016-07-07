namespace BoatRacingSimulator.Models.Boats
{
    using BoatRacingSimulator.Interfaces;

    public class PowerBoat : MotorBoat
    {
        public PowerBoat(string model, int weight, IBoatEngine boatEngine, IBoatEngine secondBoatEngine) : base(model, weight, boatEngine)
        {
            this.SecondEngine = secondBoatEngine;
        }

        public IBoatEngine SecondEngine { get; private set; }

        public override double CalculateRaceSpeed(IRace race)
        {
            var speed = this.Engine.Output + this.SecondEngine.Output - this.Weight + (race.OceanCurrentSpeed / 5d);
            return speed;
        }
    }
}
