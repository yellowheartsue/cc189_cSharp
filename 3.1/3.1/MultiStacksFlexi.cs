using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._1
{
    class MultiStacksFlexi
    {
        class StackInfo {
            internal int start, capacity, size;

            public StackInfo(int start, int capacity) {
                this.start = start;
                this.capacity = capacity;
            }

            internal Boolean isFull() { return size == capacity; }
            internal Boolean isEmpty() { return size == 0; }

            internal Boolean isInStackRange(int index)
            {
                if (index < 0 || index >= values.Length)
                    return false;

                int contiguousIndex = index < start ? index + values.Length : index;
                int end = start + capacity;
                return start <= contiguousIndex && contiguousIndex < end;
            }

            internal int LastCapacityIndex()
            {
                return AdjustIndex(start + capacity - 1);
            }

            internal int LastElementIndex()
            {
                return AdjustIndex(start + size - 1);
            }

        }

        StackInfo[] info;
        static int[] values;

        public MultiStacksFlexi(int numOfStacks, int defaultCapacity) {
            info = new StackInfo[numOfStacks];
            for (int i = 0; i < numOfStacks; i++) {
                info[i] = new StackInfo(i * defaultCapacity, defaultCapacity);
            }

            values = new int[numOfStacks * defaultCapacity];
        }

        public void push(int data, int stackNum) {
            if (isAllStackFull())
                throw new Exception("All Stack Are Full");

            StackInfo stack = info[stackNum];
            if (stack.isFull()) {
                expand(stackNum);
            }

            stack.size ++;
            values[stack.LastElementIndex()] = data;
        }

        public int pop(int stackNum) {
            StackInfo stack = info[stackNum];
            if (stack.isEmpty())
                throw new Exception("Stack is Empty");

            int result = values[stack.LastElementIndex()];
            values[stack.LastElementIndex()] = 0;
            stack.size--;

            return result;
        }

        public int peek(int stackNum) {
            StackInfo stack = info[stackNum];
            if (stack.isEmpty())
                throw new Exception("Stack is Empty");

            return values[stack.LastElementIndex()];
        }

        //expand stack by shift over other stacks
        void expand(int stackNum) {
            shift((stackNum + 1) % info.Length);
            info[stackNum].capacity++;
        }

        void shift(int stackNum) {
            StackInfo stack = info[stackNum];

            if (stack.isFull()){
                shift((stackNum + 1) % info.Length);
                stack.capacity++;
            }

            int index = stack.LastCapacityIndex();
            while (stack.isInStackRange(index)) {
                values[index] = values[PreviouIndex(index)];
                index = PreviouIndex(index);
            }

            values[stack.start] = 0; //clear item
            stack.start = NextIndex(stack.start); //move start
            stack.capacity--; //shrink capacity
        }

        int NumOfElements() {
            int result = 0;
            foreach (StackInfo si in info)
                result += si.size;
            return result;
        }

        Boolean isAllStackFull() {
            return NumOfElements() == values.Length;
        }

        //Adjust index to be within the range of 0 ~ length-1
        static int AdjustIndex(int index) {
            int max = values.Length;
            return ((index % max) + max) % max;
        }

        int PreviouIndex(int index){
            return AdjustIndex(index - 1);
        }

        int NextIndex(int index) {
            return AdjustIndex(index + 1);
        }

        public void print() {
            foreach (int i in values) {
                Console.WriteLine(i);
            }
        }
    }
}
