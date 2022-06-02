using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2Alogithms.Model
{
    class Queue
    {
        private int[] list;
        private int count;
        
        public Queue()
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
            int result = list[0];
            count--;
            for(int i= 0; i< count; i++)
            {
                list[i] = list[i + 1];
            }
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
