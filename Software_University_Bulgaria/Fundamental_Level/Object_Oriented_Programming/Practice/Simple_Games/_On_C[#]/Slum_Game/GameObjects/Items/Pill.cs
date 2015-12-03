using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumGame.GameObjects.Items
{
    class Pill : Bonus
    {

        private const int _DEFAULTHEALTHEFFECT = 0;
        private const int _DEFAULTDEFENSEEFFECT = 0;
        private const int _DEFAULTATTACKEFFECT = 100;


        public Pill(string iD)
            :base(iD,_DEFAULTHEALTHEFFECT,_DEFAULTDEFENSEEFFECT,_DEFAULTATTACKEFFECT)
        {
            this.CountDown = 1;

        }


    }
}
