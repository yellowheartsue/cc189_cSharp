using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> myqueue = new MyQueue<int>();
            myqueue.add(1);
            myqueue.add(2);
            myqueue.add(3);
            myqueue.remove();
            Console.WriteLine(myqueue.peek());
            myqueue.add(4);
            myqueue.add(5);
            Console.WriteLine(myqueue.peek());
        }
    }
}
