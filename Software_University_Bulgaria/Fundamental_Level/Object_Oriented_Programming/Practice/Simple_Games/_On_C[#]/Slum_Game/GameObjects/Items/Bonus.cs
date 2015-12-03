using SlumGame.IFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SlumGame.GameObjects.Items
{
    public abstract  class Bonus : Item,ITimeOutable
    {
        protected Bonus(string iD, int healthEffect, int defenseEffect, int attackEffect)
            :base(iD,healthEffect,defenseEffect,attackEffect)
        {

        }

        public int  TimeOut { get; set; }
        public int  CountDown { get; set; }
        public bool isitTimeOut { get; set; }  // HasTimeOut

    }
}
