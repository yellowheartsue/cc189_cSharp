using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._8
{
    class Program
    {
        static void Main(string[] args)
        {//Loop Detection: Given a circular linked list, implement an algrithm that returns the node at the beginning of the loop.

            LinkListNode n1 = new LinkListNode(1);
            n1.next = new LinkListNode(2);
            n1.next.next = new LinkListNode(3);
            
            LinkListNode collision = new LinkListNode(4);
            n1.next.next = collision;

            collision.next = new LinkListNode(5);
            collision.next.next = new LinkListNode(6);
            collision.next.next.next = new LinkListNode(7);
            collision.next.next.next.next = new LinkListNode(8);
            collision.next.next.next.next.next = new LinkListNode(9);
            collision.next.next.next.next.next.next = collision;

            if (isLoop(n1) != null)
                Console.WriteLine(isLoop(n1).data);
            else
                Console.WriteLine("Not a loop");

        }

        static LinkListNode isLoop(LinkListNode head) {
            LinkListNode slow = head;
            LinkListNode fast = head;

            while (fast != null && fast.next != null) {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast) { //loop
                    slow = head;
                    while (slow != fast){
                        slow = slow.next;
                        fast = fast.next;
                    }

                    return slow;
                } 
            } // if hit end of outer while loop, means not loop

            return null;
        }
    }
}
