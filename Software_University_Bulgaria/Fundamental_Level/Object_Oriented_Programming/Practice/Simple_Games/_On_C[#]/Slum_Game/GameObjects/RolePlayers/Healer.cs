using SlumGame.GameObjects.Items;
using SlumGame.IFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumGame.GameObjects.RolePlayers
{
    public  class Healer : Characters,IHeal
    {

        private const int _DEFAULTHEALTHPOINTS = 75;
        private const int _DEFAULTDEFENSEPOINTS = 50;
        private const int _DEFAULTRANGE = 6;



        private int healingPoints = 60;

        public Healer(string iD,int x,int y,Team team)
            : base(iD, x, y, _DEFAULTHEALTHPOINTS, _DEFAULTDEFENSEPOINTS, team, _DEFAULTRANGE)
        {




        }

        public int HealingPoints 
        { 
            get
            {
                return this.healingPoints;
            }
            set
            {

                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Healing Points","Incorrect");
                }
                
                this.healingPoints = value;
            }
        }

        public override Characters GetTarget(IEnumerable<Characters> targetsList)
        {

            Characters resultTarget;

            resultTarget = targetsList
                .Where(x => x.isALive)
                .Where(x => x.Team == this.Team)
                .Where(x => x != this)
                .OrderBy(x => x.HealthPoints)
                .FirstOrDefault();

            return resultTarget;

        }

        //The Methods
        public override void AddToInventory( Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Add(item);
            this.RemoveItemEffcet(item);
        }

        public override string ToString()
        {
            string resultString;
            resultString = string.Format("{0}. Healing:  {1}",base.ToString(),this.HealingPoints);
            return resultString;
        }


        public int HealingPoins
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
