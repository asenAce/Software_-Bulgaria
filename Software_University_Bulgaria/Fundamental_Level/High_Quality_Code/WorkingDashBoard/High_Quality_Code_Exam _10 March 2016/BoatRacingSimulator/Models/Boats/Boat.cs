namespace BoatRacingSimulator.Models.Boats
{
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Utility;

    public abstract class Boat : IBoat
    {
        private string model;

        private int weight;

        protected Boat(string model, int weight)
        {
            this.Model = model;
            this.Weight = weight;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                Validator.ValidateModelLength(value, Constants.MinBoatModelLength);
                this.model = value;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }

            private set
            {
                Validator.ValidatePropertyValue(value, "Weight");
                this.weight = value;
            }
        }

        public abstract double CalculateRaceSpeed(IRace race);
    }
}
