namespace MultimediaShop.Models.Items
{
    using System.Collections.Generic;
    using System.Text;

    public class Video : Item
    {
        public Video(string id, string title, decimal price, int length, IList<string> genres)
            : base(id, title, price, genres)
        {
            this.Length = length;
        }

        public Video(string id, string name, decimal price, int length, string genre)
            : this(id, name, price, length, new List<string> { genre })
        {
        }

        public int Length { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Length: {0}", this.Length);

            return base.ToString() + result.ToString();
        }
    }
}
