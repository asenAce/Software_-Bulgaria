
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
     public class Tank
    {
         private const int SHELLDAMAGE = 40;
         int health;
         int shells;

         public Tank(int health)
         {
             this.Shells = shells;
             this.Health = health;
         }

         public int Health 
         {
             get;
             set;
         }

         public int Shells
         {
             get;
             private set;
         }

         /*
         public void Shoot(Tank enemy)
         {
             if (this.Shells == 0)
             {
                 // empty magazine!
                 throw new TankException("Not enough shells to shoot");             
             }

             enemy.Health = Health - SHELLDAMAGE;
             this.Shells--;

         }
          * */
    }
}
