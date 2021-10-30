using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DATASTRUCTURE_1.LINKEDLIST_DS
{
   public  class Node
    {
        public object data = null;
        public Node  next = null;
    }

    public class Node<Anytype>
    {
        public Anytype data;

        public Node<Anytype> next;
    }
}
