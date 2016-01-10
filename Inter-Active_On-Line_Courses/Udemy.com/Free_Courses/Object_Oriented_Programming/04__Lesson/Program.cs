using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Properties
{
    class Program
    {
        static void Main(string[] args)
        {




        }


        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

             
    }
}
