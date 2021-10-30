using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DATASTRUCTURE_1.LINKEDLIST_DS
{
    public class Implementation_Generics<Anytype>
    {
        Node<Anytype> head = null;
        Node<Anytype> tail = null;

        public void AddLast(Anytype data)
        {
            Node<Anytype> newitem = new Node<Anytype>();
            newitem.data = data;

            if (head == null)
            {
                head = newitem;
                tail = newitem;

            }
            else
            {
                tail.next = newitem;
                tail = newitem;
            }
        }

        public void AddFirst(Anytype data)
        {
            Node<Anytype> newitem = new Node<Anytype>();
            newitem.data = data;

            if (head == null)
            {
                head = newitem;
                tail = newitem;
            }
            else
            {
                newitem.next = head;
                head = newitem;

            }


        }

        public void ReadAll()
        {

            Node<Anytype> current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }
    }
}
