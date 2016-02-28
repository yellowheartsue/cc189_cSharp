using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._1
{
    class Program
    {//simulate 3 stacks with one array

        static void Main(string[] args)
        {
            /*
            //method1. Fixed division.
            MultiFixedStack fixedStack = new MultiFixedStack(10);
            fixedStack.push(999, 1);
            fixedStack.push(52, 2);
            fixedStack.print();*/

            //method2. Flexible divisions.
            MultiStacksFlexi flexiStack = new MultiStacksFlexi(3, 3);
            flexiStack.push(999, 0);
            flexiStack.push(998, 0);
            flexiStack.push(997, 0);
            flexiStack.push(1, 2);
            flexiStack.push(2, 2);
            flexiStack.push(3, 2);
            flexiStack.push(4, 2);
            flexiStack.print();
        }

       
    }
}
