using ConsoleApp1_DATASTRUCTURE_1.LINKEDLIST_BOOK;
using ConsoleApp1_DATASTRUCTURE_1.LINKEDLIST_DS;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1_DATASTRUCTURE_1
{
    class Program
    {

    
        static void Main(string[] args)
        {

            Implementation _implementation = new Implementation();
            _implementation.AddLast("1");
            _implementation.AddLast("2");
            _implementation.AddLast("Three");
            _implementation.AddFirst("First");
            _implementation.ReadAll();
             Console.WriteLine("Hello World!");
            Second_Implementation second_Implementation = new Second_Implementation();

            second_Implementation.AddFirst("Second_1");
            second_Implementation.AddLast("2");
            second_Implementation.AddLast("3");
            second_Implementation.ReadAll();
            Console.WriteLine("**************");
            Implementation_Generics<int> obj = new Implementation_Generics<int>();
            obj.AddLast(34);
            obj.AddFirst(5);
            obj.AddFirst(9);
            obj.ReadAll();

            Console.WriteLine("*************** !!**********");

            TheLinkedList1 list1 = new TheLinkedList1();
            list1.AddLast(10);
            list1.AddLast("Samu");
            list1.AddFirst(1800);
            list1.AddLast(20);
            list1.AddLast(50);
            list1.AddLast(45);
            list1.ReadAll();
            Console.WriteLine("After Removal ");
            list1.Remove("Samu");
            list1.Remove(50);
            list1.ReadAll();
            list1.RemoveHead();
            list1.ReadAll();

            Console.WriteLine(  );

            Console.WriteLine("Stack Implementation ");

            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push("samu");
            myStack.Push(1000);
            myStack.Push(2000);
            myStack.Push("End Of Stack");

            Console.WriteLine();
            foreach(var stacks in myStack)
            {
                Console.WriteLine(stacks + "  Here are my stacks");

            }
            Console.WriteLine();
            Console.WriteLine($"Peek of the Stack Method Is : { myStack.Peek()}");
            Console.WriteLine("After the pop what ::");
            Console.WriteLine($"Peek of the Stack Method Is : { myStack.Pop()}");
            Console.WriteLine($"Peek of the Stack Method Is : { myStack.Peek()}");
            Console.WriteLine("After the pop what ::");
            Console.WriteLine($"count of the Stack Method Is : { myStack.Count}");
            Console.WriteLine($"count of the Stack Method Is : { myStack.Contains(1000)}");

        }
    }
}
