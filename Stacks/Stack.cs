using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Stack
    {
        private int[] stack = new int[5];
        private int top;
        public Stack()
        {
            top = -1;
        }

        public int Pop()
        {
            int topInt = stack[top + 1];
            stack[top] = 0;
            top--;
            return topInt;
        }

        public void Push(int num)
        {
            if(isFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }
            stack[top + 1] = num;
            top++;
        }

        public bool isFull()
        {
            if (top == stack.Length - 1)
            {
                return true;
            }
            else return false;
        }

        public bool isEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else return false;
        }
    }
}
