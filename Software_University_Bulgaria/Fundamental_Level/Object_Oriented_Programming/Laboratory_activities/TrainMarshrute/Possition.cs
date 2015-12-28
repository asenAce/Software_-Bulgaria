using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPutOutPut
{
    public class Possition
    {
        public int x, y;

        public Possition(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }


        public int X 
        {
            get
            {
                return this.X;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Incorrect");
                }
                this.x = value;
            }
        }

        public int Y 
        {
            get
            {
                return this.Y;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Incorrect");
                }

                this.Y = value;
            }
        }


    }
}
