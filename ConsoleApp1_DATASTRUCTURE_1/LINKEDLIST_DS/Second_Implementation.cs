using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DATASTRUCTURE_1.LINKEDLIST_DS
{
    public class Second_Implementation

    {
        Node head = null;
        Node tail = null;

        public void AddLast(object data)
        {

            Node newItem = new Node();
            newItem.data = data;

            if (head == null)
            {
                head = newItem;
                //head.next = null;
                //tail = head;
                tail = newItem;

            }
            else
            {
                tail.next = newItem;
                tail = newItem;

            }

        }

        public void AddFirst(object data)
        {
            Node newitem = new Node();
            newitem.data = data;

            if(head == null)
            {
                head = newitem;
                tail = newitem;

            }

            else
            {
                newitem.next = head;
                head = newitem;

            }
            //Node newItem = new Node();
            //newItem.data = data;
            //newItem.next = head;
            //head = newItem;

        }

        public void ReadAll()
        {

            Node current = head;

            while (current.next != null)

            {
                Console.WriteLine(current.data);
                current = current.next;

            }

            Console.WriteLine(current.data);

        }
    }
}
