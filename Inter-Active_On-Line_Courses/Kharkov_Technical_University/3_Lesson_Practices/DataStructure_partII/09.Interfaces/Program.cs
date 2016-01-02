using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public interface IWindow
        {
            string Title
            {
                get;
                set;
            }

            void Draw();
            void Open();
        }

    }
}
