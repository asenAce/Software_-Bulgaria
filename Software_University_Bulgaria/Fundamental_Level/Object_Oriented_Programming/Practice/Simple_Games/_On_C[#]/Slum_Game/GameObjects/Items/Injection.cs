using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumGame.GameObjects.Items
{
    class Injection : Bonus
    {

        private const int _DEFAULTHEALTHEFFECT = 200;
        private const int _DEFAULTDEFENSEEFFECT = 0;
        private const int _DEFAULTATTACKEFFECT = 0;

        public Injection(string iD)
            :base(iD,_DEFAULTHEALTHEFFECT,_DEFAULTDEFENSEEFFECT,_DEFAULTATTACKEFFECT)
        {

            this.CountDown = 3;

        }


    }
}
