using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumGame.GameObjects.Items
{
    class Axe : Item
    {
        private const int _DEFAULTHEALTHEFFECT = 75;
        private const int _DEFAULTDEFENSEEFFECT = 50;
        private const int _DEFAULTATTACKEFFECT = 6;

        public Axe(string iD)
            : base(iD, _DEFAULTHEALTHEFFECT, _DEFAULTDEFENSEEFFECT, _DEFAULTATTACKEFFECT)
        {



        }


    }
}
