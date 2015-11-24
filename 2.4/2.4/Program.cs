using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._4
{
    class Program
    {//Partition: Write code to partition a linked list around value x, such that all nodes less than x come before all nodes greater than or equal to x. 
     //If x is contained within the list, the values of x only need to be after the elements less than x.
        static void Main(string[] args)
        {
            int[] intArray = new int[]{ 3, 5, 8, 5, 10, 2, 1 };         
            LinkListNode first = new LinkListNode(intArray[0]);
            LinkListNode head = first;

            for (int i = 1; i < intArray.Length; i++) {
                LinkListNode second = new LinkListNode(intArray[i]);
                first.next = second;
                first = second;
            }
            Console.WriteLine(head.printForward());

            LinkListNode newHead = partition2(head, 5);
            Console.WriteLine(newHead.printForward());
        }

        //method 1, make a small list and large list, then merge them (small.next = large.head). O(N) time, O(1) space
        static LinkListNode partition(LinkListNode head, int d)
        {
            LinkListNode s = null;
            LinkListNode sHead = null;
            LinkListNode l = null;
            LinkListNode lhead = null;

            LinkListNode n = head;

            while (n != null) {
                LinkListNode next = n.next;
                n.next = null; //otherwise stack overflow exception

                if (n.data < d)
                {
                    if (s == null)
                    {
                        sHead = n;
                        s = sHead;
                    }
                    else
                    {
                        s.next = n;
                        s = n;
                    }
                }
                else {
                    if (l == null)
                    {
                        lhead = n;
                        l = lhead;
                    }
                    else {
                        l.next = n;
                        l = n;
                    }
                }

                n = next;
            }

            if (s == null)
                return lhead;
            else {
                s.next = lhead;
                return sHead;
            }
        }

        //method2, keep 2 pointers, don't keep original order, O(N) time, O(1) space
        static LinkListNode partition2(LinkListNode node, int d) {
            LinkListNode head = node;
            LinkListNode tail = node;

            while (node != null) {
                LinkListNode next = node.next;

                if (node.data < d)
                {
                    node.next = head;
                    head = node;
                }
                else {
                    tail.next = node;
                    tail = node;
                }

                node = next;
            }

            tail.next = null; //otherwise stack overflow exception

            return head;
        }
    }
}
