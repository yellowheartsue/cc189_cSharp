using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._5
{
    public class Stack<T>
    {
        private class StackNode<T>
        {
            public T data;
            internal StackNode<T> next;

            public StackNode(T data)
            {
                this.data = data;
            }
        }

        private StackNode<T> top;

        public void push(T item)
        {
            StackNode<T> node = new StackNode<T>(item);
            node.next = top;
            top = node;
        }

        public T pop()
        {
            if (top != null)
            {
                T item = top.data;
                top = top.next;
                return item;
            }
            else
                throw new NullReferenceException();
        }

        public T peek()
        {
            if (top != null)
                return top.data;
            else
                throw new NullReferenceException();
        }

        public Boolean isEmpty()
        {
            return top == null;
        }
    }
}
