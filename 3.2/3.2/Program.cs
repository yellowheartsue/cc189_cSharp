using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StackWithMin stack = new StackWithMin();
            stack.push(5);
            stack.push(6);
            stack.push(3);
            stack.push(7);
            Console.WriteLine(stack.Min());
            stack.pop();
            stack.pop();
            Console.WriteLine(stack.Min());

            StackWithMin2 stack2 = new StackWithMin2();
            stack2.push(5);
            stack2.push(6);
            stack2.push(3);
            stack2.push(7);
            Console.WriteLine(stack2.Min());
            stack2.pop();
            stack2.pop();
            Console.WriteLine(stack2.Min());

        }
    }
}
