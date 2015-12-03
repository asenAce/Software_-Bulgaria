using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumGame.GameObjects.Items
{
    public abstract class Item : GameObjects
    {

        int healthEffect;
        int defenseEffect;
        int attackEffect;

        public Item(string iD, int healthEffect, int defenseEffect, int attackEffect)
            : base(iD)
        {
            this.HealthEffect = healthEffect;
            this.DefenseEffect = defenseEffect;
            this.AttackEffect = attackEffect;

        }

        public int HealthEffect { get; set; }
        public int DefenseEffect { get; set; }
        public int AttackEffect { get; set; }


    }
}
