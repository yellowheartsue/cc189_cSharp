using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.push(5);
            stack.push(3);
            stack.push(2);
            stack.push(6);
            stack.push(7);

            stack = Sort(stack);

            while (!stack.isEmpty()) {
                Console.WriteLine(stack.pop());
            }
        }

        //O(n^2) time, O(n) space
        static Stack<int> Sort(Stack<int> stack) {
            Stack<int> stack2 = new Stack<int>();

            while (!stack.isEmpty()) {
                int temp = stack.pop();
                while ((!stack2.isEmpty()) && (temp < stack2.peek()))
                {
                    stack.push(stack2.pop());
                }
                stack2.push(temp);
            }

            while (!stack2.isEmpty())
                stack.push(stack2.pop());

            return stack;
        }
    }
}
