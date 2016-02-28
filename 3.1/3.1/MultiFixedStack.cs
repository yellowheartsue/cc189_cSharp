using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._1
{
    class MultiFixedStack
    {
        int numOfStacks;
        int stackCapacity;
        int[] sizes;
        int[] values;

        public MultiFixedStack(int size) {
            this.stackCapacity = size;
            this.numOfStacks = 3;

            this.sizes = new int[numOfStacks];
            this.values = new int[numOfStacks * stackCapacity];
        }

        public void push(int data, int stackNum) {
            if (isFull(stackNum))
                throw new Exception("Full Stack");

            sizes[stackNum]++;
            values[topIndex(stackNum)] = data;
        }

        public Int32 pop(int stackNum) {
            if (isEmpty(stackNum)) 
                throw new Exception("Empty Stack");

            int topindex = topIndex(stackNum);
            int result = values[topindex];
            values[topindex] = 0; //clear
            sizes[stackNum]--;

            return result;
        }

        public Int32 peek(int stackNum) {
            if (isEmpty(stackNum))
                throw new Exception("Empty Stack");

            return values[topIndex(stackNum)];
        }

        public Boolean isEmpty(int stackNum)
        {
            return sizes[stackNum] == 0;
        }

        public Boolean isFull(int stackNum) {
            return sizes[stackNum] == stackCapacity;
        }

        public Int32 topIndex(int stackNum) {
            int offset = stackNum * stackCapacity;
            int size = sizes[stackNum];

            return offset + size - 1;
        }

        public void print(){
            foreach(int i in values){
                Console.WriteLine(i);
            }
        }
    }
}
