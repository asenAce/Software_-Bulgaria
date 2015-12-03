using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumGame.GameObjects.Items
{
    class Shield : Item
    {
        private const int _DEFAULTHEALTHEFFECT = 0;
        private const int _DEFAULTDEFENSEEFFECT = 50;
        private const int _DEFAULTATTACKEFFECT = 0;

        public Shield(string iD)
            :base(iD,_DEFAULTHEALTHEFFECT,_DEFAULTDEFENSEEFFECT,_DEFAULTATTACKEFFECT)
        {

        }

    }
}
