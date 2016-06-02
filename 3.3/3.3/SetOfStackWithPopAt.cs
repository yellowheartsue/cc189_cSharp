using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3
{
    class SetOfStackWithPopAt
    {
        private List<StackWithBottom<int>> list;
        private int capacity;

        public SetOfStackWithPopAt(int capacity) {
            list = new List<StackWithBottom<int>>();
            this.capacity = capacity;
        }

        public StackWithBottom<int> getLastStack() {
            if (list.Count == 0)
                return null;
            else
                return list[list.Count - 1];
        }

        public Boolean isEmpty() {
            return getLastStack() == null;
        }

        public void push(int item) {
            StackWithBottom<int> lastStack = getLastStack();
            if (lastStack != null && !lastStack.isFull())
            {
                lastStack.push(item);
            }
            else
            {
                StackWithBottom<int> stack = new StackWithBottom<int>(capacity);
                stack.push(item);
                list.Add(stack);
            }
        }

        public int popAt(int index) {
            return leftShift(index, true); 
        }

        public int leftShift(int index, Boolean removeTop) {
            if (index <= list.Count - 1)
            {
                StackWithBottom<int> stack = list[index];
                int toReturn;
                if (removeTop)
                    toReturn = stack.pop();
                else
                    toReturn = stack.removeBottom();

                if (stack.isEmpty())
                    list.RemoveAt(index);
                else if (index < list.Count - 1)
                {
                    int item = leftShift(index + 1, false);
                    stack.push(item);
                }

                return toReturn;
            }
            else
                throw new IndexOutOfRangeException();
        }

        public int peek() {
            StackWithBottom<int> stack = getLastStack();
            if (stack != null)
                return stack.peek();
            else
                throw new NullReferenceException();
        }
    }
}
