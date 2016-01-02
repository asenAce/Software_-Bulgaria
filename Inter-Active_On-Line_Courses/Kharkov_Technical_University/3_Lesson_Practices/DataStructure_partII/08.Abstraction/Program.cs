using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {



        }


        public abstract class Window
        {
            public string Title
            {
                get;
                set;
            }

            public virtual void Draw()
            {
                //...
            }

            public abstract void Open();
        }
    }
}
