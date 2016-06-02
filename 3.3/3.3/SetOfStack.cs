using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3
{
    public class SetOfStack
    {
        List<Stack<int>> stacks = new List<Stack<int>>();
        int capacity;

        public SetOfStack(int capacity) {
            this.capacity = capacity;
        }

        public void push(int value) {
            Stack<int> lastStack = getLastStack();
            if (lastStack != null && !lastStack.isFull())
            {
                lastStack.push(value);
            }
            else {
                Stack<int> stack = new Stack<int>(capacity);
                stack.push(value);
                stacks.Add(stack);
            }
        }

        public int pop() {
            Stack<int> lastStack = getLastStack();
            if (lastStack != null)
            {
                int item = lastStack.pop();
                if (lastStack.isEmpty())
                {
                    stacks.RemoveAt(stacks.Count - 1);
                }

                return item;
            }
            else
                throw new NullReferenceException();
        }

        public int peek() {
            Stack<int> lastStack = getLastStack();
            if (lastStack != null)
                return lastStack.peek();
            else
                throw new NullReferenceException();
        }

        public Boolean isEmpty() {
            Stack<int> lastStack = getLastStack();
            return lastStack == null;
        }

        public Stack<int> getLastStack() {
            if (stacks.Count == 0)
                return null;
            else
                return stacks[stacks.Count - 1];
        }
    }
}
