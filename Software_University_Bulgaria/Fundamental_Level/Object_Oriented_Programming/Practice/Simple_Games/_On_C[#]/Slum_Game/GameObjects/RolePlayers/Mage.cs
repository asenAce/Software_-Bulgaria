using SlumGame.GameObjects.Items;
using SlumGame.IFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumGame.GameObjects.RolePlayers
{
    class Mage : Characters , IAttack
    {
        private const int _DEFAULTHEALTHPOINTS = 150;
        private const int _DEFAULTDEFENSEPOINTS = 50;
        private const int _DEFAULTRANGE = 5;

        private int attackPoints = 300;

        public Mage(string iD,int x,int y,Team team)
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Attack Points", "Incorrect");
                }

                this.attackPoints = value;
            }
        }

        // The Methods
        public override Characters GetTarget(IEnumerable<Characters> targetsList)
        {

            Characters resultTarget;
            resultTarget = targetsList.Where(x => x.isALive && x.Team != this.Team).LastOrDefault();
            return resultTarget;
        }

        public override void AddToInventory(Item item)
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
            this.ApplyItemEffects(item);
            this.AttackPoints = AttackPoints + item.AttackEffect;
        }

        protected override void RemoveItemEffcet(Item item)
        {
            this.RemoveItemEffcet(item);
            this.AttackPoints = AttackPoints - item.AttackEffect;
        }

        public override string ToString()
        {
            string resultString;
            return resultString = string.Format("{0}, Attack: {1}",base.ToString(),this.AttackPoints);

        }

    }
}
