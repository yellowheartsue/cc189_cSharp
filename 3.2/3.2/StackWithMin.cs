using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._2
{
    public class StackWithMin : Stack<StackNodeWithMin>
    {
        public void push(int value) {
            int newMin = Math.Min(value, Min());
            base.push(new StackNodeWithMin(value, newMin));
        }

        public int Min() {
            if (this.isEmpty())
                return int.MaxValue;
            else
                return peek().min;
        }
    }

    public class StackNodeWithMin {
        public int data;
        public int min;
        public StackNodeWithMin(int data, int min) {
            this.data = data;
            this.min = min;
        }
    }
}
