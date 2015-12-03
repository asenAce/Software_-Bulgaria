using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumGame.IFaces
{
    public interface ITimeOutable
    {
          int TimeOut { get; set; }
          int CountDown { get; set; }

          bool isitTimeOut { get; set; }
    }
}
