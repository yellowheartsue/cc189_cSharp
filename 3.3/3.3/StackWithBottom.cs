using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3
{
    public class StackWithBottom<T>
    {
        private class StackNode<T>
        {
            public T data;
            internal StackNode<T> below;
            internal StackNode<T> above;

            public StackNode(T data)
            {
                this.data = data;
            }
        }

        private StackNode<T> top;
        private StackNode<T> bottom;
        private int size;
        private int capacity;

        public StackWithBottom(int capacity) {
            this.capacity = capacity;
        }

        public void push(T data) {
            if (size >= capacity)
                throw new Exception();

            size++;
            StackNode<T> node = new StackNode<T>(data);

            if (size == 1)
            {
                top = bottom = node;
                top.below = bottom;
                bottom.above = top;
            }
            else {
                node.below = top;
                top.above = node;
                top = node;
            }  
        }

        public T pop() {
            if (!isEmpty())
            {
                size--;
                T item = top.data;
                top = top.below;
                return item;
            }
            else
                throw new NullReferenceException();
        }

        public T removeBottom() {
            if (!isEmpty()) {
                size--;
                T item = bottom.data;
                bottom = bottom.above;
                if (bottom != null) bottom.below = null;
                return item;
            }
            else
                throw new NullReferenceException();
        }

        public T peek() {
            if (!isEmpty())
                return top.data;
            else
                throw new NullReferenceException();
        }

        public Boolean isEmpty() {
            if (size == 0 || top == null)
                return true;
            else
                return false;
        }

        public Boolean isFull() {
            return size == capacity;
        }
    }
}
