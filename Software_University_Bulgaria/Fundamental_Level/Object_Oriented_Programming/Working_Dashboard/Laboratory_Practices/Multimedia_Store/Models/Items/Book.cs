namespace MultimediaShop.Models.Items
{
    using System.Collections.Generic;
    using System.Text;

    using MultimediaShop.Interfaces;

    // TODO: You may add some other properties if you wish
    public class Book : Item
    {
        public Book(string id, string title, decimal price, string author, IList<string> genres)
            : base(id, title, price, genres)
        {
            this.Author = author;
        }

        public Book(string id, string name, decimal price, string author, string genre)
            : this(id, name, price, author, new List<string> { genre })
        {
        }

        public string Author { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Author: {0}", this.Author);

            return base.ToString() + result.ToString();
        }
    }
}
