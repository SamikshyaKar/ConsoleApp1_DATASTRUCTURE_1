using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DATASTRUCTURE_1.StackDS
{
   public  class Stack1_Practice
    {
        private int capacity = 1000;
        private int[] data;
        private int top = -1;
        public Stack1_Practice()
        {
            data = new int[capacity];
        }

        public Stack1_Practice(int size)
        {
            data = new int[size];
            capacity = size;
        }
      
    }
}
