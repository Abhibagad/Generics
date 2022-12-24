using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class RemoveFirst
    {
        public Node head;
        public Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
    }
}
