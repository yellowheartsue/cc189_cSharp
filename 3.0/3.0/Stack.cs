using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._0
{
    public class Stack<T>
    {
        private class StackNode<T> {
            internal T data;
            internal StackNode<T> next;

            public StackNode(T data){
                this.data = data;
            }
        }

        private StackNode<T> top;

        public T pop() {
            if (top != null)
                return top.data;
            else
                throw new NullReferenceException();
        }

        public void push(T item) {
            StackNode<T> node = new StackNode<T>(item);
            if (top != null)
                node.next = top;

            top = node;
        }

        public T peek() {
            if (top != null)
                return top.data;
            throw new NullReferenceException();
        }

        public bool ifEmpty() {
            return top == null;
        }
    }
}
