using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2Alogithms.Model
{
    class Stack
    {
        private int[] list;
        private int count;

        public Stack()
        {
            this.list = new int[10];
            this.count = 0;
        }

        public void push(int value)
        {
            if (!isFull())
            {
                list[count] = value;
                count++;
            }
        }
        public int get()
        {
            int result= list[count-1];
            list[count] = 0;
            count--;
            return result;
        }
        public bool isFull()
        {
            if (count == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEmpty()
        {
            if (count == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
