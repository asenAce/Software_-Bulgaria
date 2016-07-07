namespace BoatRacingSimulator.Models.Boats
{
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Utility;

    public class Yacht : MotorBoat
    {
        private int cargoWeight;

        public Yacht(string model, int weight, IBoatEngine boatEngine, int cargoWeight) : base(model, weight, boatEngine)
        {
            this.CargoWeight = cargoWeight;
        }

        public int CargoWeight
        {
            get
            {
                return this.cargoWeight;
            }

            private set
            {
                Validator.ValidatePropertyValue(value, "Cargo Weight");
                this.cargoWeight = value;
            }
        }

        public override double CalculateRaceSpeed(IRace race)
        {
            var speed = this.Engine.Output - this.Weight - this.CargoWeight + (race.OceanCurrentSpeed / 2d);
            return speed;
        }
    }
}
