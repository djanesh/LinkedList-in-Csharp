using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list1
{
    public class Node
    {
        /* COnstructor
         * [x] Node(object data, Node next)
         * 
         * Private Fields :
         * [x]object data - contain the data of the node, what we want to store in the list
         * [x]Node next  - reference to the next node in the list
         * 
         * Public Properties:
         * [x] Data - get / set the data field 
         * [x] next - get / set the next field 
         */

        private object data;
        private Node next;

        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
