namespace BoatRacingSimulator.Models.Engines
{
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Utility;

    public abstract class BoatEngine : IBoatEngine
    {
        private string model;

        private int horsepower;

        private int displacement;

        protected BoatEngine(string model, int horsepower, int displacement)
        {
            this.Model = model;
            this.Horsepower = horsepower;
            this.Displacement = displacement;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                Validator.ValidateModelLength(value, Constants.MinBoatEngineModelLength);
                this.model = value;
            }
        }

        public abstract int Output { get; }

        protected int CachedOutput { get; set; }

        protected int Horsepower
        {
            get
            {
                return this.horsepower;
            }

            set
            {
                Validator.ValidatePropertyValue(value, "Horsepower");
                this.horsepower = value;
            }
        }

        protected int Displacement
        {
            get
            {
                return this.displacement;
            }

            set
            {
                Validator.ValidatePropertyValue(value, "Displacement");
                this.displacement = value;
            }
        }
    }
}
