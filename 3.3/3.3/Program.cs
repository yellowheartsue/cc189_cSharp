using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            SetOfStack sets = new SetOfStack(3);

            sets.push(1);
            sets.push(2);
            sets.push(3);
            sets.push(4);
            sets.push(5);
            sets.push(6);
            Console.WriteLine(sets.peek());
            sets.pop();
            sets.pop();
            sets.pop();
            Console.WriteLine(sets.peek());

            SetOfStackWithPopAt sets2 = new SetOfStackWithPopAt(3);
            sets2.push(1);
            sets2.push(2);
            sets2.push(3);
            sets2.push(4);
            sets2.push(5);
            sets2.push(6);
            Console.WriteLine(sets2.peek());
            sets2.popAt(0);
            Console.WriteLine(sets2.peek());
        }
    }
}
