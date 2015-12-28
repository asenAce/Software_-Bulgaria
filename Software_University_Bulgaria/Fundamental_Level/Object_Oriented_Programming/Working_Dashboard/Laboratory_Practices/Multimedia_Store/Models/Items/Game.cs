namespace MultimediaShop.Models.Items
{
    using System.Collections.Generic;
    using System.Text;

    public class Game : Item
    {
        private const AgeRestriction DefaultAgeRestriction = AgeRestriction.Minor;

        public Game(string id, string title, decimal price, IList<string> genres, AgeRestriction ageRestriction = DefaultAgeRestriction)
            : base(id, title, price, genres)
        {
            this.AgeRestriction = ageRestriction;
        }

        public Game(string id, string name, decimal price, string genre, AgeRestriction ageRestriction = DefaultAgeRestriction)
            : this(id, name, price, new List<string> { genre }, ageRestriction)
        {
        }

        public AgeRestriction AgeRestriction { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Age Restriction: {0}", this.AgeRestriction);

            return base.ToString() + result.ToString();
        }
    }
}
