using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomExceptions
{
    class TankException : Exception
    {
      //  private string p;

        public TankException(string myMsg)
            :base(myMsg)
        {
             
        }
    }
}
