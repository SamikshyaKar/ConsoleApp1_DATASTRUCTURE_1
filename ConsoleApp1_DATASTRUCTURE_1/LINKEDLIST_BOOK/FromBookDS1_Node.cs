using ConsoleApp1_DATASTRUCTURE_1.LINKEDLIST_DS;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DATASTRUCTURE_1.LINKEDLIST_BOOK
{
   public class FromBookDS1_Node
    {
        public object data;
        public Node next;
        public FromBookDS1_Node()
        {
            data = null;
            next = null;
        }
        public FromBookDS1_Node(object data_element)
        {
            data = data_element;
            next = null;
        }

    }
}
