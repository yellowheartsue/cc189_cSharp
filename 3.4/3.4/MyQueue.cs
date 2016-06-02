using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._4
{
    public class MyQueue<T>
    {
        private Stack<T> enqueueStack = new Stack<T>();
        private Stack<T> dequeueStack = new Stack<T>();

        public void add(T item) {
            enqueueStack.push(item);
        }

        private void shiftStack() {
            if (dequeueStack.isEmpty())
            {
                while (!enqueueStack.isEmpty())
                {
                    dequeueStack.push(enqueueStack.pop());
                }
            }
        }

        public T remove() {
            shiftStack();
            return dequeueStack.pop();
        }

        public T peek() {
            shiftStack();
            return dequeueStack.peek();
        }

        public Boolean isEmpty() {
            return enqueueStack.isEmpty() && dequeueStack.isEmpty();
        }
    }
}
