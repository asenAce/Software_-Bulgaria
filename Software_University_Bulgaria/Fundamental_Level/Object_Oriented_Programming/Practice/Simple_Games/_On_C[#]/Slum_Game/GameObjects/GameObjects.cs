using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumGame.GameObjects
{
    public abstract class GameObjects
    {

        protected GameObjects(string iD)
        {

            this.ID = iD;

        }

        public string ID { get; private set; }

    }
}
