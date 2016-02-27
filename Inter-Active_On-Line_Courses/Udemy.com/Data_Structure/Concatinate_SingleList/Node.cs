using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleListConcatinate
{
    class Node
    {

        public int info;
        public Node link;

        public Node(int i)
        {
            this.info = i;
            this.link = null;
        }
    }
}
