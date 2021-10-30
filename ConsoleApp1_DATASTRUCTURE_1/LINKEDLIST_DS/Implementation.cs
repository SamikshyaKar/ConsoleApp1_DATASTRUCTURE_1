﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DATASTRUCTURE_1.LINKEDLIST_DS
{
 public  class Implementation

    {
        Node head = null;

        public void AddLast( object data)
        {

            Node newItem = new Node();
            newItem.data = data;

            if (head == null)
            {            
                head = newItem;
                head.next = null;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;

                }

                current.next = newItem;
                newItem.next = null;               

            }

        }

        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            newItem.next = head;
            head = newItem;

        }

        public void ReadAll()
        {

            Node current = head;

            while  (current.next != null)

            {
                Console.WriteLine(current.data);
                current = current.next;            

            }

            Console.WriteLine(current.data);

        }
    }
}
