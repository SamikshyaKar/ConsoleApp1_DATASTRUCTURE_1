using ConsoleApp1_DATASTRUCTURE_1.LINKEDLIST_DS;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DATASTRUCTURE_1.LINKEDLIST_BOOK
{
    public class TheLinkedList1
    {
        public Node head = null;
        public Node tail = null;

        public void AddLast(object data)
        {
            Node newitem = new Node();
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

        public void AddFirst(object data)
        {
            Node newitem = new Node();
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

            Node current = head;

            while (current.next != null)

            {
                Console.WriteLine(current.data);
                current = current.next;
            }

            Console.WriteLine(current.data);

        }

        public void Remove(object data)

        {
            Node current = head;
            Node newitem = new Node();
            newitem.data = data;

            if (head==null)
            {
                Console.WriteLine("Empty List: No Item to be removed");
            }

            if (data==head.data)
            {
                head = head.next;
            }

            while (current.next !=null)
            {
              if (current.next.data == data)
                {
                    current.next = current.next.next;

                }
                current = current.next;

            }

        }

        public void RemoveHead()
        {
            Console.WriteLine("Inside Remove Head");

            if(head==null)
            {
             Console.WriteLine("Empty ");

            }

            head = head.next;
            Console.WriteLine("New Head is " +head.data);
        }

    }

}
