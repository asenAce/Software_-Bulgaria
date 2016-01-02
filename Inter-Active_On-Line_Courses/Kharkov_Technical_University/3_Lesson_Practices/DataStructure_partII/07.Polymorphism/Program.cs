using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            


        }


        public class A : Object
        {
            public virtual void Dowork()
            {
                // .....
            }
        }

        public class B : A
        {
            public override void Dowork()
            {
                // base.Dowork();
            }

        }



    }
}
