using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSix.cs
{
    public class Area : IComparable<Area>
    {
        public Area(int size, int row, int col)
        {
            this.Size = size;
            this.Row = row;
            this.Col = col;
        }

        public int Size { get; set; }

        public int Row { get; private set; }

        public int Col { get; private set; }

        public int CompareTo(Area other)
        {
            if (this.Size.CompareTo(other.Size) != 0)
            {
                return -1 * this.Size.CompareTo(other.Size);
            }

            if (this.Row.CompareTo(other.Row) != 0)
            {
                return this.Row.CompareTo(other.Row);
            }

            return this.Col.CompareTo(other.Col);
        }

        public override string ToString()
        {
            return string.Format(
                "({0}, {1}), size: {2}",
                this.Row,
                this.Col,
                this.Size);
        }
    }
}
