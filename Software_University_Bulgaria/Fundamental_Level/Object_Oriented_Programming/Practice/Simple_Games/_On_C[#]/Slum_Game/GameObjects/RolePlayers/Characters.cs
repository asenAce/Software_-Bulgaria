using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlumGame.GameObjects.Items;

namespace SlumGame.GameObjects.RolePlayers
{
    public abstract class Characters : GameObjects
    {
        //Declaring the Variable; x , y possitiong on the screen
        int x;
        int y;
        int healthPoints;
        int defensePoints;
        int range;

        //Create a Constructor ctor
        protected Characters(string iD,int x,int y,int healthPoints,int defensePoints,Team team,int range)
            : base(iD)
        {
            this.HealthPoints = healthPoints;
            this.DefensePoints = defensePoints;
            this.Team = team;
            this.isALive = true;
            this.X = x;
            this.Y = y;
            this.Inventory = new List<Item>();
            this.Range = range;
        }

        // Getters and setters
        public int HealthPoints { get; set; }
        public int DefensePoints { get; set; }
        public int Range  { get; set; }
        public bool isALive { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Team Team { get; private set; }
        // Instantiate a Generic List<> classItem ID Inventory where i will store the items from the game
        public   List<Item> Inventory { get; private set; }

        public abstract Characters GetTarget(IEnumerable<Characters> targetsList);

        public abstract void AddToInventory(Item item);

         //  public abstract void ApplyItemEffects(Item item);
        public abstract void RemoveFromInventory(Item item);

        // Methods
        protected virtual void ApplyItemEffects(Item item)
        {
            this.HealthPoints = HealthPoints + item.HealthEffect;
            this.DefensePoints = DefensePoints + item.DefenseEffect; 
            
        }

        protected virtual void RemoveItemEffcet(Item item)
        {

            this.HealthPoints = HealthPoints - item.HealthEffect;
            this.DefensePoints = DefensePoints - item.DefenseEffect;

            if (this.HealthPoints < 0 )
            {
                this.HealthPoints = 1;
            }

        }

        public override string ToString()
        {
            string theResult;

            theResult = string.Format("Name: {0} , Defence: {1} , Team {2} , Health: {3}"
                ,this.ID
                ,this.DefensePoints
                ,this.Team
                ,this.HealthPoints);

            return theResult;

        }

        


    }
}
