using SlumGame.GameObjects.Items;
using SlumGame.IFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumGame.GameObjects.RolePlayers
{
    class Warrior : Characters,IAttack
    {

        private const int _DEFAULTHEALTHPOINTS = 200;
        private const int _DEFAULTDEFENSEPOINTS = 100;
        private const int _DEFAULTRANGE = 4;

        private int attackPoints = 150;

        public Warrior(string iD,int x,int y,Team team)
            : base(iD, x, y, _DEFAULTHEALTHPOINTS, _DEFAULTDEFENSEPOINTS, team, _DEFAULTRANGE)
        {

        }

        public int AttackPoints 
        { 
            get
            {
                return this.attackPoints;
            }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Attack Points","Incorrect");
                }

                this.attackPoints = value;
            }
        }

        public override Characters GetTarget(IEnumerable<Characters> targetsList)
        {
            Characters resultTrget;
            resultTrget = targetsList.Where(x => x.isALive).First(x => x.Team != this.Team);

            return resultTrget;

        }

        public override void AddToInventory( Item item)
        {

            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffcet(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += AttackPoints + item.AttackEffect;
        }

        protected override void RemoveItemEffcet(Item item)
        {
            base.RemoveItemEffcet(item);
            this.AttackPoints -= AttackPoints - item.AttackEffect;
        }

        public override string ToString()
        {

            string resultString;
            resultString = string.Format("{0} , Attack: {1}",base.ToString(),this.AttackPoints);
            return resultString;

        }

    }
}
