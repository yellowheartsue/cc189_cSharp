using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._2
{
    class StackWithMin2 : Stack<Int32>
    {
        private Stack<Int32> minStack;

        public StackWithMin2() { 
            minStack = new Stack<int>();
        }

        public void push(Int32 value) {
            if (value <= Min())
                minStack.push(value);

            base.push(value);
        }

        public Int32 pop() {
            Int32 top = base.pop();
            if (top == Min())
                minStack.pop();

            return top;
        }

        public Int32 Min() {
            if (this.isEmpty())
                return int.MaxValue;
            else
                return minStack.peek();
        }
    }
}
